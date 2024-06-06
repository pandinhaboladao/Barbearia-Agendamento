namespace AgendamentoServicos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonConfirmar = new Button();
            textBoxNome = new TextBox();
            textBoxContato = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerData = new DateTimePicker();
            comboBoxServico = new ComboBox();
            button2 = new Button();
            comboBoxHora = new ComboBox();
            dataGridViewAgenda = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Serviço = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirmar.Location = new Point(349, 574);
            buttonConfirmar.Margin = new Padding(4, 5, 4, 5);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(209, 84);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click_1;
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = Color.SlateGray;
            textBoxNome.Font = new Font("Old English Text MT", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.ForeColor = SystemColors.InactiveBorder;
            textBoxNome.Location = new Point(325, 410);
            textBoxNome.Margin = new Padding(4, 5, 4, 5);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(260, 34);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxContato
            // 
            textBoxContato.BackColor = Color.SlateGray;
            textBoxContato.Font = new Font("Old English Text MT", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContato.ForeColor = SystemColors.Menu;
            textBoxContato.Location = new Point(325, 484);
            textBoxContato.Margin = new Padding(4, 5, 4, 5);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(260, 34);
            textBoxContato.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(325, 141);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 33);
            label1.TabIndex = 3;
            label1.Text = "Informe a data";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(325, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 33);
            label2.TabIndex = 4;
            label2.Text = "Informe o horario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(325, 296);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 33);
            label3.TabIndex = 5;
            label3.Text = "Informe o serviço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(325, 372);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 33);
            label4.TabIndex = 6;
            label4.Text = "Informe o nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(325, 446);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 33);
            label5.TabIndex = 7;
            label5.Text = "Informe o contato";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.CalendarMonthBackground = SystemColors.Menu;
            dateTimePickerData.Font = new Font("Old English Text MT", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerData.Location = new Point(325, 176);
            dateTimePickerData.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(364, 34);
            dateTimePickerData.TabIndex = 8;
            dateTimePickerData.ValueChanged += dateTimePickerData_ValueChanged;
            // 
            // comboBoxServico
            // 
            comboBoxServico.BackColor = Color.SlateGray;
            comboBoxServico.Font = new Font("Old English Text MT", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxServico.ForeColor = SystemColors.InactiveBorder;
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Location = new Point(325, 334);
            comboBoxServico.Margin = new Padding(4, 5, 4, 5);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(260, 35);
            comboBoxServico.TabIndex = 9;
            comboBoxServico.SelectedIndexChanged += comboBoxServico_SelectedIndexChanged_1;
            // 
            // button2
            // 
            button2.Font = new Font("Old English Text MT", 22F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(38, 577);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(209, 73);
            button2.TabIndex = 11;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // comboBoxHora
            // 
            comboBoxHora.BackColor = Color.SlateGray;
            comboBoxHora.Font = new Font("Old English Text MT", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxHora.ForeColor = SystemColors.InactiveBorder;
            comboBoxHora.FormattingEnabled = true;
            comboBoxHora.Location = new Point(325, 253);
            comboBoxHora.Margin = new Padding(4, 5, 4, 5);
            comboBoxHora.Name = "comboBoxHora";
            comboBoxHora.Size = new Size(260, 35);
            comboBoxHora.TabIndex = 13;
            comboBoxHora.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewAgenda
            // 
            dataGridViewAgenda.BackgroundColor = Color.SlateGray;
            dataGridViewAgenda.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgenda.Columns.AddRange(new DataGridViewColumn[] { Data, Hora, Serviço, Nome, Contato });
            dataGridViewAgenda.Location = new Point(697, 170);
            dataGridViewAgenda.Margin = new Padding(4, 5, 4, 5);
            dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewAgenda.RowHeadersWidth = 62;
            dataGridViewAgenda.RowTemplate.Height = 25;
            dataGridViewAgenda.Size = new Size(758, 566);
            dataGridViewAgenda.TabIndex = 14;
            dataGridViewAgenda.CellContentClick += dataGridViewAgenda_CellContentClick;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.Width = 150;
            // 
            // Hora
            // 
            Hora.HeaderText = "Horário";
            Hora.MinimumWidth = 8;
            Hora.Name = "Hora";
            Hora.Width = 150;
            // 
            // Serviço
            // 
            Serviço.HeaderText = "Serviço";
            Serviço.MinimumWidth = 8;
            Serviço.Name = "Serviço";
            Serviço.Width = 150;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.Width = 150;
            // 
            // Contato
            // 
            Contato.HeaderText = "Contato";
            Contato.MinimumWidth = 8;
            Contato.Name = "Contato";
            Contato.Width = 150;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(273, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1238, 770);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-414, -301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(707, 1063);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Old English Text MT", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(325, 44);
            label6.Name = "label6";
            label6.Size = new Size(500, 66);
            label6.TabIndex = 17;
            label6.Text = "Data do Atendimento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 750);
            Controls.Add(label6);
            Controls.Add(dataGridViewAgenda);
            Controls.Add(comboBoxHora);
            Controls.Add(button2);
            Controls.Add(comboBoxServico);
            Controls.Add(dateTimePickerData);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxContato);
            Controls.Add(textBoxNome);
            Controls.Add(buttonConfirmar);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirmar;
        private TextBox textBoxNome;
        private TextBox textBoxContato;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerData;
        private ComboBox comboBoxServico;
        private Button button2;
        private ComboBox comboBoxHora;
        private DataGridView dataGridViewAgenda;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Contato;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
    }
}