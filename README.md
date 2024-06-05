Uçuş Rezervasyon Sistemi - Koray Eriş-20210108050

Bu Windows Forms uygulaması, kullanıcıların uçuş rezervasyonlarını kolayca yapmalarını ve yönetmelerini sağlar. Uygulama, uçuş bilgilerini girme, mevcut uçuşları görüntüleme ve rezervasyon yapma gibi temel işlevleri içerir.

Kurulum


Projeyi İndirme: Projeyi GitHub'dan indirin veya klonlayın.
Gerekli Bağımlılıklar: Projeyi çalıştırmak için Visual Studio veya .NET Framework SDK yüklü olmalıdır.
Veritabanı Ayarları: AppDbContext sınıfındaki veritabanı bağlantısını kendi veritabanınıza göre yapılandırın. Bağlantı dizesi için gerekli bilgileri appsettings.json veya Web.config dosyasında bulabilirsiniz.
Kullanım
Uçuş Bilgileri Girme: FlightForm.cs dosyasını açın ve uçuş bilgilerinizi girin.
Mevcut Uçuşları Görüntüleme: FlightForm.cs dosyasındaki "Listele" butonuna tıklayarak mevcut uçuşları görüntüleyin.
Rezervasyon Yapma: ReservationForm.cs dosyasını açın, uygun koltuğu seçin ve rezervasyonunuzu yapın.

Destek
Herhangi bir sorunuz veya geri bildiriminiz varsa lütfen korayeris4@gmail.com adresine e-posta gönderin.

Gereksinimler
Visual Studio 2019 veya Üstü: Uygulamayı geliştirmek için Visual Studio 2019 veya daha yeni bir sürüm gereklidir.
.NET Framework SDK: Uygulamayı çalıştırmak için .NET Framework SDK'sı yüklü olmalıdır.
Entity Framework Core: Veritabanı işlemleri için Entity Framework Core kütüphanesine ihtiyaç vardır.
SQLite Database: Varsayılan olarak SQLite kullanılmaktadır, bu nedenle SQLite veritabanı motoruna erişmek için gerekli bağımlılıklar yüklü olmalıdır.

