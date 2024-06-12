namespace Event_manager.Views
{
    partial class EventView
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
            components = new System.ComponentModel.Container();
            button_add = new Button();
            button_save = new Button();
            button_remove = new Button();
            textBox_name = new TextBox();
            textBox2 = new TextBox();
            textBox_description = new TextBox();
            comboBox_type = new ComboBox();
            comboBox_priority = new ComboBox();
            dataGridView = new DataGridView();
            dateTimePicker_date = new DateTimePicker();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button_load = new Button();
            errorProvider1 = new ErrorProvider(components);
            FilterHighPriority = new CheckBox();
            textBox6 = new TextBox();
            FilterMediumPriority = new CheckBox();
            FilterLowPriority = new CheckBox();
            textBox7 = new TextBox();
            FilterFamily = new CheckBox();
            FilterEntertainmen = new CheckBox();
            FilterWork = new CheckBox();
            FilterHealth = new CheckBox();
            FilterSport = new CheckBox();
            textBox8 = new TextBox();
            FilterStartDate = new DateTimePicker();
            FilterEndDate = new DateTimePicker();
            button_filter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(292, 384);
            button_add.Name = "button_add";
            button_add.Size = new Size(140, 30);
            button_add.TabIndex = 0;
            button_add.Text = "Dodaj";
            button_add.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Location = new Point(584, 384);
            button_save.Name = "button_save";
            button_save.Size = new Size(140, 30);
            button_save.TabIndex = 1;
            button_save.Text = "Zapisz";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(438, 384);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(140, 30);
            button_remove.TabIndex = 2;
            button_remove.Text = "Usuń";
            button_remove.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(12, 38);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(248, 27);
            textBox_name.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 20);
            textBox2.TabIndex = 4;
            textBox2.Text = "Nazwa";
            // 
            // textBox_description
            // 
            textBox_description.Location = new Point(12, 97);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(248, 138);
            textBox_description.TabIndex = 5;
            // 
            // comboBox_type
            // 
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new Point(12, 386);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new Size(248, 28);
            comboBox_type.TabIndex = 6;
            // 
            // comboBox_priority
            // 
            comboBox_priority.FormattingEnabled = true;
            comboBox_priority.Location = new Point(12, 326);
            comboBox_priority.Name = "comboBox_priority";
            comboBox_priority.Size = new Size(248, 28);
            comboBox_priority.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(292, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 50;
            dataGridView.Size = new Size(575, 354);
            dataGridView.TabIndex = 8;
            // 
            // dateTimePicker_date
            // 
            dateTimePicker_date.CustomFormat = "dd.MM.yyyy   HH:mm";
            dateTimePicker_date.Format = DateTimePickerFormat.Custom;
            dateTimePicker_date.Location = new Point(12, 267);
            dateTimePicker_date.Name = "dateTimePicker_date";
            dateTimePicker_date.Size = new Size(248, 27);
            dateTimePicker_date.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 71);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 10;
            textBox1.Text = "Opis";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(12, 241);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 20);
            textBox3.TabIndex = 11;
            textBox3.Text = "Data";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(12, 360);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 20);
            textBox4.TabIndex = 12;
            textBox4.Text = "Rodzaj";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(12, 300);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 20);
            textBox5.TabIndex = 13;
            textBox5.Text = "Priorytet";
            // 
            // button_load
            // 
            button_load.Location = new Point(727, 384);
            button_load.Name = "button_load";
            button_load.Size = new Size(140, 30);
            button_load.TabIndex = 14;
            button_load.Text = "Wczytaj";
            button_load.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FilterHighPriority
            // 
            FilterHighPriority.AutoSize = true;
            FilterHighPriority.Location = new Point(891, 38);
            FilterHighPriority.Name = "FilterHighPriority";
            FilterHighPriority.Size = new Size(78, 24);
            FilterHighPriority.TabIndex = 15;
            FilterHighPriority.Text = "Wysoki";
            FilterHighPriority.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(891, 12);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 20);
            textBox6.TabIndex = 16;
            textBox6.Text = "Priorytet";
            // 
            // FilterMediumPriority
            // 
            FilterMediumPriority.AutoSize = true;
            FilterMediumPriority.Location = new Point(891, 68);
            FilterMediumPriority.Name = "FilterMediumPriority";
            FilterMediumPriority.Size = new Size(73, 24);
            FilterMediumPriority.TabIndex = 17;
            FilterMediumPriority.Text = "Średni";
            FilterMediumPriority.UseVisualStyleBackColor = true;
            // 
            // FilterLowPriority
            // 
            FilterLowPriority.AutoSize = true;
            FilterLowPriority.Location = new Point(891, 94);
            FilterLowPriority.Name = "FilterLowPriority";
            FilterLowPriority.Size = new Size(63, 24);
            FilterLowPriority.TabIndex = 18;
            FilterLowPriority.Text = "Niski";
            FilterLowPriority.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(891, 124);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 20);
            textBox7.TabIndex = 19;
            textBox7.Text = "Rodzaj";
            // 
            // FilterFamily
            // 
            FilterFamily.AutoSize = true;
            FilterFamily.Location = new Point(891, 150);
            FilterFamily.Name = "FilterFamily";
            FilterFamily.Size = new Size(85, 24);
            FilterFamily.TabIndex = 20;
            FilterFamily.Text = "Rodzina";
            FilterFamily.UseVisualStyleBackColor = true;
            // 
            // FilterEntertainmen
            // 
            FilterEntertainmen.AutoSize = true;
            FilterEntertainmen.Location = new Point(891, 180);
            FilterEntertainmen.Name = "FilterEntertainmen";
            FilterEntertainmen.Size = new Size(94, 24);
            FilterEntertainmen.TabIndex = 21;
            FilterEntertainmen.Text = "Rozrywka";
            FilterEntertainmen.UseVisualStyleBackColor = true;
            // 
            // FilterWork
            // 
            FilterWork.AutoSize = true;
            FilterWork.Location = new Point(891, 208);
            FilterWork.Name = "FilterWork";
            FilterWork.Size = new Size(67, 24);
            FilterWork.TabIndex = 22;
            FilterWork.Text = "Praca";
            FilterWork.UseVisualStyleBackColor = true;
            // 
            // FilterHealth
            // 
            FilterHealth.AutoSize = true;
            FilterHealth.Location = new Point(891, 234);
            FilterHealth.Name = "FilterHealth";
            FilterHealth.Size = new Size(86, 24);
            FilterHealth.TabIndex = 23;
            FilterHealth.Text = "Zdrowie";
            FilterHealth.UseVisualStyleBackColor = true;
            // 
            // FilterSport
            // 
            FilterSport.AutoSize = true;
            FilterSport.Location = new Point(891, 264);
            FilterSport.Name = "FilterSport";
            FilterSport.Size = new Size(67, 24);
            FilterSport.TabIndex = 24;
            FilterSport.Text = "Sport";
            FilterSport.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(891, 294);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(125, 20);
            textBox8.TabIndex = 25;
            textBox8.Text = "Data od ... do ...";
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // FilterStartDate
            // 
            FilterStartDate.CustomFormat = "dd.MM.yyyy   HH:mm";
            FilterStartDate.Format = DateTimePickerFormat.Custom;
            FilterStartDate.Location = new Point(891, 320);
            FilterStartDate.Name = "FilterStartDate";
            FilterStartDate.Size = new Size(162, 27);
            FilterStartDate.TabIndex = 26;
            // 
            // FilterEndDate
            // 
            FilterEndDate.CustomFormat = "dd.MM.yyyy   HH:mm";
            FilterEndDate.Format = DateTimePickerFormat.Custom;
            FilterEndDate.Location = new Point(891, 353);
            FilterEndDate.Name = "FilterEndDate";
            FilterEndDate.Size = new Size(162, 27);
            FilterEndDate.TabIndex = 27;
            // 
            // button_filter
            // 
            button_filter.Location = new Point(891, 386);
            button_filter.Name = "button_filter";
            button_filter.Size = new Size(162, 30);
            button_filter.TabIndex = 28;
            button_filter.Text = "Filtruj";
            button_filter.UseVisualStyleBackColor = true;
            // 
            // EventView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 432);
            Controls.Add(button_filter);
            Controls.Add(FilterEndDate);
            Controls.Add(FilterStartDate);
            Controls.Add(textBox8);
            Controls.Add(FilterSport);
            Controls.Add(FilterHealth);
            Controls.Add(FilterWork);
            Controls.Add(FilterEntertainmen);
            Controls.Add(FilterFamily);
            Controls.Add(textBox7);
            Controls.Add(FilterLowPriority);
            Controls.Add(FilterMediumPriority);
            Controls.Add(textBox6);
            Controls.Add(FilterHighPriority);
            Controls.Add(button_load);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker_date);
            Controls.Add(dataGridView);
            Controls.Add(comboBox_priority);
            Controls.Add(comboBox_type);
            Controls.Add(textBox_description);
            Controls.Add(textBox2);
            Controls.Add(textBox_name);
            Controls.Add(button_remove);
            Controls.Add(button_save);
            Controls.Add(button_add);
            MaximizeBox = false;
            Name = "EventView";
            Text = "Event manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private Button button_save;
        private Button button_remove;
        private TextBox textBox_name;
        private TextBox textBox2;
        private TextBox textBox_description;
        private ComboBox comboBox_type;
        private ComboBox comboBox_priority;
        private DataGridView dataGridView;
        private DateTimePicker dateTimePicker_date;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button_load;
        private ErrorProvider errorProvider1;
        private CheckBox FilterHealth;
        private CheckBox FilterWork;
        private CheckBox FilterEntertainmen;
        private CheckBox FilterFamily;
        private TextBox textBox7;
        private CheckBox FilterLowPriority;
        private CheckBox FilterMediumPriority;
        private TextBox textBox6;
        private CheckBox FilterHighPriority;
        private CheckBox FilterSport;
        private DateTimePicker FilterEndDate;
        private DateTimePicker FilterStartDate;
        private TextBox textBox8;
        private Button button_filter;
    }
}