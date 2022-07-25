using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBox
{
    public static class database
    {
        public static List<urun> urunTablo = new List<urun>()
        {
            new urun() {id = 1, urunAdi = "İnsanlar", urunKategori = "Roman", urunStok = 15, aciklama = @"“Bu satırları okuyanlarınızın büyük çoğunluğunun, insanların bir mitten ibaret olduğuna inandığını biliyorum ama ben size onların gerçekten var olduklarını bildirmek üzere buradayım. Bilmeyenler için söyleyeyim, insan dediğimiz şey orta zekâlı ve iki ayaklı bir yaşam formu; evrenin çok ıssız bir köşesinde yer alan küçük ve sulu bir gezegende, büyük ölçüde yanılsamalarla dolu bir varoluş sürdürüyor.”

            Yağmurlu bir akşamda Profesör Andrew Martin, önce dünyanın en büyük matematik bilmecesini çözmeyi başarıyor, ardından sırra kadem basıyor. Nihayet bir yol kenarında çırılçıplak halde bulunduğunda, kıyafetsizlikten daha ciddi bir meselesi olduğu ortaya çıkıyor: Andrew Martin artık insanlardan tiksiniyor; görünüşlerinden de yiyip içtiklerinden de bitmeyen şiddet ve savaş arzularından da... Yabancı bir tür arasında kaybolmuş hissediyor kendini. Sevgi ve aile kavramları onda şaşırtıcı bir ilgi uyandırsa da tüm sakinlerinden nefret ediyor bu gezegenin. Newton hariç... Ama o da bir köpek işte...

            Sahi, kim bu adam? Onun –ya da herhangi birinin– insanlık hakkındaki tüm fikrini değiştiren şey ne olabilir?

            Son yılların en önemli romancılarından Matt Haig, onca karmaşıklığına rağmen hayatın içindeki mutluluğa ve insan doğasına dair alışılmadık bir hikâye sunuyor. İnsanlar, neşeli ve etkileyici bir üslupla “bizi” bize anlatıyor.", yazar = "Matt Haig", urunResim=@"C:\Users\Furki\source\repos\WindowsFormsApp2\ComboBox İnceleme\resimler\insanlar.jpg"},
            new urun() {id = 2, urunAdi = "Aşka Özür Diletmem", urunKategori = "Roman", urunStok = 10, aciklama = @"“Sevgi; hayatı da ölümü de aşar.”
            Geçmişiyle hesaplaşmak için yola çıkan bir kadın; Ada.
            Geleceğinin her anını planlamış bir adam; Toprak.
            Tesadüflerin bir araya getirdiği iki kalbin birbirine kavuşması herkesin hayatını altüst edecektir. Yalanlar, günahlar, sırlar arasında filizlenen bir aşk ne kadar serpilebilir? Ada’nın acı dolu geçmişi geleceğini kurmasının önünde engel olarak dururken, Toprak ilk kez yarınlar için endişelenmeden bırakıyor kendini aşkın kollarına.
            Her şeyin karşısına dikilip aşkına sahip çıkan Toprak, ölüme de meydan okuyor. Sadakatin, dostluğun, aile ilişkilerinin, hüzünlü çocukluk anılarının sorgulandığı Aşka Özür Diletmem birbirini seven iki insanın önündeki engelleri aşma hikâyesi.", yazar = "Dilek Görmez", urunResim = @"C:\Users\Furki\source\repos\WindowsFormsApp2\ComboBox İnceleme\resimler\aska_ozur.jpg"},
            new urun() {id = 3, urunAdi = "Matem Çiçekleri", urunKategori = "Roman", urunStok = 20, aciklama = @"“Kozayı korkunç bir hastalık sardı, kelebek artık acıya tutsaktı.

            O çok korktuğun acı, kelebek; seni sarıp sarmalayacaktı.”",yazar = "Beyza Aksoy", urunResim = @"C:\Users\Furki\source\repos\WindowsFormsApp2\ComboBox İnceleme\resimler\matem_cicekleri.jpg"},
            new urun() {id = 4, urunAdi = "Saklambaç", urunKategori = "Roman", urunStok = 10, aciklama = @"Ophelia Valley kasabasında yaz boyunca iki cinayet işlendi. Kayıp kızlar şüpheli şekilde ölü bulundu. Ansel, Maddie ve Kylie her zaman yaptıkları gibi hayatlarını basit ve ortada yaşayarak eğleniyorlar, böylece kimse kurcalamıyordu. Ancak kasabaya yeni gelen genç Dedektif Wallace, kızların yakasını bırakacak gibi değildi.

 

            “Bazı sırlar dedektif, ölümden daha korkutucudur.”

            Bu yüzden benden hoşlanıyorsunuz. Ama biliyorsunuz, katil peşinize düştüğü zaman siz de gerçekten kim olduğunuzun peşine düşersiniz.

            Ya da gerçek benliğiniz, üzerini örttüğünüz her şeyle birlikte peşinize düşer.

            İşte bundan kaçamazsınız.",yazar = "N.G Kabal", urunResim = @"C:\Users\Furki\source\repos\WindowsFormsApp2\ComboBox İnceleme\resimler\saklambac.jpg"}

        };


    }
}
