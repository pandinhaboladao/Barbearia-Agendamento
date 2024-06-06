namespace AgendamentoServicos
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            dataGridViewAgenda = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Horário = new DataGridViewTextBoxColumn();
            Serviço = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.InactiveCaption;
            monthCalendar1.ForeColor = SystemColors.InfoText;
            monthCalendar1.Location = new Point(378, 89);
            monthCalendar1.Margin = new Padding(13, 15, 13, 15);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Old English Text MT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(951, 648);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(169, 84);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewAgenda
            // 
            dataGridViewAgenda.BackgroundColor = SystemColors.InfoText;
            dataGridViewAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgenda.Columns.AddRange(new DataGridViewColumn[] { Data, Horário, Serviço, Nome, Contato });
            dataGridViewAgenda.Location = new Point(13, 395);
            dataGridViewAgenda.Margin = new Padding(4, 5, 4, 5);
            dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewAgenda.RowHeadersWidth = 62;
            dataGridViewAgenda.RowTemplate.Height = 25;
            dataGridViewAgenda.Size = new Size(793, 360);
            dataGridViewAgenda.TabIndex = 3;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.Width = 150;
            // 
            // Horário
            // 
            Horário.HeaderText = "Horário";
            Horário.MinimumWidth = 8;
            Horário.Name = "Horário";
            Horário.Width = 150;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(831, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 777);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Old English Text MT", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(857, 69);
            label1.Name = "label1";
            label1.Size = new Size(339, 114);
            label1.TabIndex = 5;
            label1.Text = "Agenda";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-414, -340);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(691, 727);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1255, 769);
            Controls.Add(label1);
            Controls.Add(dataGridViewAgenda);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Agenda";
            Text = "Agenda";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private DataGridView dataGridViewAgenda;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Horário;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Contato;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}