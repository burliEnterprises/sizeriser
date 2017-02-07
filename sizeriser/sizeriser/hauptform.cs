using sizeriser.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sizeriser
{
    public partial class hauptform : Form
    {

        public hauptform()
        {
            InitializeComponent();
            anzahl_steps = TRB_Height.Maximum;

        }



        Bitmap BMP_aus_Pfad;
        string pfad, dateiendung;           //des alten Bildes
        string pfad_neu;                    //wenn als kopie speichern

        int breite_alt, hoehe_alt;          //Breite und Höhe des Originalbildes
        int breite_neu, hoehe_neu;

        int kleinste_bildgroesse = 8;       //kleiner wird nicht skaliert wie 8px
        int anzahl_steps;      //Anzahl Striche in der TRB

        int px_pro_step_breite;
        int px_pro_strp_hoehe;      //Änderung in Pixel pro Strich in der Höhe und Breite

        float prozent_verhaeltnis;        //Verhältnis von Breite zu Hoehe (!)


        


        /// <summary>
        /// Wählen des Bildes, zahlreiche Variablen-Größen zuweisungen, Vorschau in der PictureBox
        /// </summary>



        private void btnPfad_Click(object sender, EventArgs e)          //Get File
        {

            LB_Bildinfo.Items.Clear();      //immer wenn neues Bild ausgewählt

            OpenFileDialog OFD_waehlePfad = new OpenFileDialog();
            OFD_waehlePfad.Filter = "All files (*.*)|*.*|png files (*.png*)|*.png*|jpg files (*.jpg*)|*.jpg*|gif files (*.gif)|*.gif |bmp files(*.bmp *) | *.bmp *|ico files (*.ico*)|*.ico*";
            OFD_waehlePfad.ShowDialog();

            try
            {
                pfad = OFD_waehlePfad.FileName;             //Nimmt Pfad des Bildes
                
                dateiendung = Path.GetExtension(pfad);      //Nimmt Dateiendung des Bildes
                pfad_neu = pfad.Substring(0, pfad.Length - 4) + "_kopie" + dateiendung;
                tbPath.Visible = true;                  //TextBox wird sichtbar
                tbPath.Text = pfad;

                BMP_aus_Pfad = new Bitmap(pfad);

                breite_alt = BMP_aus_Pfad.Width;        //Skalierung des alten Bildes
                hoehe_alt = BMP_aus_Pfad.Height;

                breite_neu = breite_alt;                //Falls Größe nie geändert
                hoehe_neu = hoehe_alt;
                prozent_verhaeltnis = (float) breite_alt / (float) hoehe_alt;       //Verhältnis, für manuelle Eingaben später


                px_pro_step_breite = (breite_alt - kleinste_bildgroesse) / anzahl_steps;        // Anzahl Pixel, um die das neue Bild pro Strich (Step) kleiner wird
                px_pro_strp_hoehe = (hoehe_alt - kleinste_bildgroesse) / anzahl_steps;

                TB_Height.Text = hoehe_alt.ToString();
                TB_Width.Text = breite_alt.ToString();

               


                zeige_bitmap_in_PB(dateiendung);        //Für die Vorschau des Bildes
            }
            catch (FileNotFoundException) { }
            catch (ArgumentOutOfRangeException) { }
            catch (ArgumentException) { MessageBox.Show("Choose a image!"); }
        }









        /// <summary>
        /// Die tatsächliche Änderung des Bildes, Umwandlung zum neuen Bild:
        /// </summary>


        private void btnSetImage_Click(object sender, EventArgs e)          //Change die Größe des Bildes, mit den veränderten Größen
        {
            try
            {

                Bitmap BMP_neu = new Bitmap(breite_neu, hoehe_neu);

                Graphics GFX_neu = Graphics.FromImage(BMP_neu);

                Rectangle RECT_Komprimierung = new Rectangle(0, 0, breite_neu, hoehe_neu);
                GFX_neu.DrawImage(BMP_aus_Pfad, RECT_Komprimierung);



                if (TRB_Datei.Value == 0)            //original bild überschreiben 
                {
                    BMP_neu.Save(pfad);
                    label_SuccessAlert.Text = "Image successfully changed!";
                }



                else if (TRB_Datei.Value == 1)          // "_kopie" abfügen an den Namen
                {
                    BMP_neu.Save(pfad_neu);
                    label_SuccessAlert.Text = "Image successfully created!";
                }

                label_SuccessAlert.Visible = true;
            }
            catch (ArgumentException) { MessageBox.Show("Choose a image first!"); }
        }



        




        /****************************** Zeige die Vorschau in der Picture Box ************************************* */




        public void zeige_bitmap_in_PB(string dateiendung)          //Vorschau in der PB, die Dateiendung wird übergeben um in den Infos anzeigen zu lassen
        {
            Graphics GFX = Graphics.FromImage(BMP_aus_Pfad);
            GFX.DrawImage(BMP_aus_Pfad, 0, 0);
            PB_Vorschau.Image = BMP_aus_Pfad;       //Bitmap wird in PB geschrieben

            LB_Bildinfo.Items.Add("Format: " + dateiendung);        //Information über das Bild in die LB
            LB_Bildinfo.Items.Add("Height: " + BMP_aus_Pfad.Height + " px");
            LB_Bildinfo.Items.Add("Width: " + BMP_aus_Pfad.Width + " px");
            LB_Bildinfo.Items.Add("Resolution: " + Math.Round(BMP_aus_Pfad.HorizontalResolution * 100) / 100 + " dpi");
        }


     







        //***********************Werte wenn eine der TRBs geändert werden***************************************





        private void breite_value_changed(object sender, EventArgs e)       //Wenn TRB_Width geändert
        {
            breite_neu = breite_alt - px_pro_step_breite * (TRB_Width.Value);       //Formel siehe Doku
            hoehe_neu = hoehe_alt - px_pro_strp_hoehe * (TRB_Width.Value);

            switch (TRB_Seitenverhaeltnis.Value)
            {
                case 0:             //Same Seitenverhältnis


                    TB_Height.Text = hoehe_neu.ToString();
                    TB_Width.Text = breite_neu.ToString();

                    TRB_Height.Value = TRB_Width.Value;         //Setzt den Strich auf den gleichen Wett
                    break;

                case 1:             //Kein Seitenverhältnis
                    TB_Width.Text = breite_neu.ToString();
                    break;
            }
        }

        

        private void hoehe_value_changed(object sender, EventArgs e)                //Wenn TRB_Height geändert
        {
            breite_neu = breite_alt - px_pro_step_breite * (TRB_Height.Value);      //Formel siehe Doku
            hoehe_neu = hoehe_alt - px_pro_strp_hoehe * (TRB_Height.Value);

            switch (TRB_Seitenverhaeltnis.Value)
            {
                case 0:             //Same Seitenverhältnis


                    TB_Height.Text = hoehe_neu.ToString();
                    TB_Width.Text = breite_neu.ToString();
                    TRB_Width.Value = TRB_Height.Value;         //Setzt den Strich auf den gleichen Wett
                    break;

                case 1:             //Kein Seitenverhältnis
                    TB_Height.Text = breite_neu.ToString();
                    break;
            }
        }

       



        //Wenn der User selbst eingibt

        private void height_change_manuell(object sender, KeyEventArgs e)
        {
            try
            {
                TB_Width.Text = (Math.Round(float.Parse(TB_Height.Text) * prozent_verhaeltnis)).ToString();
                //die manuelle User Eingabe, keine Buchstaben, ohne Kommastellen, wird in die TB_Breite mit den richtigen Verhältnis geschrieben
                hoehe_neu = int.Parse(TB_Height.Text);
                breite_neu = (int)(float.Parse(TB_Height.Text) * prozent_verhaeltnis);
            }
            catch (FormatException) { }

        }
            
         private void breite_changed_manuell(object sender, KeyEventArgs e)
        {
            try
            {

            TB_Height.Text = (Math.Round(float.Parse(TB_Width.Text) / prozent_verhaeltnis)).ToString();
            //die manuelle User Eingabe, keine Buchstaben, ohne Kommastellen, wird in die TB_Breite mit den richtigen Verhältnis geschrieben
            breite_neu = int.Parse(TB_Width.Text);
            hoehe_neu = (int)(float.Parse(TB_Width.Text) / prozent_verhaeltnis);
        }
            catch (FormatException) { }
        }

        //*********************** Aufrufen der anderen Forms ***************************************



        private void TSMI_Impressum_Click(object sender, EventArgs e)
        {
            impressum.impressum obj_about = new impressum.impressum();      //Anderer Namespace (Ordner)
            obj_about.Show();
        }


        private void TSMI_Help_Click(object sender, EventArgs e)
        {
            help.help obj_help = new help.help();        //Anderer Namespace (Ordner)
            obj_help.Show();
        }
    }
}
