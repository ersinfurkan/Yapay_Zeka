using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID;
            String SEHIR;
            float DOZ;
            float TOPLAM;
            

            Console.WriteLine("ID giriniz: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Şehir giriniz: ");
            SEHIR = Console.ReadLine();

            Console.WriteLine("Doz sayısı: ");
            DOZ = float.Parse(Console.ReadLine());

            Console.WriteLine("Toplam: ");
            TOPLAM = float.Parse(Console.ReadLine());

 


            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                ID = ID,
                SEHIR = SEHIR,
                DOZ = DOZ,
                TOPLAM = TOPLAM,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual NUFUS with predicted NUFUS from sample data...\n\n");


            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"SEHIR: {SEHIR}");
            Console.WriteLine($"DOZ: {DOZ}");
            Console.WriteLine($"TOPLAM: {TOPLAM}");
            


            Console.WriteLine($"\n\nPrediction NUFUS: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
