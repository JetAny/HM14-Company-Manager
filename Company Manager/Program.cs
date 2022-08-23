
//ДЗ 14
//1.Visual studio - Console Application
//2.Company Manager - создайте приложение, для менеджер компании:
//2a.Создайте иерархию классов: абстрактный класс Employee и подклассы 
//    HourlyEmployee, SalariedEmployee, Manager и Executive
//2б. Заработная плата каждого рассчитывается по-разному (проведите небольшое исследование на эту тему 🙂 )
//После создания иерархии, создайте класс Company, который позволит вам управлять сотрудниками.
//3. Программа должна уметь нанимать, увольнять и повышать в должности сотрудников.
//4. Создать визуальную диаграмму описания структуры классов и их зависимостей (любой редактор)

using Company_Manager;

//Person person1 = new Person("Василий", "Пупкин");
//Person person2 = new Person("Михаил", "Светлов");
var employee1 = new HourlyEmployee ("Василий", "Пупкин", 15, "Маляр",300);
var employee2 = new HourlyEmployee("Николай", "Лукин", 8, "Разнорабочий", 320);
var employee3 = new HourlyEmployee("Василий", "Крутоиков", 15, "Штукатур", 240);
var employee4 = new HourlyEmployee("Анатолий", "Зуев", 4, "Штукатур", 240);
var employee5 = new HourlyEmployee("Сулейман", "Гаджиев", 25, "Штукатур", 240);
var employee6 = new SalariedEmployee ("Анатолий", "Рудник", 4, "Маляр");
var employee7 = new SalariedEmployee("Сулейман", "Гаджиев", 25, "Штукатур");
var manager1 = new Manager("Михаил", "Светлов", 10, "Начальник производства");
var manager2 = new Manager("Александр", "Цветков", 10, "Начальник отдела");
var executive1 = new Executive("Александр", "Пузиков", 10, "Директор");

var company = new Company("IBN");


// работников в компанию, они будут  в подчинении у менеджеру
company.AddEmployee(employee1);
company.AddEmployee(employee2);
company.AddEmployee(employee3);
company.AddEmployee(employee4);
company.AddEmployee(employee5);

// прием на работу менеджеров
company.AddManager(manager1);
company.AddManager(manager2);
company.AddExecutive (executive1);



// вывод данных менеджеров 
Console.WriteLine (manager1);
Console.WriteLine(new string('-',60));
Console.WriteLine(manager2);
Console.WriteLine(new string('-', 60));

// вывод данных директора
Console.WriteLine (executive1);
Console.WriteLine(new string('-', 60));

//вывод данных одного из работников
Console.WriteLine(employee5);
Console.WriteLine(new string('-', 60));

// вывод данных состава компании
Console.WriteLine(company);
Console.WriteLine(new string('-', 60));

//// увольнение одного работника

company.RemoveEmployee(employee1);
Console.WriteLine(company);
Console.WriteLine(new string('-', 60));

company.RemoveEmployee(manager2);
Console.WriteLine(company);
Console.WriteLine(new string('-', 60));

company.RemoveEmployee(executive1);

Console.WriteLine(manager1);
Console.WriteLine(new string('-', 60));
// добавление работника в подчинение менеджера

company.AddEmployee(employee2, manager1);
company.AddEmployee(employee1, manager1);
Console.WriteLine(manager1);
Console.WriteLine(new string('-', 60));
company.AddExecutive(executive1);

//повышение в должности

company.Promotion(employee3, "Начальник отдела продаж");
Manager manager3 = company.companyManagers.Find(x => x._lastName.Equals(employee3._lastName));


company.AddEmployee (employee6, manager3);
company.AddEmployee(employee7, manager3);
Console.WriteLine(new string('-', 60));

// вывод данных состава компании
Console.WriteLine(company);
Console.WriteLine(new string('-', 60));

company.Print(company);

//Predicate<Manager> Predicate = (manager1, manager2) => { manager1.firstName==manager2.firstName}
//String name = "Василий";
//Manager vasya = company.companyManagers.Find(x => x._firstName.Equals(name));
//parts.Find(x => x.PartName.Contains("seat")));