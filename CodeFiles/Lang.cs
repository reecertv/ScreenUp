namespace ScreenUp
{
    public static class Lang
    {
        public static string o = ":";

        // Form: Settings
        public static string LabTitle_Settings() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Settings";
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Einstellungen";
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Configuraciones";
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Paramètres";
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "パラメーター";
            }
            else
            {
                return "Error";
            }
        }
        public static string LabSelectScreen() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Screen" + o;
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Bildschirm" + o;
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Pantalla" + o;
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Ecran" + o;
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "画面" + o;
            }
            else
            {
                return "Error";
            }
        }
        public static string BtnSelectScreen() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Select Screen";
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Bildschirm auswählen";
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Selecciona la pantalla";
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Choisir un écran";
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "画面選択";
            }
            else
            {
                return "Error";
            }
        }
        public static string LabReSetup() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Re-Setup" + o;
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Re-Setup" + o;
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Re-Setup" + o;
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Re-Setup" + o;
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "リセット" + o;
            }
            else
            {
                return "Error";
            }
        }
        public static string BtnReSetup() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Set up";
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Einrichten";
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Configura";
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Configurer";
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "に設定";
            }
            else
            {
                return "Error";
            } 
        }
        public static string LabSelectColour() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Colour" + o;
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Farbe" + o;
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Color" + o;
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Couleur" + o;
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "カラー" + o;
            }
            else
            {
                return "Error";
            }
        }
        public static string BtnSelectColour() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Select Colour";
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Farbe auswählen";
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Seleccione el color";
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Choisir la couleur";
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "カラーを選択";
            }
            else
            {
                return "Error";
            } 
        }
        public static string LabLang() 
        {
            if (Properties.Settings.Default.Lang == "en")
            {
                return "Language" + o;
            }
            else if (Properties.Settings.Default.Lang == "de")
            {
                return "Sprache" + o;
            }
            else if (Properties.Settings.Default.Lang == "es")
            {
                return "Idiomas" + o;
            }
            else if (Properties.Settings.Default.Lang == "fr")
            {
                return "Langue" + o;
            }
            else if (Properties.Settings.Default.Lang == "ja")
            {
                return "言語" + o;
            }
            else
            {
                return "Error";
            }
        }
    }
}