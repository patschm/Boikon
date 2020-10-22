using System;

namespace NPO
{
    class Program
    {
        static void Main(string[] args)
        {
            RadioStation r538 = new RadioStation();

            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaKabel;
            r538.Subscribers += ViaTamTam;
            r538.Subscribers += ViaRookSignalen;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaKabel;
            r538.Subscribers += ViaTamTam;
            r538.Subscribers += ViaRookSignalen;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaKabel;
            r538.Subscribers += ViaTamTam;
            r538.Subscribers += ViaRookSignalen;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaKabel;
            r538.Subscribers += ViaTamTam;
            r538.Subscribers += ViaRookSignalen;
            r538.Subscribers += ViaEther;
            r538.Subscribers += ViaKabel;
            r538.Subscribers += ViaTamTam;
            r538.Subscribers += ViaRookSignalen;

            //r538.Subscribers("Klojoooos");
            r538.Broadcast();
        }

        //delegate void BroadcastMethod(string msg);
        static void ViaKabel(string message)
        {
            Console.WriteLine($"Via kabel ontvangen: {message}");
        }
        static void ViaEther(string message)
        {
            Console.WriteLine($"Via Ether ontvangen: {message}");
        }
        static void ViaTamTam(string message)
        {
            Console.WriteLine($"Via tamtam ontvangen: {message}");
        }
        static void ViaRookSignalen(string message)
        {
            Console.WriteLine($"Via rooksignalen ontvangen: {message}");
        }
    }
}
