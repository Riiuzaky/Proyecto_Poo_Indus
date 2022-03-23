namespace AeropuertoSofi
{
    partial class Form3
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
            this.Btnvender = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btnvender
            // 
            this.Btnvender.BackColor = System.Drawing.Color.Black;
            this.Btnvender.ForeColor = System.Drawing.Color.White;
            this.Btnvender.Image = global::AeropuertoSofi.Properties.Resources.Photography_HDR___images_HDR___Zartiex;
            this.Btnvender.Location = new System.Drawing.Point(941, 309);
            this.Btnvender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btnvender.Name = "Btnvender";
            this.Btnvender.Size = new System.Drawing.Size(245, 67);
            this.Btnvender.TabIndex = 73;
            this.Btnvender.Text = "Continuar";
            this.Btnvender.UseVisualStyleBackColor = false;
            this.Btnvender.Click += new System.EventHandler(this.Btnvender_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Italiano",
            "Frances",
            "Asiatico",
            "Sin Menu"});
            this.comboBox2.Location = new System.Drawing.Point(354, 488);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(535, 39);
            this.comboBox2.TabIndex = 72;
            this.comboBox2.Text = "Selecione Menu";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DIAMOND",
            "GOLD",
            "SILVER",
            "CLASIC"});
            this.comboBox1.Location = new System.Drawing.Point(354, 291);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(535, 39);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.Text = "Seleccione Clase";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // cmbdestino
            // 
            this.cmbdestino.BackColor = System.Drawing.Color.White;
            this.cmbdestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Items.AddRange(new object[] {
            "Bogota-Rio",
            "Bogota-Miami",
            "Bogota-Cartagena",
            "Bogota-Panama"});
            this.cmbdestino.Location = new System.Drawing.Point(354, 194);
            this.cmbdestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(535, 39);
            this.cmbdestino.TabIndex = 69;
            this.cmbdestino.Text = "Seleciona Vuelo";
            this.cmbdestino.SelectedIndexChanged += new System.EventHandler(this.cmbdestino_SelectedIndexChanged);
            this.cmbdestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbdestino_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::AeropuertoSofi.Properties.Resources._5b177c3b22c8e;
            this.label5.Location = new System.Drawing.Point(200, 488);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 39);
            this.label5.TabIndex = 68;
            this.label5.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::AeropuertoSofi.Properties.Resources._5b177c3b22c8e;
            this.label4.Location = new System.Drawing.Point(198, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 39);
            this.label4.TabIndex = 67;
            this.label4.Text = "Clase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::AeropuertoSofi.Properties.Resources._5b177c3b22c8e;
            this.label3.Location = new System.Drawing.Point(190, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 39);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::AeropuertoSofi.Properties.Resources._5b177c3b22c8e;
            this.label1.Location = new System.Drawing.Point(171, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 65;
            this.label1.Text = "Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = global::AeropuertoSofi.Properties.Resources.Photography_HDR___images_HDR___Zartiex;
            this.label2.Location = new System.Drawing.Point(490, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 64;
            this.label2.Text = "Registro Vuelo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(354, 400);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 23);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AeropuertoSofi.Properties.Resources.sdfsdf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1779, 740);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Btnvender);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Formnn";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Btnvender;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox cmbdestino;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}