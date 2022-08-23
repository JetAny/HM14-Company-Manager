namespace Company_Manager
{
    internal class Service
    {
        List<Service> service = new List<Service>();
        public static void PrintList(Company company)
        {
            Console.WriteLine($"Рабочие:\n");
            foreach (Employee emp in company.companyEmployee)
            {

                Console.WriteLine($"{emp}\n");
            }
            Console.WriteLine($"Менеджеры:\n");
            foreach (Employee emp in company.companyManagers)
            {
                Console.WriteLine($"{emp}\n");
            }
            Console.WriteLine($"Управляющие: \n");
            foreach (Employee emp in company.companyExecutives)
            {
                Console.WriteLine($"{emp}\n");
            }
        }
    }
}



