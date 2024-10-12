namespace AgenciaAutomotriz
{
    partial class Administrador
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdminHerramientas = new System.Windows.Forms.Button();
            this.btnAdminProd = new System.Windows.Forms.Button();
            this.btnAdminUsers = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkKhaki;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "---- MENÚ PRINCIPAL ----";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "INSTRUCCIONES:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione las opciones siguientes, según lo que desee realizar.";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(50, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 520);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Location = new System.Drawing.Point(1100, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 520);
            this.label5.TabIndex = 11;
            // 
            // btnAdminHerramientas
            // 
            this.btnAdminHerramientas.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdminHerramientas.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminHerramientas.Image = global::AgenciaAutomotriz.Properties.Resources.technical_support_128;
            this.btnAdminHerramientas.Location = new System.Drawing.Point(800, 382);
            this.btnAdminHerramientas.Name = "btnAdminHerramientas";
            this.btnAdminHerramientas.Size = new System.Drawing.Size(225, 185);
            this.btnAdminHerramientas.TabIndex = 9;
            this.btnAdminHerramientas.Text = "Administrar Herramientas";
            this.btnAdminHerramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminHerramientas.UseVisualStyleBackColor = false;
            this.btnAdminHerramientas.Click += new System.EventHandler(this.btnAdminHerramientas_Click);
            // 
            // btnAdminProd
            // 
            this.btnAdminProd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdminProd.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.btnAdminProd.Image = global::AgenciaAutomotriz.Properties.Resources.online_128;
            this.btnAdminProd.Location = new System.Drawing.Point(500, 382);
            this.btnAdminProd.Name = "btnAdminProd";
            this.btnAdminProd.Size = new System.Drawing.Size(225, 185);
            this.btnAdminProd.TabIndex = 8;
            this.btnAdminProd.Text = "Administrar Productos";
            this.btnAdminProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminProd.UseVisualStyleBackColor = false;
            this.btnAdminProd.Click += new System.EventHandler(this.btnAdminProd_Click);
            // 
            // btnAdminUsers
            // 
            this.btnAdminUsers.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdminUsers.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.btnAdminUsers.Image = global::AgenciaAutomotriz.Properties.Resources.account_128;
            this.btnAdminUsers.Location = new System.Drawing.Point(200, 382);
            this.btnAdminUsers.Name = "btnAdminUsers";
            this.btnAdminUsers.Size = new System.Drawing.Size(225, 185);
            this.btnAdminUsers.TabIndex = 7;
            this.btnAdminUsers.Text = "Administrar Usuarios";
            this.btnAdminUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminUsers.UseVisualStyleBackColor = false;
            this.btnAdminUsers.Click += new System.EventHandler(this.btnAdminUsers_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnX.BackgroundImage = global::AgenciaAutomotriz.Properties.Resources.close_white;
            this.btnX.Location = new System.Drawing.Point(1122, 7);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(64, 64);
            this.btnX.TabIndex = 4;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnHerramientas.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Image = global::AgenciaAutomotriz.Properties.Resources.search_tools_128;
            this.btnHerramientas.Location = new System.Drawing.Point(800, 179);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(225, 185);
            this.btnHerramientas.TabIndex = 3;
            this.btnHerramientas.Text = "Buscar Herramientas";
            this.btnHerramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHerramientas.UseVisualStyleBackColor = false;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnProductos.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.btnProductos.Image = global::AgenciaAutomotriz.Properties.Resources.browsing_128;
            this.btnProductos.Location = new System.Drawing.Point(500, 179);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(225, 185);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Buscar Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnUsers.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.btnUsers.Image = global::AgenciaAutomotriz.Properties.Resources.followers_128;
            this.btnUsers.Location = new System.Drawing.Point(200, 179);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(225, 185);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Buscar Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Administrador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdminHerramientas);
            this.Controls.Add(this.btnAdminProd);
            this.Controls.Add(this.btnAdminUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(13)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdminHerramientas;
        private System.Windows.Forms.Button btnAdminProd;
        private System.Windows.Forms.Button btnAdminUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}