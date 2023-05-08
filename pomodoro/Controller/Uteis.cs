using pomodoro.Model;
using System.Text.Json;

namespace pomodoro.Controller
{
    public class Uteis
    {

        public static int iTempoTrabalho = 30;
        public static int iTempoPausa = 5;

        public static bool bMaximizarModoFoco = false;
        public static bool bMaximizarModoDescanso = false;

        public static bool bNotificarModoFoco = true;
        public static bool bNotificarModoDescanso = true;

        public static string PastaPadrao = @"c:\Area27\Pomodoro\";
        public static string ArquivoConfig = @"Pomodoro.dll";

        public static void Inicializa()
        {
            if (!Directory.Exists(PastaPadrao))
                Directory.CreateDirectory(PastaPadrao);
            LerConfig();
        }

        public static void LerConfig()
        {
            string Arquivo = PastaPadrao + ArquivoConfig;
            if (File.Exists(Arquivo))
            {
                string sTexto = File.ReadAllText(Arquivo);

                var vjson = JsonSerializer.Deserialize<ConfiguracoesViewModel>(sTexto);
                iTempoTrabalho = vjson == null ? 30 : vjson.iTempoTrabalho;
                iTempoPausa = vjson == null ? 5 : vjson.iTempoPausa;
                bMaximizarModoFoco = vjson == null ? false : vjson.bMaximizarModoFoco;
                bMaximizarModoDescanso = vjson == null ? false : vjson.bMaximizarModoDescanso;
                bNotificarModoFoco = vjson == null ? true : vjson.bNotificarModoFoco;
                bNotificarModoDescanso = vjson == null ? true : vjson.bMaximizarModoDescanso;
            }
            else
                SalvaConfig();
        }

        public static bool SalvaConfig(ConfiguracoesViewModel conf = null)
        {
            string Arquivo = PastaPadrao + ArquivoConfig;
            try
            {
                var Dados = JsonSerializer.Serialize(conf, new JsonSerializerOptions { WriteIndented = true });
                if (Dados.ToLower() != "null")
                {
                    File.WriteAllText(Arquivo, Dados);
                }
                else
                {
                    var confTemp = new ConfiguracoesViewModel();
                    confTemp.iTempoTrabalho = iTempoTrabalho;
                    confTemp.iTempoPausa = iTempoPausa;
                    confTemp.bMaximizarModoFoco = bMaximizarModoFoco;
                    confTemp.bMaximizarModoDescanso = bMaximizarModoDescanso;
                    confTemp.bNotificarModoFoco = bNotificarModoFoco;
                    confTemp.bNotificarModoDescanso = bNotificarModoDescanso;

                    File.WriteAllText(Arquivo, JsonSerializer.Serialize(confTemp, new JsonSerializerOptions { WriteIndented = true }));

                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
