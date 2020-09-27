/*
 Programmeur :      ziad Biram
 Date :             27 janvier 2020
 Bute :            Devoie1 - Phase 3 et 4 
 
 
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace RessourceHumaine
{
    public partial class RessourceHumaineForm : Form
    {
        #region Constructeur
        public RessourceHumaineForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Message 
        const string TITRE = "Filtrer les dossiers des employés";
        #endregion

        #region Evenmenet Load (Selection d'information avec filtre dans la table)
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             SELECT        Employees.EmployeeID, Employees.LastName, Employees.FirstName, Employees.Title, Employees.BirthDate, Employees.HireDate, Employees_1.FirstName AS Expr1, Employees_1.LastName AS Expr2, 
                           Employees.Photo

            FROM           Employees LEFT OUTER JOIN
                           Employees AS Employees_1 ON Employees.ReportsTo = Employees_1.EmployeeID
            
            WHERE          (Employees.PostalCode LIKE N'9%')
             */
            try
            {
                this.employeesTableAdapter.Fill(this.employeSuperviseur.Employees);
            }
            catch (Exception ex)
            {
                MessageBox.Show("une erreur indeterminer s'est produite lors du chargement des donnes", ex.ToString());
            }
        }
        #endregion

        #region Filtre evenement Click Partagé
        private void tousLesVendeurToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if(sender == tousLesVendeurToolStripMenuItem)
            {
                employeesBindingSource.Filter = "Title = 'Sales Representative'";
            }

            if(sender == tousLesEnmployeSansSuperviseurToolStripMenuItem)
            {
                employeesBindingSource.Filter = "Expr1 IS null AND Expr2 IS null";
            }

            if(sender == voirLesDossiersDeTousLesEmployésToolStripMenuItem)
            {
                employeesBindingSource.RemoveFilter();
            }
        }
        #endregion

        #region impression 
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for (int indice = 0; indice<=employeesBindingSource.Count-1;indice++)
            {
                //string affichage;
                DataRow oDataRow = (employeesBindingSource.List[indice] as DataRowView).Row;
                Console.WriteLine(String.Format("{0,-10}{1,-10}{2,-10}", oDataRow.ItemArray[0], oDataRow.ItemArray[1], oDataRow.ItemArray[2]));
            }
        }
        #endregion

        #region Evenement Partage pour les filtre avec saisie de l'utilisateur
        private void parNomDeFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String messageString = "Filtrer les dossiers d’employées dont {0}";
            String[] message = new String[3];
            message[0] = "le nom de famille contient le ou les caractères suivants:";
            message[1] = "la fonction est:";
            message[2] = "la date d'embauche est de l'année:";

            String[] filtre = new String[3];
            filtre[0] = "LastName Like '%{0}%'";
            filtre[1] = "Title = '{0}'";
            filtre[2] = "HireDate >= '{0}-01-01' and HireDate <= '{0}-12-31'";

            if (sender == parNomDeFamilleToolStripMenuItem)
            {
                messageString = String.Format(messageString, message[0]);
            }
            else if(sender == parFonctionToolStripMenuItem)
            {
                messageString = String.Format(messageString, message[1]);
            }
            else
            {
                messageString = String.Format(messageString, message[2]);
            }

            string reponseString = Interaction.InputBox(messageString, TITRE).Trim();

            if(reponseString != String.Empty)
            {
                if (sender == parNomDeFamilleToolStripMenuItem)
                {
                    employeesBindingSource.Filter = String.Format(filtre[0],reponseString);
                }
                else if (sender == parFonctionToolStripMenuItem)
                {
                    employeesBindingSource.Filter = String.Format(filtre[1], reponseString);
                }
                else
                {
                    string messageAnneeInvalide = "";

                    if (!AnneeEmbaucheValide(reponseString, ref messageAnneeInvalide))
                    {
                        MessageBox.Show(messageAnneeInvalide);
                    }
                    else
                    {
                        employeesBindingSource.Filter = String.Format(filtre[2], reponseString);
                    }
                }
            }
        }
        #endregion

        #region Validation de la date
        private Boolean AnneeEmbaucheValide(string anneeEmbauche, ref string messageAnneeInvalide)
        {
            int valeur;
            bool varBool;

            if (int.TryParse(anneeEmbauche,out valeur) && anneeEmbauche.Length == 4)
            {
                if (valeur >= 1 && valeur <= 9999)
                {
                    varBool = true;
                }
                else
                {
                    messageAnneeInvalide = "L'année doit être positive.";
                    varBool = false;
                }
            }
            else
            {
                messageAnneeInvalide = "L'année est un nombre de 4 chiffres.";
                varBool = false;
            }

            return varBool;
        }

        #endregion

        #region Evenement Partagé Pour l'arrangement 
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == nomEtPrénomDuSuperviseurToolStripMenuItem)
            {
                employeesBindingSource.Sort = "LastName DESC,FirstName DESC";
            }
            else if (sender == fonctionNomEtPrénomDeLemployéToolStripMenuItem)
            {
                employeesBindingSource.Sort = "Title ASC, LastName DESC,FirstName DESC";
            }
            else if (sender == dateDembocheToolStripMenuItem)
            {
                employeesBindingSource.Sort = "HireDate ASC";
            }
            else
            {
                employeesBindingSource.Sort = "EmployeeID ASC";
            }
        }
        #endregion
    }
}
