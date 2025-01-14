# 👨‍💻 C# EĞİTİM KAMPI FINANCIAL CRM PROJESİ

FinancialCrm, finansal işlemlerinizi ve banka bilgilerinizi yönetmenize yardımcı olmak için geliştirilmiş bir masaüstü uygulamasıdır. Bu proje, .NET Framework kullanılarak oluşturulmuş olup, özellikle küçük ve orta ölçekli işletmelerin finansal süreçlerini daha kolay yönetmesini hedeflemektedir.

Proje, Database First yaklaşımı ile geliştirilmiş olup, Entity Framework (EF) kullanılarak veritabanı işlemleri gerçekleştirilmiştir. Bu yapı sayesinde, uygulama tamamen dinamik bir yapıya sahiptir ve veritabanı değişikliklerine hızlıca adapte olabilir. Arayüzler, kullanıcıya verileri görsel olarak daha etkili bir şekilde sunmak için tablo, grafik ve panellerle desteklenmiştir.

# Teknik Detaylar

Entity Framework (EF):

Proje, Database First yaklaşımını kullanır. Bu yöntemle, mevcut bir veritabanı model alınır ve Entity Framework bu veritabanına uygun model sınıflarını otomatik olarak oluşturur.

Bu yaklaşım, veritabanı değişikliklerine hızlıca adapte olmayı sağlar.

# Dinamik Arayüzler:

Formlar, veritabanından dinamik olarak veri çekerek çalışır. Tablolar, grafikler ve paneller, kullanıcının finansal verilerini daha etkili bir şekilde analiz etmesine olanak tanır.

# Güvenlik:

Şifreler, modern ve güvenli bir hashleme algoritması ile veritabanında saklanır.

Kullanıcı doğrulama ve yetkilendirme süreçleri güvenli bir şekilde gerçekleştirilir.

# LINQ Sorguları:

Veritabanı işlemleri, LINQ ile gerçekleştirilir. Bu, sorguların daha okunabilir ve yönetilebilir olmasını sağlar.

# Özellikler

📌 Banka Yönetimi:

Banka bilgilerinizi ekleyebilir, düzenleyebilir ve görüntüleyebilirsiniz.

Banka detayları için özel bir arayüz sunar.

📌 Kullanıcı Yönetimi:

Kullanıcıların giriş yapabileceği ve yetkilendirme sağlayabileceğiniz bir sistem.

📌 Finansal İşlemler:

Gelir ve gider kayıtları tutma.

Finansal raporlar oluşturma.

Proje Yapısı

Proje, aşağıdaki ana bileşenlerden oluşmaktadır:

📂 1. FinancialCrm.sln

Bu, projenin çözüm dosyasıdır. Visual Studio ile açılarak proje üzerinde çalışabilirsiniz.

📂 2. App.config

Projenin yapılandırma ayarlarını içerir. Veritabanı bağlantı bilgileri veya uygulama ayarları burada tanımlanmıştır.

📂 3. Formlar

Projede 9 farklı form bulunmaktadır ve bu formlar aşağıdaki işlevleri yerine getirir:

🖼️ FrmBankDetails.cs:

Seçilen bankanın detaylarını görüntüler.

Arayüz, veri doğrulama ve kullanıcı deneyimini artırmak için dinamik alanlarla desteklenmiştir.

🖼️ FrmBanks.cs:

Sistemde kayıtlı tüm bankaların listelendiği arayüzdür.

Liste, dinamik olarak veritabanından alınan bilgilerle güncellenir ve sıralama veya filtreleme işlemleri yapılabilir.

🖼️ FrmBilling.cs:

Fatura ve ödemelerle ilgili kayıtların tutulduğu formdur.

Kullanıcı, ödeme işlemleri ekleyebilir, güncelleyebilir ve düzenleyebilir.

Veriler, tablo ve grafiklerle görselleştirilmiştir.

🖼️ FrmDashboard.cs:

Uygulamanın ana ekranıdır ve genel bir özet sunar.

