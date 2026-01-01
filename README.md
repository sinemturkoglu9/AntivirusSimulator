# 🛡️ Antivirus Simulator (C# WinForms)

Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş **eğitim amaçlı bir Antivirüs Simülatörüdür**.  
Uygulama, gerçek virüs temizleme işlemleri yapmaz; antivirüs yazılımlarının **dosya tarama, şüpheli dosya tespiti ve karantina** mantığını simüle eder.

---

## 🎯 Projenin Amacı
- Antivirüs yazılımlarının temel çalışma prensiplerini göstermek
- İmza tabanlı ve sezgisel (heuristic) tarama mantığını uygulamak
- Şüpheli dosyaları silmeden izole eden **karantina** yaklaşımını modellemek

---

## ⚙️ Uygulama Özellikleri
- 📁 Klasör seçme
- 🔍 Dosya tarama
- 🧠 İmza tabanlı kontrol (uzantı bazlı)
- 🧪 Heuristic tarama (dosya adı analizi)
- 🟢 Temiz / 🔴 Şüpheli dosya ayrımı
- 🛡️ Şüpheli dosyaları karantinaya alma
- 📝 Log (kayıt) tutma
- 📊 ProgressBar ile tarama durumu gösterimi

---

## 🧠 Kullanılan Antivirüs Yaklaşımları

### 🔹 İmza Tabanlı Tarama
Riskli kabul edilen dosya uzantılarına göre kontrol yapılır.  
Örnek:
- `.exe`
- `.bat`
- `.vbs`
- `.scr`

### 🔹 Heuristic (Sezgisel) Tarama
Dosya adında şüpheli anahtar kelimeler aranır.  
Örnek:
- `virus`
- `trojan`
- `keygen`
- `crack`

---

## 🛡️ Karantina Mantığı
Şüpheli bulunan dosyalar **silinmez**.  
Bunun yerine, seçilen klasör içinde oluşturulan **Karantina** klasörüne taşınır.

Bu yaklaşım:
- Yanlış pozitif durumlarında veri kaybını önler
- Dosyaların gerekirse geri alınabilmesini sağlar
- Gerçek antivirüs yazılımlarının çalışma mantığına uygundur

---

## 🧪 Test Senaryosu (Önerilen)
Test için boş bir klasör oluşturulup içine aşağıdaki dosyalar eklenebilir:

virus.exe

crack.bat

deneme.txt

---

Tarama sonucunda:
- `.exe` ve `.bat` dosyaları **ŞÜPHELİ**
- `.txt` dosyası **TEMİZ** olarak işaretlenir.

---

## 🧩 Kullanılan Teknolojiler
- C#
- Windows Forms
- .NET Framework
- System.IO (Dosya & Klasör işlemleri)

---

## ⚠️ Not
Bu proje **eğitim amaçlıdır**.  
Gerçek virüs üretme, çalıştırma veya sistem dosyalarına zarar verme işlemleri içermez.

---

## 👨‍💻 Geliştirici
- Öğrenci Projesi  
- C# / WinForms

