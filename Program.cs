using System;
using ClassLibrary.Lab3;
using ClassLibrary.Lab3.ClassLibrary.Lab3;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkHardware[] net;

            Router router1 = new Router();
            Router router2 = new Router();

            NetworkSwitch networkSwitch1 = new NetworkSwitch();
            NetworkSwitch networkSwitch2 = new NetworkSwitch();

            net = new NetworkHardware[4] { (NetworkHardware)router1, (NetworkHardware)router2, (NetworkHardware)networkSwitch1, (NetworkHardware)networkSwitch2 };

            Console.WriteLine("Display instance with default fields\n");
            Console.WriteLine(router1.DisplayFullInformation());
            Console.WriteLine(" ");
            Console.WriteLine(networkSwitch1.DisplayFullInformation());

            for (int i = 0; i < 2; i++)
            {

                Console.Write("setNameHardware: ");
                net[i].setNameHardware(Console.ReadLine());
                Console.Write("setModel: ");
                net[i].setModel(Console.ReadLine());
                Console.Write("setSize: ");
                net[i].setSize(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumOfPorts: ");
                net[i].setNumOfPorts(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setPower: ");
                net[i].setPower(Convert.ToInt32(Console.ReadLine()));


                Router router = (Router)net[i];

                Console.Write("setNumberOfChannels: ");
                router.setNumberOfChannels(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setMaximumDataRate: ");
                router.setMaximumDataRate(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumberOfLanPorts: ");
                router.setNumberOfLanPorts(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumbersOfAntennas: ");
                router.setNumbersOfAntennas(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumOfFrequency: ");
                router.setNumOfFrequency(Convert.ToInt32(Console.ReadLine()));

                net[i] = router;

                Console.WriteLine(net[i].DisplayFullInformation());
            }

            for (int i = 2; i < 4; i++)
            {

                Console.Write("setNameHardware: ");
                net[i].setNameHardware(Console.ReadLine());
                Console.Write("setModel: ");
                net[i].setModel(Console.ReadLine());
                Console.Write("setSize: ");
                net[i].setSize(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumOfPorts: ");
                net[i].setNumOfPorts(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setPower: ");
                net[i].setPower(Convert.ToInt32(Console.ReadLine()));


                NetworkSwitch router = (NetworkSwitch)net[i];

                Console.Write("setNumInOfPorts: ");
                router.setNumInOfPorts(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setNumOutOfPorts: ");
                router.setNumOutOfPorts(Convert.ToInt32(Console.ReadLine()));
                Console.Write("isAutonomy(1/0): ");
                int autonomy = Convert.ToInt32(Console.ReadLine());
                bool setAutomy;
                setAutomy = autonomy == 1 ? true : false;
                router.setAutonomy(setAutomy);
                Console.Write("setWeight: ");
                router.setWeight(Convert.ToInt32(Console.ReadLine()));
                Console.Write("setTypeDuplex: ");
                router.setTypeDuplex(Console.ReadLine());

                net[i] = router;

                Console.WriteLine(net[i].DisplayFullInformation());
            }
        }
    }
}
