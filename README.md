 # Labirent Oyunu
Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş bir masaüstü Labirent oyunudur. Oyuncunun amacı, fareyle veya klavyeyle kontrol ettiği karakteri labirent içerisinde dolaştırarak bitiş noktasına ulaşmaktır.

## Özellikler
Fareyle kontrol: 
Oyuncu karakterini fare hareketleriyle yönlendirebilir.

Klavyeyle Kontrol:
Kullanıcılar, yukarı, aşağı, sol ve sağ ok tuşlarıyla hareket edebilir.

Engel sistemi: 
Duvara çarptığınızda başlangıç noktasına dönersiniz.

Bitirme noktası: 
Bitirme noktasına ulaştığınızda bir tebrik mesajı görünür ve ses efekti çalar.

## Gereksinimler
.NET Framework 4.8 veya üzeri.

Windows işletim sistemi.

## Kurulum
Projeyi indirin veya klonlayın:

bash

Copy code

git clone https://github.com/kullaniciadi/labirent-oyunu.git  

Visual Studio veya benzeri bir IDE ile projeyi açın.

Gerekli NuGet paketlerini yükleyin (varsa).

Projeyi derleyip çalıştırın.

## Kullanım
Oyunu başlatmak için uygulamayı çalıştırın.

Farenizi veya klavyenizi kullanarak karakterinizi labirentte hareket ettirin.

Duvarlara çarpmamaya çalışın, aksi takdirde başlangıç noktasına dönersiniz.

Finish noktasına ulaştığınızda oyunu tamamlamış olacaksınız ve bir tebrik mesajı göreceksiniz.

## Görseller
Oyunla ilgili görseller:

![Ekran görüntüsü 2024-11-15 133415](https://github.com/user-attachments/assets/156046b3-2f01-48b8-ba74-6ae2ef0451f7)

<img width="97" alt="Ekran görüntüsü 2024-11-15 133528" src="https://github.com/user-attachments/assets/11fae920-d7ac-4717-8413-a11e7c5ad7ea">

## Geliştirme Notları
Ses Efektleri: Projede System.Media.SoundPlayer ile başlangıç ve bitirme sesleri eklenmiştir.

Daha fazla özelleştirme ve geliştirme için Form1.cs dosyasındaki kodları düzenleyebilirsiniz.