Finansal verilerin hızlı bir şekilde analiz edilmesi için grafik ve tablo bileşenleri içerir.

🖼️ FrmExpense.cs:

Gider işlemlerinin kaydedilmesi ve yönetilmesi için tasarlanmıştır.

Kullanıcılar, tablo görünümü üzerinden giderleri ekleyebilir, düzenleyebilir veya silebilir.

Gider bilgileri grafiklerle desteklenmiştir.

🖼️ FrmLogin.cs:

Kullanıcıların sisteme giriş yapmasını sağlar.

Giriş bilgileri doğrulanırken, şifreler hashlenmiş olarak veritabanından kontrol edilir.

Yanlış girişlerde kullanıcıya bilgilendirme yapılır.

🖼️ FrmRegister.cs:

Yeni kullanıcıların sisteme kaydolmasını sağlar.

Kullanıcı adı ve şifre gibi bilgileri alır ve şifreyi güvenli bir şekilde hashleyerek veritabanına ekler.

Kullanıcı giriş bilgileri kurallara uygunluk açısından kontrol edilir.

🖼️ FrmResetPassword.cs:

Şifrelerini unutan kullanıcılar için şifre yenileme imkanı sunar.

Kullanıcı doğrulama işlemleri gerçekleştirilir ve yeni şifre hashlenerek veritabanına kaydedilir.

🖼️ FrmSetting.cs:

Uygulama ayarlarının yapılandırılması için kullanılır.

Kullanıcı, profil bilgileri gibi ayarları bu formdan değiştirebilir.

📂 4. Diğer Dosyalar

⚙️ .gitattributes ve .gitignore: Git versiyon kontrol sistemi için gerekli ayar dosyaları.

⚙️ FinancialCrm.csproj: Projenin yapılandırma dosyası, proje bağımlılıklarını ve özelliklerini tanımlar.


# Uygulama Ekran Görüntüleri

![1](https://github.com/user-attachments/assets/84aca697-6b16-46ee-9272-7971e330f096)

![2](https://github.com/user-attachments/assets/ee72ec39-226f-427c-8935-028d779a6f73)

![3](https://github.com/user-attachments/assets/5d8cb898-50d6-4997-9a49-5f8adc1edc5b)

![4](https://github.com/user-attachments/assets/fb26ec0f-6aba-4467-a2b7-714ff663ae52)

![5](https://github.com/user-attachments/assets/717b91d8-0a06-4051-9afa-627a83954924)

![6](https://github.com/user-attachments/assets/8dc5861b-b5f5-4202-a0f0-3c7578db18dc)

![7](https://github.com/user-attachments/assets/10d3022a-a041-42f5-b808-fda76bbb45ba)

![8](https://github.com/user-attachments/assets/16e4a8cf-8e24-43b4-98f6-0a56de1b8a29)

![9](https://github.com/user-attachments/assets/d016deed-7665-4c5b-a20c-38298ccc81e4)

![10](https://github.com/user-attachments/assets/556a3a3b-0d5c-41f5-a1a0-24b875a55009)

![11](https://github.com/user-attachments/assets/a9f139b9-e640-44ee-99d7-8a648606b4dc)

![12](https://github.com/user-attachments/assets/a31ea45d-2bc1-4976-bd41-4e8ee1128852)

![13](https://github.com/user-attachments/assets/33e6c0c1-683d-4a5e-b4c3-8403e458f7d1)

![14](https://github.com/user-attachments/assets/3be72e39-5117-4186-8033-035d5fdd0b83)

![15](https://github.com/user-attachments/assets/9a7c6b31-5bfe-48c4-bed6-d44577c981f1)

![16](https://github.com/user-attachments/assets/bc4f956b-f47c-4405-9aec-5caad1228cf4)

![17](https://github.com/user-attachments/assets/3405c54c-1af3-40f3-b85a-0f3742781958)

![18](https://github.com/user-attachments/assets/05c3ef13-2e0b-4f0f-8bf0-b688cc303a6c)

