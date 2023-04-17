namespace Morpion
{
    partial class frmPlayers
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
            this.joueur1Label = new System.Windows.Forms.Label();
            this.joueur2Label = new System.Windows.Forms.Label();
            this.nomJoueur1 = new System.Windows.Forms.Label();
            this.prenomJoueur1 = new System.Windows.Forms.Label();
            this.pseudoJoueur1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nom1TextBox = new System.Windows.Forms.TextBox();
            this.prenom1TextBox = new System.Windows.Forms.TextBox();
            this.pseudo1TextBox = new System.Windows.Forms.TextBox();
            this.nom2TextBox = new System.Windows.Forms.TextBox();
            this.prenom2TextBox = new System.Windows.Forms.TextBox();
            this.pseudo2TextBox = new System.Windows.Forms.TextBox();
            this.validInfos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joueur1Label
            // 
            this.joueur1Label.AutoSize = true;
            this.joueur1Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueur1Label.Location = new System.Drawing.Point(161, 83);
            this.joueur1Label.Name = "joueur1Label";
            this.joueur1Label.Size = new System.Drawing.Size(90, 25);
            this.joueur1Label.TabIndex = 0;
            this.joueur1Label.Text = "Joueur 1";
            // 
            // joueur2Label
            // 
            this.joueur2Label.AutoSize = true;
            this.joueur2Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joueur2Label.Location = new System.Drawing.Point(550, 83);
            this.joueur2Label.Name = "joueur2Label";
            this.joueur2Label.Size = new System.Drawing.Size(90, 25);
            this.joueur2Label.TabIndex = 1;
            this.joueur2Label.Text = "Joueur 2";
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.AutoSize = true;
            this.nomJoueur1.Location = new System.Drawing.Point(111, 136);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.Size = new System.Drawing.Size(34, 15);
            this.nomJoueur1.TabIndex = 2;
            this.nomJoueur1.Text = "Nom";
            // 
            // prenomJoueur1
            // 
            this.prenomJoueur1.AutoSize = true;
            this.prenomJoueur1.Location = new System.Drawing.Point(111, 181);
            this.prenomJoueur1.Name = "prenomJoueur1";
            this.prenomJoueur1.Size = new System.Drawing.Size(49, 15);
            this.prenomJoueur1.TabIndex = 3;
            this.prenomJoueur1.Text = "Prenom";
            // 
            // pseudoJoueur1
            // 
            this.pseudoJoueur1.AutoSize = true;
            this.pseudoJoueur1.Location = new System.Drawing.Point(111, 220);
            this.pseudoJoueur1.Name = "pseudoJoueur1";
            this.pseudoJoueur1.Size = new System.Drawing.Size(46, 15);
            this.pseudoJoueur1.TabIndex = 4;
            this.pseudoJoueur1.Text = "Pseudo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom";
            // 
            // nom1TextBox
            // 
            this.nom1TextBox.Location = new System.Drawing.Point(197, 136);
            this.nom1TextBox.Name = "nom1TextBox";
            this.nom1TextBox.Size = new System.Drawing.Size(100, 23);
            this.nom1TextBox.TabIndex = 8;
            // 
            // prenom1TextBox
            // 
            this.prenom1TextBox.Location = new System.Drawing.Point(197, 181);
            this.prenom1TextBox.Name = "prenom1TextBox";
            this.prenom1TextBox.Size = new System.Drawing.Size(100, 23);
            this.prenom1TextBox.TabIndex = 9;
            // 
            // pseudo1TextBox
            // 
            this.pseudo1TextBox.Location = new System.Drawing.Point(197, 220);
            this.pseudo1TextBox.Name = "pseudo1TextBox";
            this.pseudo1TextBox.Size = new System.Drawing.Size(100, 23);
            this.pseudo1TextBox.TabIndex = 10;
            // 
            // nom2TextBox
            // 
            this.nom2TextBox.Location = new System.Drawing.Point(586, 146);
            this.nom2TextBox.Name = "nom2TextBox";
            this.nom2TextBox.Size = new System.Drawing.Size(100, 23);
            this.nom2TextBox.TabIndex = 11;
            // 
            // prenom2TextBox
            // 
            this.prenom2TextBox.Location = new System.Drawing.Point(586, 188);
            this.prenom2TextBox.Name = "prenom2TextBox";
            this.prenom2TextBox.Size = new System.Drawing.Size(100, 23);
            this.prenom2TextBox.TabIndex = 12;
            // 
            // pseudo2TextBox
            // 
            this.pseudo2TextBox.Location = new System.Drawing.Point(586, 227);
            this.pseudo2TextBox.Name = "pseudo2TextBox";
            this.pseudo2TextBox.Size = new System.Drawing.Size(100, 23);
            this.pseudo2TextBox.TabIndex = 13;
            // 
            // validInfos
            // 
            this.validInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validInfos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validInfos.Location = new System.Drawing.Point(334, 320);
            this.validInfos.Name = "validInfos";
            this.validInfos.Size = new System.Drawing.Size(157, 71);
            this.validInfos.TabIndex = 14;
            this.validInfos.Text = "Let\'s Go !";
            this.validInfos.UseVisualStyleBackColor = true;
            this.validInfos.Click += new System.EventHandler(this.validInfos_Click);
            // 
            // frmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validInfos);
            this.Controls.Add(this.pseudo2TextBox);
            this.Controls.Add(this.prenom2TextBox);
            this.Controls.Add(this.nom2TextBox);
            this.Controls.Add(this.pseudo1TextBox);
            this.Controls.Add(this.prenom1TextBox);
            this.Controls.Add(this.nom1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pseudoJoueur1);
            this.Controls.Add(this.prenomJoueur1);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.joueur2Label);
            this.Controls.Add(this.joueur1Label);
            this.Name = "frmPlayers";
            this.Text = "Morpion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label joueur1Label;
        private Label joueur2Label;
        private Label nomJoueur1;
        private Label prenomJoueur1;
        private Label pseudoJoueur1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nom1TextBox;
        private TextBox prenom1TextBox;
        private TextBox pseudo1TextBox;
        private TextBox nom2TextBox;
        private TextBox prenom2TextBox;
        private TextBox pseudo2TextBox;
        private Button validInfos;
    }
}