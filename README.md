# 🖤 Kaira Fashion – ASP.NET Core MVC & Dapper Project

**Kaira Fashion**, **ASP.NET Core MVC (.NET 9)** ve **Dapper** kullanılarak geliştirilmiş,
moda / giyim temalı bir web uygulamasıdır.

Proje; **örnek giyim ve moda e-ticaret siteleri incelenerek** tasarlanmış,
**Entity Framework kullanılmadan**, doğrudan **Dapper + SQL** yaklaşımı ile
veri erişimi sağlanacak şekilde geliştirilmiştir.

---

## 🎯 Proje Amacı

Bu projede hedeflenenler:

- Gerçek giyim / moda siteleri örnek alınarak **sektöre uygun bir yapı oluşturmak**
- Dapper ile **manuel SQL sorguları** kullanarak veri erişimi sağlamak  
- ASP.NET Core MVC mimarisini gerçek bir senaryo üzerinde uygulamak  
- Admin ve kullanıcı tarafı ayrımı olan bir web uygulaması geliştirmek  
- İleride **tam kapsamlı bir internet alışveriş sitesine** dönüştürülebilecek
  altyapıyı hazırlamak

---

## 🏗️ Proje Yapısı

Proje **tek WebUI** yapısı üzerinden geliştirilmiştir.

Kaira_DapperProject
│
├── Controllers
├── Views
├── Areas
│ └── Admin
├── Repositories
│ ├── ProductRepository
│ ├── WearRepository
│ └── CollectionRepository ....
├── Models / DTOs
└── wwwroot


- Katmanlı mimari yerine **sade ve kontrol edilebilir** bir yapı tercih edilmiştir  
- Veri erişimi **Repository mantığı** ile Dapper üzerinden sağlanmaktadır

---

## 🛠️ Kullanılan Teknolojiler

- **.NET 8**
- **ASP.NET Core MVC**
- **Dapper**
- **SQL Server**
- **Repository Yapısı**
- **DTO Kullanımı**
- **Razor View**
- **Bootstrap 5**
- **Admin Area**

---

## 👗 Uygulama Özellikleri

### 🔹 Kullanıcı Tarafı
- Ana sayfa
- Wear (kategori) listeleme
- Wear’a bağlı ürün listeleme
- Ürün detay sayfaları
- Giyim sitelerine uygun sade ve modern UI

### 🔹 Admin Panel
- Wear (Kategori) yönetimi
- Ürün yönetimi
- Koleksiyon yönetimi
- CRUD işlemleri
- Admin Area yapısı

---

## 🗄️ Veritabanı Yapısı

- **SQL Server**
- Dapper ile yazılmış **manuel SQL sorguları**
- Temel tablolar:
  - Wears
  - Products
  - Collections

---

## ⚡ Neden Dapper?

Bu projede **Dapper** tercih edilmiştir çünkü:

- Performanslı ve lightweight bir yapı sunar  
- SQL üzerinde tam kontrol sağlar  
- Dapper, SQL sonuçlarını C# nesnelerine map eden hafif bir veri erişim aracıdır.
---

## ✅ Proje Durumu

> ✔️ **Proje tamamlanmıştır**  
Portföy amaçlı olarak hazır durumdadır ve  
ileride **internet alışveriş sitesine ve mobil uygulama platformuna dönüştürülebilir** yapıdadır.
---

## 👩‍💻 Geliştirici

**Merve Arpacıoğlu Türk**  
ASP.NET Core Developer  

🔗 GitHub: https://github.com/merveearp
---

⭐ Projeyi beğendiysen yıldız vermeyi unutma
Projeden alınan UI VE Admin görseller ; 

![UI-1](https://github.com/user-attachments/assets/3ea0d4e6-1d91-4551-a06c-95a647aa1374)
![UI-2](https://github.com/user-attachments/assets/169ef853-3926-4af7-80e2-9b59849e11b9)
![UI-3](https://github.com/user-attachments/assets/e4706d6a-5593-41a0-a545-f6c035ca2b8d)
![UI-4](https://github.com/user-attachments/assets/72fc94f0-67d3-4d10-9f81-deb6eaf80cb2)
![UI-7](https://github.com/user-attachments/assets/6e5357f9-64d7-4b8b-ab67-ee36790dd1e4)
![UI-9](https://github.com/user-attachments/assets/14909b28-9951-44d6-b02e-ae5a76b85a27)
![ADMIN-1](https://github.com/user-attachments/assets/bddb8a93-d706-42b0-8da2-db8c9125b6f1)
![ADMIN-4](https://github.com/user-attachments/assets/b17012da-fdc8-493c-8cea-c5c5aace90ea)
![ADMIN-6](https://github.com/user-attachments/assets/040ca0ea-2558-4166-acc4-657a8963c9ab)
![ADMIN-8](https://github.com/user-attachments/assets/38d43b15-c973-465a-b55f-17f71b980204)
![ADMIN-12](https://github.com/user-attachments/assets/734fcb82-5adc-44f7-8756-8f95a52d0276)
![ADMIN-9](https://github.com/user-attachments/assets/fcdfa636-d052-4982-87d6-e01d6431d660)










