namespace RessourceHumaine
{
    partial class RessourceHumaineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label supereviseurNomExpLabel;
            System.Windows.Forms.Label supereviseurPrenomExpLabel;
            System.Windows.Forms.Label photoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RessourceHumaineForm));
            this.employeSuperviseur = new RessourceHumaine.EmployeSuperviseur();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new RessourceHumaine.EmployeSuperviseurTableAdapters.EmployeesTableAdapter();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tousLesVendeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parNomDeFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFonctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateDembocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nomEtPrénomDuSuperviseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateDembocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordreOriginaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeIDLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.birthDateLabel1 = new System.Windows.Forms.Label();
            this.hireDateLabel1 = new System.Windows.Forms.Label();
            this.expr1Label1 = new System.Windows.Forms.Label();
            this.expr2Label1 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            employeeIDLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            supereviseurNomExpLabel = new System.Windows.Forms.Label();
            supereviseurPrenomExpLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeSuperviseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(23, 60);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(50, 13);
            employeeIDLabel.TabIndex = 1;
            employeeIDLabel.Text = "Numero :";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(23, 100);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(82, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Nom de famille :";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(23, 140);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(49, 13);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "Prenom :";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 180);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(54, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Fonction :";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(23, 220);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(104, 13);
            birthDateLabel.TabIndex = 9;
            birthDateLabel.Text = "Date de Niassance :";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(23, 260);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(85, 13);
            hireDateLabel.TabIndex = 11;
            hireDateLabel.Text = "Date d\'emboche";
            // 
            // supereviseurNomExpLabel
            // 
            supereviseurNomExpLabel.AutoSize = true;
            supereviseurNomExpLabel.Location = new System.Drawing.Point(23, 300);
            supereviseurNomExpLabel.Name = "supereviseurNomExpLabel";
            supereviseurNomExpLabel.Size = new System.Drawing.Size(107, 13);
            supereviseurNomExpLabel.TabIndex = 13;
            supereviseurNomExpLabel.Text = "Nom du superviseur :";
            // 
            // supereviseurPrenomExpLabel
            // 
            supereviseurPrenomExpLabel.AutoSize = true;
            supereviseurPrenomExpLabel.Location = new System.Drawing.Point(23, 340);
            supereviseurPrenomExpLabel.Name = "supereviseurPrenomExpLabel";
            supereviseurPrenomExpLabel.Size = new System.Drawing.Size(121, 13);
            supereviseurPrenomExpLabel.TabIndex = 15;
            supereviseurPrenomExpLabel.Text = "Prenom du superviseur :";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(394, 63);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 17;
            photoLabel.Text = "Photo:";
            // 
            // employeSuperviseur
            // 
            this.employeSuperviseur.DataSetName = "EmployeSuperviseur";
            this.employeSuperviseur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeSuperviseur;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = null;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = null;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RessourceHumaine.Properties.Resources.print_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesVendeurToolStripMenuItem,
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem,
            this.parNomDeFamilleToolStripMenuItem,
            this.parFonctionToolStripMenuItem,
            this.parDateDembocheToolStripMenuItem,
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::RessourceHumaine.Properties.Resources.Very_Basic_Filter_Filled_icon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tousLesVendeurToolStripMenuItem
            // 
            this.tousLesVendeurToolStripMenuItem.Name = "tousLesVendeurToolStripMenuItem";
            this.tousLesVendeurToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.tousLesVendeurToolStripMenuItem.Text = "Tous les vendeur";
            this.tousLesVendeurToolStripMenuItem.Click += new System.EventHandler(this.tousLesVendeurToolStripMenuItem_Click_1);
            // 
            // tousLesEnmployeSansSuperviseurToolStripMenuItem
            // 
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem.Name = "tousLesEnmployeSansSuperviseurToolStripMenuItem";
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem.Text = "Tous les enmployés sans superviseur";
            this.tousLesEnmployeSansSuperviseurToolStripMenuItem.Click += new System.EventHandler(this.tousLesVendeurToolStripMenuItem_Click_1);
            // 
            // parNomDeFamilleToolStripMenuItem
            // 
            this.parNomDeFamilleToolStripMenuItem.Name = "parNomDeFamilleToolStripMenuItem";
            this.parNomDeFamilleToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.parNomDeFamilleToolStripMenuItem.Text = "Par Nom de famille...";
            this.parNomDeFamilleToolStripMenuItem.Click += new System.EventHandler(this.parNomDeFamilleToolStripMenuItem_Click);
            // 
            // parFonctionToolStripMenuItem
            // 
            this.parFonctionToolStripMenuItem.Name = "parFonctionToolStripMenuItem";
            this.parFonctionToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.parFonctionToolStripMenuItem.Text = "Par Fonction";
            this.parFonctionToolStripMenuItem.Click += new System.EventHandler(this.parNomDeFamilleToolStripMenuItem_Click);
            // 
            // parDateDembocheToolStripMenuItem
            // 
            this.parDateDembocheToolStripMenuItem.Name = "parDateDembocheToolStripMenuItem";
            this.parDateDembocheToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.parDateDembocheToolStripMenuItem.Text = "Par date d\'emboche";
            this.parDateDembocheToolStripMenuItem.Click += new System.EventHandler(this.parNomDeFamilleToolStripMenuItem_Click);
            // 
            // voirLesDossiersDeTousLesEmployésToolStripMenuItem
            // 
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Name = "voirLesDossiersDeTousLesEmployésToolStripMenuItem";
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Text = "Voir les dossiers de tous les employés";
            this.voirLesDossiersDeTousLesEmployésToolStripMenuItem.Click += new System.EventHandler(this.tousLesVendeurToolStripMenuItem_Click_1);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomEtPrénomDuSuperviseurToolStripMenuItem,
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem,
            this.dateDembocheToolStripMenuItem,
            this.ordreOriginaleToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::RessourceHumaine.Properties.Resources.Actions_view_sort_ascending_icon;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // nomEtPrénomDuSuperviseurToolStripMenuItem
            // 
            this.nomEtPrénomDuSuperviseurToolStripMenuItem.Image = global::RessourceHumaine.Properties.Resources.sort_columns_icon;
            this.nomEtPrénomDuSuperviseurToolStripMenuItem.Name = "nomEtPrénomDuSuperviseurToolStripMenuItem";
            this.nomEtPrénomDuSuperviseurToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.nomEtPrénomDuSuperviseurToolStripMenuItem.Text = "Nom et prénom du superviseur";
            this.nomEtPrénomDuSuperviseurToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // fonctionNomEtPrénomDeLemployéToolStripMenuItem
            // 
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem.Image = global::RessourceHumaine.Properties.Resources.sort_columns_icon;
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem.Name = "fonctionNomEtPrénomDeLemployéToolStripMenuItem";
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem.Text = "Fonction, nom et prénom de l\'employé";
            this.fonctionNomEtPrénomDeLemployéToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // dateDembocheToolStripMenuItem
            // 
            this.dateDembocheToolStripMenuItem.Image = global::RessourceHumaine.Properties.Resources.sort_columns_icon;
            this.dateDembocheToolStripMenuItem.Name = "dateDembocheToolStripMenuItem";
            this.dateDembocheToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.dateDembocheToolStripMenuItem.Text = "Date d\'emboche";
            this.dateDembocheToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // ordreOriginaleToolStripMenuItem
            // 
            this.ordreOriginaleToolStripMenuItem.Image = global::RessourceHumaine.Properties.Resources.sort_columns_icon;
            this.ordreOriginaleToolStripMenuItem.Name = "ordreOriginaleToolStripMenuItem";
            this.ordreOriginaleToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.ordreOriginaleToolStripMenuItem.Text = "Ordre originale";
            this.ordreOriginaleToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // employeeIDLabel1
            // 
            this.employeeIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeID", true));
            this.employeeIDLabel1.Location = new System.Drawing.Point(148, 60);
            this.employeeIDLabel1.Name = "employeeIDLabel1";
            this.employeeIDLabel1.Size = new System.Drawing.Size(177, 23);
            this.employeeIDLabel1.TabIndex = 2;
            this.employeeIDLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameLabel1.Location = new System.Drawing.Point(148, 100);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(177, 23);
            this.lastNameLabel1.TabIndex = 4;
            this.lastNameLabel1.Text = "label1";
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameLabel1.Location = new System.Drawing.Point(148, 140);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(177, 23);
            this.firstNameLabel1.TabIndex = 6;
            this.firstNameLabel1.Text = "label1";
            // 
            // titleLabel1
            // 
            this.titleLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Title", true));
            this.titleLabel1.Location = new System.Drawing.Point(148, 180);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(177, 23);
            this.titleLabel1.TabIndex = 8;
            this.titleLabel1.Text = "label1";
            // 
            // birthDateLabel1
            // 
            this.birthDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BirthDate", true));
            this.birthDateLabel1.Location = new System.Drawing.Point(148, 220);
            this.birthDateLabel1.Name = "birthDateLabel1";
            this.birthDateLabel1.Size = new System.Drawing.Size(177, 23);
            this.birthDateLabel1.TabIndex = 10;
            this.birthDateLabel1.Text = "label1";
            // 
            // hireDateLabel1
            // 
            this.hireDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hireDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HireDate", true));
            this.hireDateLabel1.Location = new System.Drawing.Point(148, 260);
            this.hireDateLabel1.Name = "hireDateLabel1";
            this.hireDateLabel1.Size = new System.Drawing.Size(177, 23);
            this.hireDateLabel1.TabIndex = 12;
            this.hireDateLabel1.Text = "label1";
            // 
            // expr1Label1
            // 
            this.expr1Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expr1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Expr1", true));
            this.expr1Label1.Location = new System.Drawing.Point(148, 300);
            this.expr1Label1.Name = "expr1Label1";
            this.expr1Label1.Size = new System.Drawing.Size(177, 23);
            this.expr1Label1.TabIndex = 14;
            this.expr1Label1.Text = "label1";
            // 
            // expr2Label1
            // 
            this.expr2Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expr2Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Expr2", true));
            this.expr2Label1.Location = new System.Drawing.Point(148, 340);
            this.expr2Label1.Name = "expr2Label1";
            this.expr2Label1.Size = new System.Drawing.Size(177, 23);
            this.expr2Label1.TabIndex = 16;
            this.expr2Label1.Text = "label1";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(397, 88);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(292, 275);
            this.photoPictureBox.TabIndex = 18;
            this.photoPictureBox.TabStop = false;
            // 
            // RessourceHumaineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDLabel1);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateLabel1);
            this.Controls.Add(hireDateLabel);
            this.Controls.Add(this.hireDateLabel1);
            this.Controls.Add(supereviseurNomExpLabel);
            this.Controls.Add(this.expr1Label1);
            this.Controls.Add(supereviseurPrenomExpLabel);
            this.Controls.Add(this.expr2Label1);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Name = "RessourceHumaineForm";
            this.Text = "Ressource Humaine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeSuperviseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeSuperviseur employeSuperviseur;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeSuperviseurTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label employeeIDLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label birthDateLabel1;
        private System.Windows.Forms.Label hireDateLabel1;
        private System.Windows.Forms.Label expr1Label1;
        private System.Windows.Forms.Label expr2Label1;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tousLesVendeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesEnmployeSansSuperviseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parNomDeFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFonctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateDembocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesDossiersDeTousLesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem nomEtPrénomDuSuperviseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonctionNomEtPrénomDeLemployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateDembocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordreOriginaleToolStripMenuItem;
    }
}

