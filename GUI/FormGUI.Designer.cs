namespace GUI
{
    partial class FormGUI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.outputBox = new System.Windows.Forms.DataGridView();
            this.column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonCreate = new System.Windows.Forms.ToolStripButton();
            this.buttonOpen = new System.Windows.Forms.ToolStripButton();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonCancel = new System.Windows.Forms.ToolStripButton();
            this.buttonReturn = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.ToolStripButton();
            this.buttonCut = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.buttonRun = new System.Windows.Forms.ToolStripButton();
            this.buttonHelp = new System.Windows.Forms.ToolStripButton();
            this.buttonAboutProgram = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выделениеВсегоТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаЯзыкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГрамматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.локалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.китайскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.files = new System.Windows.Forms.TabControl();
            this.statusLine = new System.Windows.Forms.StatusStrip();
            this.statusFont = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTimeApp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerApp = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // outputBox
            // 
            this.outputBox.AllowUserToAddRows = false;
            this.outputBox.AllowUserToDeleteRows = false;
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputBox.ColumnHeadersHeight = 29;
            this.outputBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column0,
            this.Column1,
            this.Column2,
            this.Column3});
            this.outputBox.Location = new System.Drawing.Point(12, 440);
            this.outputBox.Name = "outputBox";
            this.outputBox.RowHeadersVisible = false;
            this.outputBox.RowHeadersWidth = 51;
            this.outputBox.RowTemplate.Height = 24;
            this.outputBox.Size = new System.Drawing.Size(951, 214);
            this.outputBox.TabIndex = 1;
            // 
            // column0
            // 
            this.column0.HeaderText = "Путь к файлу";
            this.column0.MinimumWidth = 6;
            this.column0.Name = "column0";
            this.column0.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Строка";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Столбец";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Описание";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1, 2, 2, 1);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCreate,
            this.buttonOpen,
            this.buttonSave,
            this.buttonCancel,
            this.buttonReturn,
            this.buttonCopy,
            this.buttonCut,
            this.buttonPaste,
            this.buttonRun,
            this.buttonHelp,
            this.buttonAboutProgram});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(975, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonCreate
            // 
            this.buttonCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCreate.Image = global::GUI.Properties.Resources.iconAdd;
            this.buttonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonCreate.Size = new System.Drawing.Size(34, 34);
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.Click += new System.EventHandler(this.CreatFile_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpen.Image = global::GUI.Properties.Resources.iconOpen;
            this.buttonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonOpen.Size = new System.Drawing.Size(34, 34);
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = global::GUI.Properties.Resources.iconSave;
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonSave.Size = new System.Drawing.Size(34, 34);
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Image = global::GUI.Properties.Resources.iconCancel;
            this.buttonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonCancel.Size = new System.Drawing.Size(34, 34);
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Image = global::GUI.Properties.Resources.iconReturn;
            this.buttonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonReturn.Size = new System.Drawing.Size(34, 34);
            this.buttonReturn.Text = "Вернуть";
            this.buttonReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = global::GUI.Properties.Resources.iconCopy;
            this.buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonCopy.Size = new System.Drawing.Size(34, 34);
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // buttonCut
            // 
            this.buttonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCut.Enabled = false;
            this.buttonCut.Image = global::GUI.Properties.Resources.iconCut;
            this.buttonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonCut.Size = new System.Drawing.Size(34, 34);
            this.buttonCut.Text = "Вырезать";
            this.buttonCut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPaste.Enabled = false;
            this.buttonPaste.Image = global::GUI.Properties.Resources.iconPaste;
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonPaste.Size = new System.Drawing.Size(34, 34);
            this.buttonPaste.Text = "Вставить";
            this.buttonPaste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRun.Enabled = false;
            this.buttonRun.Image = global::GUI.Properties.Resources.iconRun;
            this.buttonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonRun.Size = new System.Drawing.Size(34, 34);
            this.buttonRun.Text = "Пуск";
            this.buttonRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonHelp.Image = global::GUI.Properties.Resources.iconHelp;
            this.buttonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonHelp.Size = new System.Drawing.Size(34, 34);
            this.buttonHelp.Text = "Вызов справки";
            this.buttonHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // buttonAboutProgram
            // 
            this.buttonAboutProgram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAboutProgram.Image = global::GUI.Properties.Resources.iconAboutProgram;
            this.buttonAboutProgram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAboutProgram.Name = "buttonAboutProgram";
            this.buttonAboutProgram.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.buttonAboutProgram.Size = new System.Drawing.Size(34, 34);
            this.buttonAboutProgram.Text = "О программе";
            this.buttonAboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.локалиToolStripMenuItem,
            this.размерТекстаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.toolStripSeparator3,
            this.сохранениеToolStripMenuItem,
            this.сохранениеКакToolStripMenuItem,
            this.toolStripSeparator4,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // созданиеToolStripMenuItem
            // 
            this.созданиеToolStripMenuItem.Name = "созданиеToolStripMenuItem";
            this.созданиеToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.созданиеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.созданиеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.созданиеToolStripMenuItem.Text = "Создать";
            this.созданиеToolStripMenuItem.Click += new System.EventHandler(this.CreatFile_Click);
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.открытиеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.открытиеToolStripMenuItem.Text = "Открыть";
            this.открытиеToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(222, 6);
            // 
            // сохранениеToolStripMenuItem
            // 
            this.сохранениеToolStripMenuItem.Enabled = false;
            this.сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            this.сохранениеToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.сохранениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранениеToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранениеToolStripMenuItem.Text = "Сохранить";
            this.сохранениеToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // сохранениеКакToolStripMenuItem
            // 
            this.сохранениеКакToolStripMenuItem.Enabled = false;
            this.сохранениеКакToolStripMenuItem.Name = "сохранениеКакToolStripMenuItem";
            this.сохранениеКакToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.сохранениеКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранениеКакToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.сохранениеКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранениеКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAsFile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(222, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCancel,
            this.MenuItemReturn,
            this.toolStripSeparator1,
            this.MenuItemCut,
            this.MenuItemCopy,
            this.MenuItemPaste,
            this.MenuItemDelete,
            this.toolStripSeparator2,
            this.выделениеВсегоТекстаToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // MenuItemCancel
            // 
            this.MenuItemCancel.Enabled = false;
            this.MenuItemCancel.Name = "MenuItemCancel";
            this.MenuItemCancel.ShortcutKeyDisplayString = "Ctrl+Z";
            this.MenuItemCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.MenuItemCancel.Size = new System.Drawing.Size(190, 22);
            this.MenuItemCancel.Text = "Отмена";
            this.MenuItemCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MenuItemReturn
            // 
            this.MenuItemReturn.Enabled = false;
            this.MenuItemReturn.Name = "MenuItemReturn";
            this.MenuItemReturn.ShortcutKeyDisplayString = "Ctrl+Y";
            this.MenuItemReturn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.MenuItemReturn.Size = new System.Drawing.Size(190, 22);
            this.MenuItemReturn.Text = "Возрат";
            this.MenuItemReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Enabled = false;
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.MenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemCut.Size = new System.Drawing.Size(190, 22);
            this.MenuItemCut.Text = "Вырезать";
            this.MenuItemCut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // MenuItemCopy
            // 
            this.MenuItemCopy.Enabled = false;
            this.MenuItemCopy.Name = "MenuItemCopy";
            this.MenuItemCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.MenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.MenuItemCopy.Size = new System.Drawing.Size(190, 22);
            this.MenuItemCopy.Text = "Копировать";
            this.MenuItemCopy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Enabled = false;
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.MenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemPaste.Size = new System.Drawing.Size(190, 22);
            this.MenuItemPaste.Text = "Вставить";
            this.MenuItemPaste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Enabled = false;
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeyDisplayString = "Delete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuItemDelete.Size = new System.Drawing.Size(190, 22);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // выделениеВсегоТекстаToolStripMenuItem
            // 
            this.выделениеВсегоТекстаToolStripMenuItem.Enabled = false;
            this.выделениеВсегоТекстаToolStripMenuItem.Name = "выделениеВсегоТекстаToolStripMenuItem";
            this.выделениеВсегоТекстаToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.выделениеВсегоТекстаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделениеВсегоТекстаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.выделениеВсегоТекстаToolStripMenuItem.Text = "Выделить все";
            this.выделениеВсегоТекстаToolStripMenuItem.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаЯзыкаToolStripMenuItem,
            this.классификацияГрамматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            this.постановкаЗадачиToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // грамматикаЯзыкаToolStripMenuItem
            // 
            this.грамматикаЯзыкаToolStripMenuItem.Name = "грамматикаЯзыкаToolStripMenuItem";
            this.грамматикаЯзыкаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.грамматикаЯзыкаToolStripMenuItem.Text = "Грамматика";
            this.грамматикаЯзыкаToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            this.классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            this.классификацияГрамматикиToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            this.классификацияГрамматикиToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            this.методАнализаToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            this.тестовыйПримерToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            this.списокЛитературыToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            this.исходныйКодПрограммыToolStripMenuItem.Click += new System.EventHandler(this.textWork_Click);
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.AutoToolTip = true;
            this.пускToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.пускToolStripMenuItem.Enabled = false;
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.ShortcutKeyDisplayString = "F5";
            this.пускToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.пускToolStripMenuItem.Text = "Пуск";
            this.пускToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.пускToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.пускToolStripMenuItem.ToolTipText = "Пуск (F5)";
            this.пускToolStripMenuItem.Click += new System.EventHandler(this.Run_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиToolStripMenuItem
            // 
            this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            this.вызовСправкиToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F1";
            this.вызовСправкиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            this.вызовСправкиToolStripMenuItem.Click += new System.EventHandler(this.Help_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F2";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // локалиToolStripMenuItem
            // 
            this.локалиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.китайскийToolStripMenuItem});
            this.локалиToolStripMenuItem.Name = "локалиToolStripMenuItem";
            this.локалиToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.локалиToolStripMenuItem.Text = "Локализация";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.RusLg_Click);
            // 
            // китайскийToolStripMenuItem
            // 
            this.китайскийToolStripMenuItem.Name = "китайскийToolStripMenuItem";
            this.китайскийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.китайскийToolStripMenuItem.Text = "Китайский";
            this.китайскийToolStripMenuItem.Click += new System.EventHandler(this.ChinaLg);
            // 
            // размерТекстаToolStripMenuItem
            // 
            this.размерТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.размерТекстаToolStripMenuItem.Name = "размерТекстаToolStripMenuItem";
            this.размерТекстаToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.размерТекстаToolStripMenuItem.Text = "Размер текста";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+ +";
            this.увеличитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.fontSize_Up);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+ –";
            this.уменьшитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.fontSize_Down);
            // 
            // files
            // 
            this.files.AllowDrop = true;
            this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.files.Cursor = System.Windows.Forms.Cursors.Default;
            this.files.ItemSize = new System.Drawing.Size(65, 30);
            this.files.Location = new System.Drawing.Point(12, 73);
            this.files.Name = "files";
            this.files.SelectedIndex = 0;
            this.files.Size = new System.Drawing.Size(951, 338);
            this.files.TabIndex = 4;
            this.files.SelectedIndexChanged += new System.EventHandler(this.files_SelectedIndexChanged);
            this.files.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragDrop);
            this.files.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragEnter);
            // 
            // statusLine
            // 
            this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusFont,
            this.statusTimeApp});
            this.statusLine.Location = new System.Drawing.Point(0, 657);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(975, 22);
            this.statusLine.TabIndex = 2;
            this.statusLine.Text = "statusStrip1";
            // 
            // statusFont
            // 
            this.statusFont.Name = "statusFont";
            this.statusFont.Size = new System.Drawing.Size(118, 17);
            this.statusFont.Text = "Шрифт: Segoe UI 9pt";
            // 
            // statusTimeApp
            // 
            this.statusTimeApp.Name = "statusTimeApp";
            this.statusTimeApp.Size = new System.Drawing.Size(195, 17);
            this.statusTimeApp.Text = "Время работы приложения: 0 cек.";
            // 
            // timerApp
            // 
            this.timerApp.Enabled = true;
            this.timerApp.Interval = 1000;
            this.timerApp.Tick += new System.EventHandler(this.timerApp_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\"";
            // 
            // FormGUI
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(975, 679);
            this.Controls.Add(this.files);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.statusLine);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compiler";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormGUI_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusLine.ResumeLayout(false);
            this.statusLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.DataGridView outputBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCancel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem выделениеВсегоТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReturn;
        private System.Windows.Forms.ToolStripButton buttonCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonOpen;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripButton buttonCancel;
        private System.Windows.Forms.ToolStripButton buttonReturn;
        private System.Windows.Forms.ToolStripButton buttonCopy;
        private System.Windows.Forms.ToolStripButton buttonCut;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.ToolStripButton buttonRun;
        private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton buttonHelp;
        private System.Windows.Forms.ToolStripButton buttonAboutProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem локалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.TabControl files;
        private System.Windows.Forms.StatusStrip statusLine;
        private System.Windows.Forms.ToolStripStatusLabel statusFont;
        private System.Windows.Forms.Timer timerApp;
        private System.Windows.Forms.ToolStripStatusLabel statusTimeApp;
        private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаЯзыкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem китайскийToolStripMenuItem;
    }
}

