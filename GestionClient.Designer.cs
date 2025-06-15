namespace DevoirCrud
{
    partial class GestionClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bouton_ajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.bouton_modifier = new System.Windows.Forms.Button();
            this.bouton_supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(198, 63);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(242, 22);
            this.textBox_nom.TabIndex = 4;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(198, 105);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(242, 22);
            this.textBox_prenom.TabIndex = 5;
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(198, 203);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(242, 22);
            this.textBox_adresse.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // bouton_ajouter
            // 
            this.bouton_ajouter.Location = new System.Drawing.Point(58, 277);
            this.bouton_ajouter.Name = "bouton_ajouter";
            this.bouton_ajouter.Size = new System.Drawing.Size(87, 23);
            this.bouton_ajouter.TabIndex = 8;
            this.bouton_ajouter.Text = "AJOUTER";
            this.bouton_ajouter.UseVisualStyleBackColor = true;
            this.bouton_ajouter.Click += new System.EventHandler(this.bouton_ajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 205);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "id_client";
            // 
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(590, 62);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(121, 24);
            this.comboBox_id.TabIndex = 11;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // bouton_modifier
            // 
            this.bouton_modifier.Location = new System.Drawing.Point(187, 277);
            this.bouton_modifier.Name = "bouton_modifier";
            this.bouton_modifier.Size = new System.Drawing.Size(111, 23);
            this.bouton_modifier.TabIndex = 12;
            this.bouton_modifier.Text = "MODIFIER";
            this.bouton_modifier.UseVisualStyleBackColor = true;
            this.bouton_modifier.Click += new System.EventHandler(this.bouton_modifier_Click_1);
            // 
            // bouton_supprimer
            // 
            this.bouton_supprimer.Location = new System.Drawing.Point(332, 277);
            this.bouton_supprimer.Name = "bouton_supprimer";
            this.bouton_supprimer.Size = new System.Drawing.Size(108, 23);
            this.bouton_supprimer.TabIndex = 13;
            this.bouton_supprimer.Text = "SUPPRIMER";
            this.bouton_supprimer.UseVisualStyleBackColor = true;
            this.bouton_supprimer.Click += new System.EventHandler(this.bouton_supprimer_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 431);
            this.Controls.Add(this.bouton_supprimer);
            this.Controls.Add(this.bouton_modifier);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bouton_ajouter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionClient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bouton_ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Button bouton_modifier;
        private System.Windows.Forms.Button bouton_supprimer;
    }
}

