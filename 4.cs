using System;

namespace lb4task4
{
    public class ApplicationLicense
    {
        protected string AllowTrial;
        protected string AllowCommon;
        protected string AllowPro;
        public ApplicationLicense(string AllowTrial, string AllowCommon, string AllowPro)
        {
            this.allowTrial = AllowTrial;
            this.allowCommon = AllowCommon;
            this.allowPro = AllowPro;
        }
        public string allowTrial
        {
            get { return allowTrial; }
            set { AllowTrial = value; }
        }
        public string allowCommon
        {
            get { return allowCommon; }
            set { AllowCommon = value; }
        }
        public string allowPro
        {
            get { return allowPro; }
            set { AllowPro = value; }
        }
        public void Print()
        {
            Console.WriteLine("The values of fields are:");
            Console.WriteLine($"AllowTrial = {AllowTrial}");
            Console.WriteLine($"AllowCommon = {AllowCommon}");
            Console.WriteLine($"AllowPro= {AllowPro}");
        }
    }
    public class License : ApplicationLicense
    {
        protected string topic;

        public License(string allowTrial, string allowCommon, string allowPro, string topic) :
        base(allowTrial, allowCommon, allowPro)
        {
            base.allowTrial = AllowTrial;
            this.allowCommon = AllowCommon;
            this.allowPro = AllowPro;
            this.topic = topic;
        }

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Topic = {topic}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLicense st1 = new ApplicationLicense("Триальный режим", "Бесплатная версия", "Платная версия");

            Console.WriteLine("The instance of st1:");
            st1.Print();
            License lic1 = new License(st1.allowTrial, st1.allowCommon, st1.allowPro, "Выберите лицензию :");
            Console.WriteLine("The instance of lic1:");
            lic1.Print();
        }
    }
}
