using System;
namespace Maliza
{
    class Program
    {
        interface IKitab
        {
            string Autor { get; set; }
            string Type { get; set; }
            int Coust { get; set; }
            bool OnlineOrder { get; set; }
            int DeliveryCoust { get; set; }
            bool OxunmaSeviyyesi(int x);
        }
        class Kitab : IKitab
        {
            string IKitab.Autor { get ; set ; }
            string IKitab.Type { get ; set ; }
            int IKitab.Coust { get; set ; }
            bool IKitab.OnlineOrder { get ; set ; }
            int IKitab.DeliveryCoust { get; set ; }

            bool IKitab.OxunmaSeviyyesi(int x)
            {
                if(x>100)
                    return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            IKitab n = new Kitab();
            n.Autor = "Stefan Zweig";
            n.Type = "Hekaye";
            n.Coust = 4;
            n.DeliveryCoust = 2;
            n.OnlineOrder = true;
        }
    }
}
