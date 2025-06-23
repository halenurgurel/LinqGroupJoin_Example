# LINQ GroupJoin ile Sınıf-Öğrenci Listesi

Bu C# konsol uygulaması, **LINQ GroupJoin** kullanarak her sınıfa ait öğrencileri alt alta gruplu şekilde ekrana yazdırır.  
Amaç; bir sınıfın altında o sınıfa ait öğrencilerin isimlerini birlikte gösterebilmektir.

---

## 🚀 Özellikler

- `Classes` ve `Students` adında iki liste ile çalışır.
- Her sınıf (`ClassId` ile) ilgili öğrencilerle eşleştirilir.
- Her sınıf başlığının altında, o sınıfa ait tüm öğrenciler alt alta gösterilir.
- LINQ ile **GroupJoin** yapısı uygulanmıştır.

---

## 📚 Kullanılan Sınıflar

### `Classes`
| Özellik   | Açıklama    |
|-----------|-------------|
| ClassId   | Sınıfın benzersiz numarası |
| ClassName | Sınıf adı   |

### `Students`
| Özellik      | Açıklama        |
|--------------|-----------------|
| StudentId    | Öğrenci numarası|
| StudentName  | Öğrenci adı     |
| ClassId      | Öğrencinin sınıfı|

---

## 💻 Koddan Parça

```csharp
var classesWithStudents = classes.GroupJoin(
    students,
    c => c.ClassId,
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
```

## 🖨️ Örnek Çıktı
Sınıf: Matematik
 - Ali
 - Mehmet

Sınıf: Türkçe
 - Ayşe
 - Ahmet

Sınıf: Kimya
 - Fatma

## 🎯 Öğrenilen LINQ Konuları
GroupJoin ile gruplama ve birleştirme

Koleksiyonlar arası ilişki kurma

Foreach ile iç içe liste yazdırma
