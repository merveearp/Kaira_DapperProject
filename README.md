# 🖤 Kaira Fashion – ASP.NET Core MVC & Dapper Project

**Kaira Fashion**, **ASP.NET Core MVC (.NET 8)** ve **Dapper** kullanılarak geliştirilmiş,
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
