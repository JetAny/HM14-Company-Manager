
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
var employee2 = new Manager("Михаил", "Светлов", 10, "Начальник производства");
var worker1=new Company(employee1);
var worker2 = new Company(employee2);

worker2.AddManager(employee2);
worker1.AddManager(employee2);
employee2.AddEmployee(employee1);


Console.WriteLine (worker1);
Console.WriteLine (worker2);

