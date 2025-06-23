using LinqGroupJoin_Example;

//Listeleri tanımladık
var students = new List<Students>
{
    new(1, "Ali", 1),
    new(2, "Ayşe", 2),
    new(3, "Mehmet", 1),
    new(4, "Fatma", 3),
    new(5, "Ahmet", 2)
};

var classes = new List<Classes>
{
    new(1, "Matematik"),
    new(2, "Türkçe"),
    new(3, "Kimya")
};

//Linq sorgularını yazıyoruz.

//Öğrenciler ve sınıflar arasında group join işlemi yaparak, her sınıfın altında o sınıfa ait olan öğrencilerin listelendiği bir sonuç elde edin.
//Sonuçları sınıf adıyla birlikte, o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdıran bir LINQ sorgusu yazın.

var classesWithStudents = classes.GroupJoin(students, c => c.ClassId,
                                                      s => s.ClassId,
                                                      (c, studentGroup) => new
                                                      {
                                                          ClassName = c.ClassName,
                                                          Students = studentGroup
                                                      });

foreach (var group in classesWithStudents)
{
    Console.WriteLine($"Sınıf: {group.ClassName}");
    foreach (var student in group.Students)
    {
        Console.WriteLine($" - {student.StudentName}");
    }
    Console.WriteLine();
}
