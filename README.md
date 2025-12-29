Bu uygulama, C# dilinde üç temel konuyu tek bir örnek üzerinden göstermek amacıyla geliştirilmiştir:

**Console App (.NET) - Framework: .NET 7.0**

1) Struct kullanımı
2) Exception (hata) yönetimi
3) Reflection ve Attribute kullanımı

Bu uygulama, C# dilinde struct kullanımı, exception yönetimi ve reflection–attribute ilişkisini göstermek amacıyla geliştirilmiştir. Reflection kullanılarak sınıf ve metotlara ait metadata bilgileri çalışma zamanında okunmuş ve raporlanmıştır. Kod, eğitim ve demonstrasyon amaçlı olarak modüler ve okunabilir şekilde tasarlanmıştır.

## 1) StructDemo - Struct Kullanım Amacı

**Neden struct kullandık?**

Küçük veri modelleri için struct kullanımını örneklemek

- Student küçük ve basit bir veri yapısıdır
- Sadece veri tutar (Id, Name, Gpa)
- Value type olduğu için performans açısından uygundur

**StructDemo metodunun amacı:**

- struct ile nesne oluşturmayı göstermek
- List içinde struct kullanımı
- Verilerin ekrana yazılması

## 2) ExceptionDemo - Exception (Hata) Yönetimi Amacı

Programın güvenli çalışmasını ve hataların kontrollü şekilde yönetilmesini göstermek
```
try{...} catch{...} finally{...}
```

**Neden yaptık?**

- Kullanıcıdan gelen girişler hataya açıktır
- Programın çökmesini önlemek gerekir

**Bu demoda yakalanan hatalar:**

- DivideByZeroException - Sıfıra Bölme
- FormatException - Sayı yerine metin girilmesi

**finally bloğu neden var?**

- Hata olsa da olmasa da çalışır
- Temizlik/Loglama işlemleri için kullanılır

## 3) ReflectionReport - Reflection ve Attribute Amacı

Reflection ile attribute'lardan dinamik rapor üretmeyi göstermek

**Attribute neden kullanıldı?**
```csharp
[DeveloperInfo("Eren", "1.0")]
```

- Kod hakkında metadata (ek bilgi) tutmak için
- Developer adı ve versiyon bilgisini saklamak için
- Kodu değiştirmeden bilgi ekleyebilmek için

**Reflection neden kullanıldı?**
```csharp
Type type = typeof(SampleService);
type.GetMethods(...)
```

- Program çalışırken sınıf ve metot bilgilerine ulaşmak için
- Attribute bilgilerini dinamik olarak okumak için

**ReflectionReport metodunun yaptığı şey:**

- SampleService sınıfını inceler
- Metotların üzerindeki DeveloperInfo attribute'larını okur
- Developer ve version bilgilerini raporlar

## Kodun Genel Yapısının Amacı

- Her konu ayrı metoda bölünmüştür
- Main sadece akışı yönetir
- Kod okunabilir ve bakımı kolaydır
- Single Responsibility Principle uygulanmıştır

<img width="386" height="282" alt="Image" src="https://github.com/user-attachments/assets/67b4d5b7-27a3-4fb3-a379-211028fb9b31" />

<img width="386" height="290" alt="Image" src="https://github.com/user-attachments/assets/c1a68302-bacb-48d7-be5a-fb46b545a6ab" />


This project is an evolution of:
https://github.com/Eren-KIRMIZI/DotNetReflectionWebApi/
