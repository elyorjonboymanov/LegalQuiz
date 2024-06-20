using LegalQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalQuiz.Model
{

    public class Quiz_Item
    {
        public Quiz_Item()
        {
        }
        public int Id { get; set; }
        public string Question { get; set; }
        public string? Comment { get; set; }

    }
    public class Quiz
    {
        public Quiz(int Science, int Lang)
        {
            if (Science == 1)
            {
                //if (Type == 1)
                //    Generator_MockData();
                //else
                if (Lang == 1)
                    Generator_MockData_Uz_K();
                else
                    Generator_MockData_Ru_K();
            }
            else
            {
                //if (Type == 1)
                //    Generator_MockData();
                //else
                if (Lang == 1)
                    Generator_MockData_Uz_H();
                else
                    Generator_MockData_Ru_H();
            }

        }
        public List<Quiz_Item> Logical_question_1 { get; set; } = new List<Quiz_Item>();
        public List<Quiz_Item> Logical_Cases_1 { get; set; } = new List<Quiz_Item>();

        private void Generator_MockData()
        {
            this.Logical_question_1 = new List<Quiz_Item>();
            this.Logical_Cases_1 = new List<Quiz_Item>();

            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Huquqbuzarliklar profilaktikasi tushunchasini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Huquqbuzarliklar profilaktikasi obyekti, predmeti, maqsadi, vazifalari va metodlari haqida ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Huquqbuzarliklar profilaktikasi sohasida amalga oshirilgan islohotlar haqida to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Huquqbuzarliklar profilaktikasi amalga oshiruvchi subyektlar tizimi haqida tushuncha bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "Ichki ishlar organlari sohaviy xizmatlar haqida ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Huquqbuzarliklar profilaktikasi subyektlarning vakolatlarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Huquqbuzarliklar profilaktikasi subyektlar tizimini amalga oshirishdagi muammolar. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Huquqbuzarliklar umumiy profilaktikasi tushunchasiga ta’rif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Huquqbuzarliklar maxsus profilaktikasi tushunchasiga ta’rif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Ma’muriy hududda profilaktika inspektori tomonidan huquqbuzarliklar umumiy profilaktikasini tashkil etish bo‘yicha amalga oshiriladigan ishlar haqida ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Ma’muriy hududda profilaktika inspektori tomonidan huquqbuzarliklar maxsus profilaktikasini tashkil etish bo‘yicha amalga oshiriladigan ishlar. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Profilaktika inspektorining ayrim shaxslar toifalari o‘rtasida huquqbuzarliklarning maxsus profilaktikasini tashkil etish faoliyati." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Huquqbuzarliklar viktimologik profilaktikasi tushunchasi va chora-tadbirlari." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Ma’muriy hududda profilaktika inspektori tomonidan huquqbuzarliklar viktimologik profilaktikasini tashkil etish bo‘yicha amalga oshiriladigan ishlarga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Profilaktika inspektorining ayrim turdagi huquqbuzarliklarning viktimologik profilaktikasini tashkil etish faoliyatini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Huquqbuzarliklar yakka tartibdagi profilaktikasi tushunchasi va chora-tadbirlari haqida ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Huquqbuzarliklar yakka tartibdagi profilaktikasini qo‘llash shartlari va asoslari nimalardan iborat." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Ma’muriy hududda profilaktika inspektori tomonidan huquqbuzarliklar yakka tartibdagi profilaktikasini tashkil etish bo‘yicha amalga oshiriladigan ishlarga to‘xtalib o‘ting" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Profilaktika suhbati nima? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Rasmiy ogohlantirish nima?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Huquqbuzarliklar sabablari va sodir etilishiga imkon bergan shart-sharoitlar to‘g‘risida xabardor qilish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Ijtimoiy reabilitatsiya qilish va ijtimoiy moslashtirish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Profilaktik hisobga olish haqida batafsil to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "Majburiy davolanishga yuborish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Ma’muriy nazorat o‘rnatish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Ichki ishlar organlarining jamoatchilik bilan hamkorligini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Ichki ishlar organlarining boshqa davlat organlari bilan hamkorligi nimalardan iborat." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Ichki ishlar organlarining huquqbuzarliklar profilaktikasi tizimidagi asosiy vazifalari, tutgan o‘rni, bajarayotgan funksiyasiga to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "Profilaktika inspektori tomonidan jismoniy va yuridik shaxslarning murojaatlarini ko‘rib chiqish masalasiga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Profilaktika inspektorining jismoniy va yuridik shaxslarning murojaatlarini ko‘rib chiqish faoliyatining huquqiy asoslarini yoriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Ma’muriy hududda profilaktika inspektori tomonidan jismoniy va yuridik shaxslarning murojaatlarini ko‘rib chiqish bo‘yicha amalga oshiriladigan ishlar haqida batafsil ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Mahalla huquq-tartibot maskanini tashkil etish tartibini tushuntiring." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Mahalla huquq-tartibot maskanining asosiy vazifasi hamda tarkibiy tuzulmasiga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Huquqbuzarliklarning barvaqt oldini olish, shuningdek Jamiyatda huquqiy madaniyatni yuksaltirish bo‘yicha profilaktika inspektori tomonidan amalga oshiriladigan ishlarga to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Huquqbuzarliklar profilaktikasi kunida profilaktika inspektori tomonidan amalga oshiriladigan ishlarga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Milliy gvardiya bo‘linmalarining jamoat tartibi va xavfsizligini ta’minlash borasidagi huquq va majburiyatlarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Milliy gvardiya bo‘linmalarining jamoat tartibi va xavfsizligini ta’minlash jarayonidagi asosiy bajaradigan ishlariga batafsil to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Ommaviy tadbirlar, yig‘ilishlar, mitinglar, namoyishlar o‘tkazish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Ommaviy va guruhiy taritibsizliklarni keltirib chiqaruvchi omillar deganda nimani tushunasiz. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Ma’muriy hududda favqulodda holatlarda profilaktika inspektori tomonidan amalga oshiriladigan ishlarga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Ommaviy va guruhiy tartibsizliklarni bartaraf etish nimadan iborat. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Profilaktika inspektorlari faoliyatida kasbiy mahoratning ahamiyati." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Yuqori kasbiy mahoratga ega profilaktika inspektorlari tomonidan xizmat faoliyatida qo‘llanilayotgan profilaktika ishini tashkil etishning zamonaviy va namunali shakllari hamda usullarini yoriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Profilaktika inspektorlari faoliyatida kuzatilayotgan tizimli kamchiliklar va ularni bartaraf etish chora-tadbirlari nimalardan iborat." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Jamoat xavfsizligini ta’minlash maqsadida jismoniy kuch ishlatish degnada nimani tushunasiz." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Ommaviy tadbirlarni o‘tkazish jarayonida profilaktika inspektorining ishtirokini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Ommaviy tadbirlarni o‘tkazish jarayonida jamoat tartibi va fuqarolar xavfsizligini ta’minlash nimalardan iborat." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "O‘zbekistonda sohaga katta e’tibor berilishiga sabab nimadan iborat?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Huquqbuzarliklar profilaktikasi sohasini takomillashtirish bo‘yicha O‘zbekiston Respublikasida amalga oshirilayotgan islohotlar yoriting. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Huquqbuzarlikdan jabrlanuvchi kim? Moddiy, ma’naviy va jismoniy zarar tushunchalariga oydinlik kiriting." });
            /*this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Ma’muriy hududdagi kreminogen vaziyatni keltirib chiqaruvchi omillarga batafsil to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Profilaktika inspektori tomonidan yuritiladigan ish kitoblarinni yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Profilaktika inspektorining jinoyatlarni fosh etish va qidiruvdagi shaxslarni aniqlash faoliyatining o‘ziga xos xususiyati nimadan iborat." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Oilalardagi tazyiq va zo‘ravonlikdan himoya qilish sohasidagi davlat siyosatining asosiy yo‘nalishlari bo‘yicha ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Voyaga etmaganlar o‘rtasida nazoratsizlik va huquqbuzarliklar profilaktikasini tashkil etish va muvofiqlashtiruvchi organlarga to‘xtalib o‘ting" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Profilaktika inspektorining voyaga etmaganlarni ixtisoslashtirilgan o‘quv tarbiya muassasasiga joylashtirish tartibi" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Profilaktika inspektorining uy qamog‘i tarzidagi ehtiyot chorasi qo‘llanilgan shaxslarni hisobga olish va nazoratini amalga oshirish tartibi" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Profilakitika inspektorining probasiya xizmati nazoratidagi shaxslar bilan ishlash faoliyati" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Jazoni ijro etish mussasalaridan ozod qilingan ayrim toifadagi shaxslar ustidan ma’muriy nazorat sohasini tartibga soluvchi qonun hujjatlarini yoritib bering" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Profilaktika inspektorining muayyan yashash joyiga ega bo‘lmagan shaxslar bilan ishlash faoliyatinining tushunchasiga ta’rif bering." });*/


            this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Konstitutsiyaviy huquq jamiyat va davlat qurilishining huquqiy asoslarini o‘rnatadi degan qarash mavjud. Sizningcha buning mohiyati nimadan iborat? Fikringizni misollar yordamida ifodalang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Konstitutsiyaviy huquq shaxs, jamiyat va davlat o‘rtasidagi munosatlarni tartibga solishi aytiladi. Sizningcha barcha konstitutsiyaviy-huquqiy munosabatda mazkur uchta sub’ekt bir paytda ishtirok etadimi? Fikringizni hayotiy misollar yordamida asoslang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Konstitutsiyaviy huquq shaxs, jamiyat va davlat o‘rtasidagi munosatlarni tartibga solishi aytiladi. Jamiyat va davlat o‘rtasidagi konstitutsiviy-huquqiy munosabatlarga misollar keltirgan holda ushbu munosabatlarning xususiyatlarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Suverenitet tushunchasining mohiyati nimadan iborat? Nima uchun aynan “oliy hokimiyat” degan ma’noni anglatuvchi mazkur tushuncha davlatga nisbatan qo‘llanila boshlangan deb o‘ylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Jamiyat hayoti uchun har bir huquq sohasining o‘z o‘rni bor. Bunda, konstitutsiyaviy huquq yetakchi huquq sohasi deb e’tirof etiladi. Konstitutsiyaviy huquqning bunday maqomga munosib ko‘rilishi qay darajada asosli deb o‘ylaysiz? Fikringizni hayotiy misollar yordamida asoslang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Bugungi kunda dunyoda konstitutsiyalar nazariy jihatdan yumshoq va qattiq turlarga ajratiladi. Mazkur turlarga atroflicha to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Konstitutsiyaviy-huquqiy normalar va konstitutsiyaviy huquq manbalari o‘rtasida qanday bog‘liqlik mavjud deb o‘ylaysiz? Fikringizni misollar yordamida ifodalang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "O‘zbekiston Respublikasining Konstitutsiyasi qabul qilingach u asosida ko‘plab boshqa qonunlarni qabul qilish kerak edi. Bunda, yetarlicha qonunchilik tizimini yaratish vaqt talab qilardi. Ushbu holatda bevosita Konstitutsiya bilan tartibga solinmagan munosabatlar qanday tartibga solingan deb o‘ylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Huquq ustuvorligi va Konstitutsiyaning ustunligi o‘rtasida qanday farq bor deb o‘ylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Mamlakatimizda huquq ustuvorligini ta’minlashda huquq ustuvorligi elementlaridan qaysi biriga ko‘proq ahamiyat berish kerak deb o‘ylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Huquqning har bir filiali jamiyat hayotida o‘z o‘rnini egallaydi. Shu bilan birga, konstitutsiyaviy huquq huquqning yetakchi bo‘g‘ini sifatida e’tirof etiladi. Sizningcha, konstitutsiyaviy qonunchilikni bunday maqomga loyiq deb hisoblash qanchalik oqilona? Fikringizni haqiqiy misollar bilan oqlang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "O‘zbekiston Respublikasi Konstitutsiyasining 13-moddasiga ko‘ra, inson, uning huquq va erkinliklari eng oliy qadriyat hisoblanadi. Xo‘sh, nega inson va fuqaroning huquq va erkinliklari birinchi bobda emas, beshinchi bobda ko‘zda tutilgan? Normativ-huquqiy xujjatlarni bunday tartibga solishning maqsadga muvofiqligini tasdiqlovchi nazariy va me’yoriy dalillar berish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Xususiy mulkning daxlsizligini va uning davlat tomonidan himoyalanishini ochib berish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Suverenitet tushunchasining mohiyati nimadan iborat? Nima uchun aynan “oliy hokimiyat” degan ma’noni anglatuvchi mazkur tushuncha davlatga nisbatan qo‘llanila boshlangan deb o‘ylaysiz? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Shaxsning huquqiy maqomi tushunchasiga ta’rif bering. Shaxsning huquqiy maqomi qanday turlarga bo‘linadi?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "O‘zbekiston Respublikasi fuqarosi, chet el fuqarosi va fuqaroligi bo‘lmagan shaxslarning konstitutsiyaviy-huquqiy holatida qanday farqlar mavjud deb o‘ylaysiz? Fikringizni amaliy misollar yordamida bayon eting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Asosiy va qo‘shimcha huquqlar deganda nimani tushunasiz? Asosiy huquqlarga qanday huquqlarni misol keltira olasiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "O‘zbekistonda xotin-qizlar va erkaklar hayotning barcha sohalarida to‘la teng huquqlarga ega bo‘lib, ular Konstitutsiya, qonunlar va boshqa normativ-huquqiy hujjatlar bilan kafolatlanadi. Ushbu huquqiy kafolatlar aks etgan huquqiy hujjatlarni sanab bering. Sizningcha, gender tenglikni ta’minlashda qanday hal etilmagan muammolar mavjud?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "O‘zbekiston Respublikasining amaldagi qonunchiligida to‘g‘ridan-to‘g‘ri demokratiyaning qanday turlari ko‘zda tutilgan? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "O‘zbekiston Respublikasi fuqarosi, chet el fuqarosi va fuqaroligi bo‘lmagan shaxslarning konstitutsiyaviy-huquqiy holatida qanday farqlar mavjud deb o‘ylaysiz? Fikringizni amaliy misollar yordamida bayon eting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Inson manfaati, huquqlari qanday holatlarda cheklanishi mumkin? Fuqarolar o‘z huquq va erkinliklarini amalga oshirishda boshqa shaxslarning, davlat va jamiyatning qonuniy manfaatlari, huquqlari va erkinliklariga putur yetkazmasliklari shartligi deganda nimani tushunasiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Sizningcha inson huquqlariga oid umumiy qoidalar yana qanday qoidalarni kiritish mumkin? Fikringizni huquqshunos olimlar yoki xorijiy mamlakatlar konstitutsiyaviy tajribasi bilan asoslang?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Ijtimoiy va iqtisodiy huquqlarning farqli jihatlari nimadan iborat deb o‘ylaysiz? Ijtimoiy va iqtisodiy huquqlarning Konstitutsiyada mustahkamlanishining ahamiyati nimada?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "O‘zbekiston Respublikasining Konstitutsiyasi 53-moddasiga ko‘ra “Xususiy mulk boshqa mulk shakllari kabi daxlsiz va davlat himoyasidadir”. Xususiy mulkning daxlsizligi deganda nimani tushunasiz? Fikringizni amaliy misollar yordamida bayon eting. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "O‘zbekiston Respublikasining Konstitutsiyasi 37-moddasiga binoan har bir shaxs adolatli mehnat sharoitlarida ishlash huquqiga ega. “Adolatli mehnat sharoitlari deganda” nimani tushunasiz? Fikringizni amaliy misollar yordamida bayon eting. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Nodavlat notijorat tashkilotlarini tugatish tartibi haqida ma’lumot bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Nodavlat notijorat tashkilotlariga davlat xizmatlarini ko‘rsatish tartib-taomillarini tushuntirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "OAV faoliyatida senzuraga munosabat qanday?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "OAV sohasini tartibga solishga qaratilgan qonunlarga misol keltiring va ular mazmunini sharhlang." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "O‘zbekiston Respublikasida chet el fuqarolari va fuqaroligi bo‘lgan shaxslarning huquqiy maqomini o‘ylab ko‘ring va muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Fuqarolarning davlat organlariga murojaatlari masalalari qaysi qonun hujjatlarida tartibga solinadi?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Ijtimoiy va iqtisodiy huquqlarning mohiyati va ma’nosini ochib berish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Respublika hududi doirasida erkin harakatlanish, O‘zbekiston Respublikasiga kirish va chiqish huquqini muhokama qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "O‘zbekiston respublikasida gender tenglik va gender tenglik masalalarini muhokama qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Ma’muriy-hududiy tuzilish tushunchasi va davlat tuzilishi tushunchasining aloqasini muhokama qiling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "O‘zbekiston Respublikasining davlat tuzilish shaklini muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Davlat ishlarini boshqarish huquqining mazmunini oshkor qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "O‘zbekiston Respublikasining Ma’muriy-hududiy va davlat tuzilishi mazmunini tushuntirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Davlat hokimiyati faoliyatini amalga oshirish printsiplari." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Saylov va saylov huquqi tushunchalari, saylov tizimi deganda nimani tushunasiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Mamlakatimizda huquq ustuvorligini taʼminlashda huquq ustuvorligi elementlaridan qaysi biriga koʻproq ahamiyat berish kerak deb oʻylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Inson va fuqarolarning huquq va burchlari deganda nimani tushunasiz? Inson huquqlari haqida xalqaro hujjatlarni koʻrsating." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Fuqarolarning asosiy burchlarini tasniflab, mazmunini ochib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Oʻzbekiston Respublikasi Konstitutsiyasida fuqarolarning bevosita koʻrsatilgan asosiy burchlari va maxsus bobda koʻrsatilmagan burchlarni misollar yordamida tahlil qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Oʻzbekiston Respublikasi Oliy Majlisini shakllantirish tartibini muhokama qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Oʻzbekiston Respublikasida mahalliy oʻzini oʻzi boshqarish asoslarini ochib berish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Oʻzbekiston Respublikasi Oliy Majlisi palatalarining mazkur qoʻshma vakolatlarini  muhokama qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Oʻzbekiston Respublikasi Oliy Majlisining Qonunchilik palatasini tuzish tartibi haqida soʻzlab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Oʻzbekiston Respublikasi Prezidentini saylash tartibi toʻgʻrisida maʼlum qilish." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Oʻzbekiston Respublikasi Prezidentining davlat hokimiyatining boshqa organlari bilan oʻzaro aloqalarini muhokama qilish." });









            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 1, Question = "Lavozimiga yangi tayinlangan profilaktika inspektori N. o‘ziga biriktirilgan mahallada g‘ayriijtimoiy xulq-atvori xavfliligi tufayli kelgusida huquqbuzarlik sodir etish ehtimoli yuqori bo‘lgan, manaviy va axloqiy qadriyatlarni mensimaydigan, huquqiy negilistik kayfiyatga ega bo‘lib shaxslarni aniqlash borasida mahalla raisi bilan hamkorlikda ish boshladi. ", Comment = "Profilaktika inspektori N. bu toifa kishilarni aniqlashda nimalarga e’tibor qaratishi kerak? Huquqbuzarlik sodir etishga moyil bo‘lgan shaxslar toifasiga kimlar kiradi?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 2, Question = "Profilaktika inspektori Q. huquqbuzarlikdan jabrlanuvchiga aylanishi xavfini kamaytirish maqsadida ma’naviy va jismoniy jihatdan ojizlar, ayollar, qariyalar, yosh bolalar, nogironlar bilan doimiy viktimologik profilaktika o‘tkazib keladi. ", Comment = "Mazkur xavf yoki viktimlik uchta, ya’ni viktimlik past, o‘rtacha va yuqori bo‘lgan darajalarga ta’rif bering. Yuqorida sanab o‘tilgan toifa vakillari qaysi darajaga mansub." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 3, Question = "2020-2021 yillar davomida O‘zbekiston Respublikasi Prezidentining tashabbusi bilan to‘rt marta “Mehr operatsiyasi” o‘tkazildi. Ba’zi fuqarolar davlatning bu ishini insonparvarlik prinsipining yorqin namunasi deb baholasa, ba’zilari “vatan xoinlari”ga bunchalik g‘amho‘rlik qilish shart emas deb o‘z fikrlarini bildirdi.  ", Comment = "Huquqbuzarliklar profilaktikasida insonparvarlik prinsipining mohiyati xususida o‘z fikringizni bildiring." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 4, Question = "Profilaktika inspektori E. xizmati davomida yosh bo‘lishiga qaramay huquqbuzarlik va boshqa g‘ayriijtimoiy xatti-harakatlar sodir etgan V.ning o‘tmishini o‘rganar uning anchadan beri nazoratsizligi hamda qarovsizligi ekanligi, hayoti yoki sog‘lig‘i uchun xavf tug‘diradigan vaziyatga (sharoitga) tushib qolganligini aniqladi. Profilaktika inspektori E. voyaga yetmagan shaxs V.ning ijtimoiy ahvolini tuzatish bo‘yicha vakolatli organlar bilan ishlashni boshladi.", Comment = " Ijtimoiy jihatdan xavfli ahvolda bo‘lgan voyaga yetmagan shaxs deyilganda nimalar tushuniladi?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 5, Question = "T ismli fuqaroning jazoni ijro etish muassasidan chiqqaniga 1 hafta bo‘ldi. U diniy-ekstremistik oqimga a’zoligi isbotlanib, sud tomonidan aybli deb topilgan edi. Odatdagidek, bunday fuqarolar profilaktika inspektorining profilaktik hisobida turadi va inspektor doimiy ravishda bunday fuqorolarni nazorat qilib borishi zarur. T ismli fuqaroni uyiga inspektor tashrif buyurdi va o‘zini tanishtirdi. T ismli fuqoro bilan suhbat jarayonida inspektor tushunib etdiki, fuqaro bilan ishlash judayam qiyin, u hali ham “tushunib etmagan”, diniy oqimga moyilligi yuqori.", Comment = " Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Fuqaro T. ga nisbatan qanday profilaktika turini o‘tkazish maqsadaga muvofiq?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 6, Question = "Har kuni informasion internet saytlarida yoshlar o‘rtasidagi jinoyatlar, pichoqbozlik, avtomobillarni o‘g‘irlash, bosqinchilik kabi xabarlarni ko‘rib kelyapmiz, bu yoshlarimizning ongiga salbiy ta’sir ko‘rsatishi turgan gap”, dedi “Birlik” MFY raisi. Yig‘ilishda ishtirok etganlarning barchasi “Birlik” MFY raisining fikrini qo‘llab-quvvatlashdi. ", Comment = "Yuqoridagi holat huquqbuzarliklar sodir etilishining qanday sababiga kiradi? Internet saytlaridagi xabarlar yoshlar psixologiyasiga qanday ta’sir etishi mumkin?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 7, Question = "Navoiyda 21 mart kuni Navoiyda 31 yoshli ayol 3 nafar qizi bilan birgalikda poezd ostiga o‘zini tashlagan edi. Bolalar yashab qoldi, ammo ona olamdan o‘tdi. Z.J.ning yaqin qarindoshlari bilan suhbatlashilganda, oilaviy sharoiti moddiy jihatdan o‘rtaholligi, biroq turmush o‘rtog‘i bilan munosabatlarida muammo bo‘lgani aniqlangan. U ruhiy jihatdan sog‘lom bo‘lgan. «So‘nggi vaqtlarda u bilan turmush o‘rtog‘i O.Ro‘ziev “Sen o‘g‘il farzand tug‘maysan“ deb janjallashib turgani sababli, uning ruhiyatida o‘zgarishlar bo‘lgan, lekin qolgan oila a’zolari yoki boshqa shaxslar bilan kelishmovchilikka bormagan», — deyiladi xabarda. ", Comment = "Muammoli masalani muhokama qiling, echimi yuzasidan batafsil tushunchangizni bayon qiling. Ayol kishining o‘zini o‘ldirishiga sabab mazmun mohiyatiga ko‘ra qanday turga kiradi? Hodisaga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 8, Question = "Toshkent shahar Chilonzor tuman 18 daha yashovchi fuqarolar kechki payt “Tungi kapalaklar” bozori ularning dam olishiga va oiladagi farzandlarining tarbiyasiga salbiy ta’sir qilayotganligidan nolib tuman IIBga murojaat qildi. IIO ushbu hududda “Oriyat” tadbirini o‘tkazishga qaror qildi. ", Comment = "“Oriyat”, “Qoradori” va “Antiterror” tadbirlari huquqbuzarliklar profilaktikasinig qaysi turiga mansub, bu haqida batafsil ma’lumot bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 9, Question = "Voyaga etmaganni ijtimoiy-huquqiy yordam ko‘rsatish markaziga joylashtirish bo‘yicha materiallarni tayyorlash ichki ishlar organlarining zimmasiga yuklatilganligini bilan qo‘shnilar voyaga etmagan qarovsiz R.ni ijtimoiy-huquqiy yordam ko‘rsatish markazlariga quyidagi voyaga etmaganlarning joylashtirilishi so‘rab murojaat qilishdi. Bundan xabar topgan R.ning yaqinlari qo‘shnilardan birovning ishiga aralashmasliklarini aytib janjallashishdi. ", Comment = "Ijtimoiy-huquqiy yordam ko‘rsatish markaziga joylashtirish uchun nimalar asos bo‘ladi? Ijtimoiy-huquqiy yordam ko‘rsatish markazlari bo‘yicha ma’lumot bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 10, Question = "Huquqbuzarliklar profilaktikasini tasniflashda turli mualliflar har xil mezonlarga, kimdir – subyektning o‘ziga xos xususiyatlariga, kimdir – profilaktikani amalga oshirish usullarining o‘ziga xos xususiyatlariga, kimdir – profilaktika chora-tadbirlarini huquq normalari bilan tartibga solishga, yana kimdir (ular ko‘pchilikni tashkil etadi) – profilaktika chora-tadbirlarining xususiyatiga asoslanadi. ", Comment = " Shunga ko‘ra, viktimologiya tushunchasini ta’riflang va javobingizni O‘zbekiston Respublikasi qonunchiligi asosida tahlil qilib yoritib bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 11, Question = "G‘ayriijtimoiy hatti-harakati uchun profilaktika inspektori va mahalla raisi tomonidan bir necha bora ogohlantirilgan fuqaro T yana o‘zining “xurmacha qiliq”larini boshladi. Bu safar u spirtli ichimlik ta’sirida ko‘p qavatli uy hovlisida hammani ommaviy so‘kib chiqish bilan kifoyalandi. ", Comment = " Fuqaro T ga nisbatan qanday usulda chora qo‘llash mumkin? Huquqbuzarliklarning umumiy tartibdagi profilaktikasining usullariga ta’rif bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 12, Question = "Kitob tumanida yashovchi fuqaro N. g‘ayriijtimoiy xulq-atvorga xos bo‘lgan barcha xislatlarni o‘zida jam qilgan, jumladan u fuqaro A. bilan qonuniy nikohsiz er-xotin bo‘lib, ko‘p qavatli uylarda yashab, baland ovozda musiqa eshitib, qo‘shnilarning tinchini buzib kelashdi. Shuningdek, ular oilada nizoli va janjalli vaziyatlarni yuzaga keltirib, spirtli ichimlikka ruju qo‘yishgan. Ichki ishlar organlari tomonidan bir necha bora jamoat joylarida spirtli ichimlik iste’mol qilganligi uchun ogohlantirilishiga qaramay, bunday odatlarini tashlamagan.  ", Comment = "G‘ayriijtimoiy xulq-atvor borasida muammoli masalani muhokama qiling, echimi yuzasidan batafsil tushunchangizni bayon qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 13, Question = "“Smart” universitetining bir guruh talablari o‘zlarining stipendiyasini ko‘tarish masalasini o‘zaro guruh a’zolari ishtirokida muhokama qilishdi. Talabalar muhokama jarayonida olingan videolavhani “Instagram” ijtimoiy tarmog‘ida #stipendiyanibirgalikdako‘taramiz xeshtegi orqali joylashtirishdi. Mazkur xeshteg talabalar o‘rtasida ommalashib natijada Bunyodkor stadioniga 1500 nafarga yaqin talabalar yig‘ilishib o‘zlarining oylik stependiyalarini ko‘tarish bo‘yicha namoyish o‘tkazishishdi. Ichki ishlar organlari xodimlari tomonidan talabalarga masalani bunday yo‘l bilan hal qilib bo‘lmasligi tushuntirilib darhol hamma talaba tarqalishi zarurligi ta’kidlandi. IIO xodimlarining tushuntirilari bo‘yicha talabalar tomonidan namoyishni to‘xtatish hamda tarqalish yuzasidan amaliy harakatlar bajarilmaganidan keyin, talabalar to‘plangan joyga tezkor guruh, patrul post naryadlari chaqirtilib talabalar namoyishi majburiy tartibda tarqatildi. ", Comment = "Ommaviy tadbirlarni tashkil etish tartibi hamda ushbu jarayonda ichki ishlar organlari xodimlari tomonidan jamoat tartibi va xavfsizligini ta’minlash faoliyati hamda ruxsat etilmagan ommaviy tadbirlar tashkil etilganda ichki ishlar organlari tomonidan qanday chora-tadbirlar amalga oshiririlishi yuzasidan batavsil tushuntirish bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 14, Question = "Mirobod tumanida joylashgan “Tong” restoraniga kechki soat 21:00da Patrul xizmati xodimlari kelib, bayram arafasida jamoat tartibini saqlash va yong‘in xavfsizligini ta’minlash hamda favqulodda vaziyatlarni bartaraf etish bo‘yicha turli muassasalar xodimlari tegishli tashkiliy-profilaktik ishlarni amalga oshirayotganini ta’kidlab restoranni ish faoliyatini ertaroq yakunlash talabini qo‘yishdi. Restoran rahbariyati tomonidan hali ish vaqti tugamaganligi vaj qilinib ish vaqti tungi soat 01:00 gacha ekanligi, belgilangan vaqtda o‘zlari restoranni yopishlarini ta’kidlashdi.", Comment = " Patrul-post xizmati xodimlarini jamoat tartibi va xavfsizligini ta’minlash faoliyatini batafsil yoriting." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 15, Question = "“Gulzor” MFY profilaktika inspektoriga MFY hududida joylashgan “Sher” kafesi yonida noma’lum shaxs erga yuztuban holatda yotgani to‘g‘risida xabar berildi. Kafe yonida yotgan fuqaroni shaxsini aniqlashtirish imkoni bo‘lmaganidan keyin, Reabilitasiya markaziga olib borib topshirildi. ", Comment = "Muayyan yashash joyiga ega bo‘lmagan fuqarolarni reabilitasiya qilish tartibini tushuntirib bering. Shuningdek, mazkur masalani yoritishda xorijiy tajribadan foydalaning." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 16, Question = "Ichki ishlar vazirligi ishonch telefoni orqali joriy yilning 15 noyabrida Toshkent shahri markazida joylashgan “Turkiston” san’at saroyida bir guruh shaxslar tomonidan qo‘poruvchilik harakati sodir etilishi to‘g‘risidagi ma’lumotlar aks ettirilgan anonim xabar kelib tushdi. ", Comment = " Mazkur vaziyatda Ichki ishlar organlari tomonidan qanday chora-tadbirlar amalga oshiriladi. Favqulotda vaziyatlarda ichki ishlar organlari tomonidan jamoat tartibi va xavfsizligini ta’minlash faoliyatini amaliy misollar oryoqali yoriting." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 17, Question = "JK 97-moddasida nazarda tutilgan jinoyatni sodir etilishda ayblanayotgan fuqaro S.Baxromov vaqtincha saqlash hibsxonasidan sud majlisiga olib borilayotganda, avtotransportdan qochishga urinadi, konvoy xizmati xodimlarining ogohlantirishiga qaramasdan harakatlanishda davom etadi. Konvoy xizmati xodimi serjant G.Nurmonov ayblanuvchigi qarata bir marotaba o‘q uzadi. O‘q ayblanuvchining o‘ng ko‘krak sohasiga tegadi va ayblanuvchi olgan tan jaroxati natijasida voqea joyida vafot etadi. ", Comment = "Vaziyatga huquqiy baho bering. Ichki ishlar organlari tomonidan konvoy xizmatini tashkil etish faoliyatini batafsil tushuntiring." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 18, Question = "Toshkent davlat yuridik universiteti “Xalqaro xususiy huquq” kafedrasi o‘qituvchisi M.Turdaliev “Xalqaro xususiy huquqda Gaaga konferensiyasining o‘rni” mavzusidagi xalqaro ilmiy amaliy konferensiya o‘tkazishni rejalashtirdi. Mazkur konferensiyaga bir nechta xorijiy davlatdan mexmonlar shuningdek Gaaga konferensiyasi Bosh kotibi Kristof Bernaskoni taklif etildi konferensiya o‘tkazilish joyi sifatida Toshkent shahri markazidagi Mustaqillik maydoni tanlanib tegishli ruxsat olish uchun Toshkent shahar hokimiyatiga ariza bilan murojaat qilindi hamda tashkilotchi tomonidan tadbirga qatnashish uchun chiqarilgan taklifnomalar ishtirokchilarga tarqatildi. ", Comment = "Vaziyatga huquqiy baxo bering; Yuqoridagi vaziyatdan kelib chiqib ommaviy tadbirlarni tashkillashtirish uchun tegishli ruxsatnoma olish tartibini tushuntiring." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 19, Question = "Chirchiq shahar IIOFMB huzuridagi Tergov bo‘limi tomonidan A.Temur ko‘chasida joylashgan hiyobon qarshisida bir guruh shaxslar tomonidan diniy tusdagi ommaviy tadbir tashkillashtirilib, aholining turli ijtimoiy qatlamidan iborat jami 156 nafar fuqaro ushbu tadbirga jalb etilganligi aniqlangan. Ushbu ommaviy tadbirda shaxsi noma’lum fuqarolar o‘zlarining kayfiyatlarini amaldagi siyosiy vaziyatga qarshi yunaltirib, konstitusiyaviy tuzumga qarshiliklarini ochiq oydin bayon qilishdi. ", Comment = "Vaziyatga huquqiy baho bering; Ommaviy tadbirlarni o‘tkazish tartibi hamda shartlarini batafsil bayon qiling; Bu turdagi tadbirlarni ommaviy tadbir deb hisoblash mumkinmi? Mazkur vaziyatda jamoat tartibi va xavfsizligini ta’minlash maqsadida ichki ishlar organlari hamda boshqa hamkor tashkilotlar tomonidan qanday chora-tadbirlar amalga oshirilishini amaliy misollar yordamida tushuntiring." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 20, Question = "Tungi soat 23:45da “Bo‘ston” MFY hududida “Jazira” kafesi oldida to‘rt nafar tashqi ko‘rinishidan yoshi 15-16 yoshlar orasidagi qizlar hamda ikki nafar yigit tomonidan baland ovozda qo‘shiq qo‘yib raqsga tushayotganligi o‘sha xududda yashovchi fuqarolorning g‘ashini keltiradi. Fuqarolar A.Sanaev va B.Xamraevlarning tanbexiga javoban ular do‘stini tug‘ilgan kunini nishonlashayotganligini aytib o‘yin-kulguni davom ettirishdi. Natijada fuqarolar 102 qisqa raqami orqali vaziyat to‘g‘risida ichki ishlar organlariga xabar berishdi.", Comment = " Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 21, Question = "Toshkent davlat yuridik universitetining Ixtisoslashtirilgan filiali tomonidan “Jamoat tartibi va xavfsizligini ta’minlash shuningdek huquqbuzarliklar profilaktikasida davlat idoralarining ishtiroki” mavzusidagi davra suhbati tashkillashtirilib keng jamoatchilik, OAV vakillari hamda soha mutaxassislari taklif etildi. Davra suhbatida professor Ketmonov Jamoat tartibi hamda huquqbuzarliklar profilaktikasi faqatgina ichki ishlar organlarining asosiy vazifalari ekanligini aytdi. Boshq bir amaliyotchi mutaxassis Shodmonov esa mazkur vazifalar ichki ishlar organlari hamda Milliy gvardiyaning birgalikdagi vazifasi ekanligini takidladi. Yuridik fanlar doktori Vaxobov esa jamoat tartibi va xavfsizligini ta’minlash faoliyati Ichki ishlar organlari, Milliy gvardiya hamda boshqa HMQO organlarining asosiy vazifalari ekanligini aytadi. Yuqoridagi vaziyatdagi har bir davra suhbati qatnashchilari tomonidan aytilgan fiklarga o‘z munosabatingizni hamda alohida shaxsiy pozisiyangizni bildiring.", Comment = " Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 22, Question = "Yunusobod tuman “Mustaqillik” MFY hududida o‘z xizmat vazifasini patrullik naryadi shaklida olib borayotgan Yunusobod tumani Milliy gvardiya bo‘limi xodimi katta leytenanti S.Mamatov, kichik serjant M.Toirov hamda safdor G.Tojievlarni bir guruh fuqarolar to‘xtatib, ularning ust boshlari kirligi kiyimlarini rangi o‘chib ketganligi hamda ximoya niqobini taqmaganligi uchun koyishdi. Bu gapdan jahli chiqqan Milliy gvardiya xodimlari ushbu fuqarolarni majburlab xizmat mashinasiga tiqib Milliy gvardiya binosiga olib borishdi.", Comment = " Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 23, Question = "Buxoro viloyati Jondor tumani fuqarolari tomonidan Navruz saylgohida tabiiy gaz tanqisligi bo‘yicha tegishli ruxsat olinib miting tashkillashtirildi. Miting ishtirokchilaridan biri fuqaro T.Samadov o‘zining “Kichkintoy Boggi” laqabli iti bilan sayilgoh hududiga kirmoqchi bo‘ldi. Ichki ishlar organlari xodimlari tomonidan sayilgoh hududiga jonivorlar bilan kirish mumkin emasligi aytadi. Fuqaro T.Samadov IIO xodimlariga e’tiroz bildirib ruxsatnoma reeytrining elektron variantida xayvonlar bilan ommaviy tadbirga kirish mumkin ekanligi qayd etilganligini takidlaydi. IIO xodimlari miting tashkilotchisini chaqirib kelishadi. Tadbir tashkilotchisi ruxsatnoma reeystirining qog‘oz variantini ko‘rsatib unda tadbirga xayvonlar bilan kirish taqiqlanganligini aytadi. Natijada ikki o‘rtada tushunmovchilik yuzaga keladi.  ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 24, Question = "Milliy gvardiya xodimi L.Tojievni o‘zining to‘g‘ridan to‘g‘ri rahbari hisoblangan polkovnik I.Asadov xonasiga chaqirib qo‘liga pul tutqazdi hamda do‘konga borib to‘rt kilogram go‘sht hamda ichimliklar sotib olib uyiga olib borib berishini shuningdek uyiga tashrif buyurishi kerak bo‘lgan mexmonlarni keldi ketdisiga qarab turishini buyurdi. Mazkur topshiriqdan jahli chiqqan L.Tojiev labini tishlagancha rahbari aytgan topshiriqni bajarishga kirishib ketdi. ", Comment = "Mazkur holatda siz o‘zingiz Milliy gvardiya xodimi L.Tojievni o‘rnida bo‘lganingizda qanday harakatlarni amalga oshirgan bo‘lar edingiz?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 25, Question = "Yashnobod tumani IIOFMB huzuridagi tergov bo‘limi tergovchisi katta leytenant S.Aliev “Instagram” ijtimoiy tarmog‘i orqali jonli efir qiladi. Efir vaqtida bir nechta kuzatuvchilar tomonidan Alievning shaxsiyatiga tegadigan gaplar aytiladi. Aliev ko‘zatuvchilarga turli xildagi haqoratomuz so‘zlar bilan javob qaytaradi. Kuzatuvchilar ushbu jonli efirdan Aliev tomonidan aytilgan haqoratlarni mavjud lavhani ijtioiy tarmoqlar orqali tarqatadi. Shuningdek, yana bitta nusxani Yashnobod tumani IIOFMBga taqdim etadi.", Comment = " Vaziyatga nisbatan o‘z shaxsiy munosabatingizni tegishli normativ xujjatlardan foydalangan holda bildiring." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 26, Question = "Milliy gvardiyaning to‘rt nafar xodimi o‘z naryad joyini tashlab kafeda alkogol mahsulotini iste’mol qilayotgani xizmat o‘tash joyidagi o‘z xavfsizligi bo‘linmasi xodimlari tomonidan aniqlanib ularning hammasiga egallab turgan lavozimidan ozod etish to‘g‘risida intizomiy jazo chorasi bitta buyruq bilan rasmiylashtiriladi. Ikki nafar milliy gvardiya xodimi alkogol iste’mol qilmaganini aytib intizomiy jazo chorasi qo‘llash haqidagi buyruqdan norozi bo‘lib prokuraturaga shikoyat qiladi. ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 27, Question = "Toshkent viloyati Olmaliq shahridagi Olmaliq kon metallurgiya kombinati ishchilari sentyabr oyi uchun vada qilingan qo‘shimcha pul mukofotlarini olishmadi. Shuning uchun zavodning to‘qson nafar atrofidagi ishchilari 3 sentabrda OKMK boshqarmasi oldidagi mashina yo‘lini to‘sib, tirbandlik hosil qilishdi. ", Comment = "Vaziyatga huquqiy baho bering; Ishchilarning ko‘cha harakatlari asosli yoki asossiz ekanligini muhokama qiling. Mas’ul idoralar tomonidan ko‘cha harakatlari sodir etilganda qanday chora-tadbilar amalga oshiriladi?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 28, Question = "2021-yil 7-may kuni Toshkent shahar Yunusobod tumani 42-sonli umumiy o‘rta ta’lim maktabida 9-may “Xotira va qadrlash kuni” ga atab tuman maktablari órtasida sport musobaqalari ótkazildi. Sport musobaqalariga tuman maktab o‘quvchilari hamda sport o‘qituvchilari tashrif buyurishdi. Tadbirni o‘tkazish jarayonida 7-sonli umumiy o‘rta ta’lim maktabi 11-sinf o‘quvchilari A.D, D.T, U.I, ismli shaxslar.23-sonli umumiy o‘rta ta’lim maktab 9-sinf o‘quvchilari S.A va F.A ismli shaxslar bilan asosiz ravishda ularning yoniga borib zulm o‘tkazmoqchi bo‘lishadi. Bu holatni ko‘rgan 23-sonli maktab 9-,10-sinf o‘quvchilari kelib A.D, D.T, U.I bilan janjallashib ketishadi. Natijada ommaviy mushtlashishga sodir bo‘ladi. Bu holatni ko‘rib mushtlashishni to‘xtatishga kelgan A.R ismli shaxmat treniri jarohat oladi. Maktab direktori tuman ichki ishlar bólimiga xabar beradi. ", Comment = "Vaziyatga huquiy baho bering. Taraflarning harakatlarini tahlil qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 29, Question = "Bunyodkor va Lokomotiv jamoalari o‘rtasida O‘zbekiston Kubogi uchun o‘yin Bunyodkor stadionida bo‘lib o‘tayotgan vaqtda o‘yinni mingdan ziyod muxlislar tomosha qilayotgan edi. O‘yin tugab, g‘olib aniqlangandan so‘ng bir guruh san’atkorlar tomonidan madaniy-ma’naviy tadbir o‘tkazildi. Tadbir vaqtda muxlislar tomonidan maydonga tushib ommaviy tartibsizlik harakatlari sodir etildi. ", Comment = "Mazkur ommaviy tartibsizlikka qanday tartibda va qanday harakatlarni amalga oshirish bilan barham berish mumkin. Ushbu ommaviy tadbirni xavfsizligini ta’minlash qaysi organlarga yuklatiladi. Vaziyatga huquqiy baho bering. " });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 30, Question = "Fuqaro R.R va fuqaro P.P alkagol mahsulotlarni sotish uchun mo‘ljallangan magazindan spirtli ichimliklar sotib olishdi. So‘ngra Paxtakor markaziy stadioniga borib u erda futbol tomosha qilish bilan birgalikda spirtli ichimlik istemol qilishdi. Fuqaro P.P alkogol mahsulotlari tasiriga tushib qolib, futbolchilarni va hakamni baland ovozda haqorat qilishi raqib jamoa tomoshabinlari bilan tartibsizlik va mojaro kelib chiqishiga sabab bo‘ldi. Tartibsizlikka barham berish uchun IIO va Milliy Gvardiya hodimlari maxsus vositalardan foydalanishdi. ", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 31, Question = "O‘zbekiston Respublikasi Konstitutsiyasining qabul qilinishiga bag‘ishlangan davra suhbatida Konstitutsiyaning predmeti kim ekanligi haqida bahs yuzaga keldi. Birinchi guruh vakillarining fikricha, Konstitutsiya oliy qonun hujjati bo‘lganligi tufayli uning sub’ekti parlament hisoblanadi, Konstitutsiyaga o‘zgartirish va qo‘shimchalar O‘zbekiston Respublikasi Oliy Majlisi tomonidan amalga oshiriladi, binobarin, Konstitutsiyaning sub’ekti albatta parlament hisoblanadi. Ikkinchi guruh Konstitutsiya normativ hujjat bo‘lishi bilan birga ijtimoiy-siyosiy hujjat hamdir, bundan tashqari, u qabul qilinishidan oldin bir necha marotaba xalq muhokamasiga taqdim etilgan va shuning uchun ham O‘zbek xalqi Konstitutsiyaning sub’ekti degan fikrni ilgari surdi. Muhokama davomida tomonlar o‘z nuqtai nazarlarini Konstitutsiyaning o‘ziga xos xususiyatlaridan kelib chiqib isbotlashga harakat qildilar. ", Comment = "O‘zbekiston Respublikasi Konstitutsiyasini yaratish jarayonini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 32, Question = "Mo‘ynoq tumani maishiy xizmat ko‘rsatish kasb-hunar kolleji o‘quvchilari o‘rtasida futbol musobaqasi o‘tkazildi. Musobaqa boshlanishi davomida ushbu tadbirda O‘zbekiston Respublikasi va Qoraqalpog‘iston Respublikasi bayroqlari ko‘tarib chiqildi. Lekin O‘zbekiston Respublikasi davlat bayrog‘ining hajmi Qoraqalpog‘iston Respublikasi bayrog‘idan ancha kichik edi. Kollej rahbari musobaqa boshlanishiga oz vaqt qolganida bu haqida xabar topganligi uchun bu kamchilikni to‘g‘irlay olmadi. Natijada turli o‘lchamdagi milliy bayroqlar ko‘tarildi. Bu holatni o‘rgangach, huquq-tartibot xodimlari kollej direktorini “Milliy bayroq to‘g‘risida”gi qonunni buzganlikda aybladi. Kollej direktori esa tanlov tashkilotchilari, ya’ni - tuman hokimligini aybladi. ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 33, Question = "O‘zbekiston Respublikasi fuqarosi S. Avazova Qirg‘iziston fuqarosi bo‘lgan 17 yoshli A. Samedovni farzandlikka olishga qaror qildi. Uning Qirg‘iziston fuqaroligidan chiqib va O‘zbekiston Respublikasi fuqaroligini olish jarayoni qiyin kechdi. Bir oydan keyin A. Samedov Qirg‘iziston fuqaroligidan voz kechdi. Lekin, O‘zbekiston Respublikasi qonunchiligiga ko‘ra, O‘zbekiston Respublikasi fuqaroligini olish uchun u mamlakatda oxirgi besh yil davomida doimiy yashagan bo‘lishi kerak. Ammo fuqaro S. Avazova farzandlikka olish to‘g‘risida vasiylik va homiylik organiga murojaat qilgan paytdan boshlab O‘zbekiston Respublikasi fuqaroligini olish mumkiniligi, farzanlikka olish to‘g‘risidagi hujjatlar rasmiylashtirilganligidan keyin fuqarolikni olish tartibi boshqacha tarzda amalga oshirilishi zarurligini ta’kidladi. ", Comment = "Vaziyatni O‘zbekiston Respublikasi Konstitutsiyasi va konstitsiyaviy qonun normalari asosida tahlil qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 34, Question = "Turkmaniston Respublikasi fuqarosi K.Avezov Xorazm viloyati Xonqa tumani IIB boshlig‘i A.Ochilbekovga O‘zbekiston Respublikasi fuqaroligini qabul qilishni so‘rab murojaat qiladi. Fuqaro o‘z murojaatida O‘zbekiston Respublikasida tug‘ilganligini, uning ota-onasi va yaqin qarindoshlari O‘zbekiston Respublikasi fuqarosi bo‘lib, shu yerda yashashligini asos qilib keltirgan. Shuningdek, “O‘zbekiston Respublikasining fuqaroligi to‘g‘risida”gi qonunining 17-moddasi ikkinchi qismi 2-bandi ikkinchi xatboshiga muvofiq, fuqarolikka qabul qilish shartlari ushbu shaxsga taalluqli emasligini qayd etdi. Xorazm viloyati Xonqa tumani IIB boshlig‘i A.Ochilbekov boshlig‘i esa ushbu murojaatni rad etdi. ", Comment = "Vaziyatga huquqiy baho bering. O‘zbekiston Respublikasi fuqaroligini qabul qilish tartibini muhokama qiling. " });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 35, Question = "Toshkent shahar Adliya boshqarmasida davlat ro‘yhatidan o‘tgan “Buloq” nodavlat notijorat tashkiloti aholini toza ichimlik suvi bilan ta’minlash sohasidagi qonuniy huquq va manfaatlarini himoya qilish maqsadida tuzilgan. Mazkur nodavlat notijorat tashkilot bir necha bor davlat tomonidan qo‘llab-quvvatlanishga erishish maqsadida nodavlat notijorat tashkilotlar va fuqarolik jamiyatining boshqa institutlarini qo‘llab-quvvatlash jamoat fondi mablag‘larini boshqarish bo‘yicha Parlament komissiyasiga hujjatlar topshirgan. Biroq, har doimgidek Parlament komissiyasi mazkur tashkilotga mablag‘ ajratish masalasida rad javobi berib keladi. Davlat granti olish bo‘yicha berilgan oxirgi murojaat ham ijobiy hal bo‘lmagandan keyin “Buloq” nodavlat notijorat tashkiloti a’zolari umumiy yig‘ilish chaqirish hamda yig‘ilish kun tartibiga tashkilotni ixtiyoriy tugatish haqida masalasini kiritish taklifini ilgari surishdi. ", Comment = "Vaziyatga huquqiy baho bering. O‘zbekiston Respublikasi Konstitutsiyasining 58-moddasi mazmun-mohiyatini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 36, Question = "Fuqaro Smirnov “Istiqbol” xususiy firmasiga menedjer lavozimiga ishga kirish uchun ariza yozdi. “Ictiqbol” xususiy firmasining rahbari Atavullaev Smirnovning davlat tili – o‘zbek tilini bilmasligini asos qilib, u bilan 3 oylik sinov muddati vaqtida, firmada tashkil qilingan to‘lov asosida o‘zbek tilini o‘rgatadigan kursda o‘qishini va o‘zbek tilini o‘rganganidan so‘ng ishga olishini mumkinligini aytdi. Bu vaziyatdan norozi bo‘lgan Smirnov O‘zbekiston Respublikasi Konstitutsiyasi bo‘yicha uning mehnat qilish huquqlari poymol bo‘lganligini vaj qilib prokuratura organiga murojaat qildi. ", Comment = "Vaziyatga huquqiy baho bering. O‘zbekiston Respublikasi Davlat tilining huquqiy maqomini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 37, Question = "Mahalla Fuqarolar Yig‘ini raisiga hududda joylashgan Bog‘ishamol avtomobil korxonasi mahalla hududini ifloslantirayotgani, ko‘p miqdorda axlat tashlayotgani va korxonaning og‘ir yuk mashinalari serqatnov bo‘lganligi sababli mahalla ko‘chalarining asfalt qoplamasini yaroqsiz holga keltirayotgani to‘g‘risida jamoaviy shikoyat kelib tushdi. Biroq Mahalla Fuqarolar Yig‘ini raisi og‘zaki tarzda bu davlat korxonasi ekanligini nazarda tutib, chora ko‘rishdan bosh tortdi. ", Comment = "Ushbu holatda Mahalla Fuqarolar Yig‘ini raisi amaldagi qonunchilikka muvofiq qanday vakolatlarga ega ekanligini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 38, Question = "Qoraqalpog‘iston Respublikasi Jo‘qorg‘i Kengesi To‘rtko‘l tumani nomini o‘zgartirish to‘g‘risida qaror qabul qildi. O‘zbekiston Respublikasi hukumati ushbu harakat O‘zbekiston Respublikasi hukumatining roziligisiz amalga oshirilganligini asos mqilib o‘z noroziligiga ifodaladi. Qoraqalpog‘iston Respublikasi Jo‘qorg‘i Kengesi tuman, shahar, shaharcha, qishloq, qishloq nomlari va ularni o‘zgartirish Qoraqalpog‘iston Respublikasi Jo‘qorg‘i Kengesi tomonidan amaldagi qonun normalari asosida amalga oshirilishi mumkin ekanligini, e’tirozga javob sifatida qaytardi. Qoraqalpog‘iston Respublikasi hududida joylashgan shahar, shaharcha, qishloq nomlarini o‘zgartirish va shu kabi masalalarni ko‘rib chiqish Qoraqolpog‘iston Respublikasi Vazirlar Kengashining vakolatlariga kirishi ta’kidlandi.  ", Comment = "Qoraqalpog‘iston Respublikasi hukumati harakatlari amaldagi Qonunchilik nuqtai nazaridan qonuniy ekanligini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 39, Question = "Faraz qiling, saylovlarda qatnashayotgan “R” Siyosiy partiya parlamentga bo‘lib o‘tadigan saylovlarda muvaffaqiyatli qatnashish maqsadida o‘zi bilan uzoq muddatli hamkorlik shartnomasi asosida faoliyat olib borayotgan xalqaro tashkilotdan hamda siyosiy platformasida aks ettirilgan g‘oya va maqsadlariga xayrixoh bo‘lgan chet el fuqarosidan ko‘p miqdorda chet el valyutasidagi xayriya yordamini oldi. Olingan mablag‘lar hisobidan siyosiy partiya nomzodlar bilan uchrashuvlarni tashkil etdi, uchrashuvlarga kelgan fuqarolarga o‘z hisobidan dasturxon tashkil etdi, esdalik sovg‘alarini hadya qildi. Mahalliy davlat hokimiyati organlari va bank-moliya idoralari tomonidan taqdim etilgan ma’lumotlar asosida Markaziy saylov komissiyasi partiyani saylov jarayonida ishtirok etishdan chetlatdi. Siyosiy partiyaning faollaridan biri mazkur qarordan norozi bo‘lib Konstitutsiyaviy sudga shikoyat arizasi bilan murojaat qildi.  ", Comment = "Vaziyatga huquqiy baho bering. Siyosiy partiyalarni moliyalashtirish tartibi va shartlarini qonun hujjatlari asosida aniqlang" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 40, Question = "Bir guruh deputatlar tomonidan O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasiga yangi qonun loyihasini taqdim etdilar. Qonun loyihasida Oliy Majlis Qonunchilik palatasining reglamentiga o‘zgartirishlar kiritish nazarda tutilgan bo‘lib, unga ko‘ra Qonunchilik palatasi Kengashiga yangi qo‘mitalar tuzish, vaqtinchalik komissiyalar tuzish huquqi berilgan, Qonunchilik palatasining qo‘mitalari esa Qonunchilik palatasi nomidan muayyan masalalar bo‘yicha qarorlar qabul qilish huquqiga ega edi. Qonun loyihasi tashabbuskorlarining fikricha, ushbu amaliyot xorijiy mamlakatlar parlamentlarida keng tarqalgan bo‘lib, quyi palata faoliyatini optimallashtirish va samaradorligini oshirishga xizmat qiladi. ", Comment = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasining tarkibiy bo‘linmalarini shakllantirish tartibi, ularning vakolatlari va faoliyat yo‘nalishlarini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 41, Question = "Yaponiya parlamenti va O‘zbekiston Respublikasi Oliy Majlisining Qonunchilik palatasi o‘rtasida qonun ijodkorligi sohasida tajriba almashishni ko‘zda tutuvchi ikki tomonlama aloqalarni mustahkamlash to‘g‘risida parlamentlararo bitim imzolandi, shu munosabat bilan Qonunchilik palatasi deputatlari va Yaponiya parlamenti a’zolari orasidan parlamentlararo guruh tuzildi. Senat tashqi ishlar vazirligi ushbu hamkorlik to‘g‘risida ma’lumot olib, keng jamoatchilikni ushbu fakt haqida xabardor qilish uchun matbuot anjumani tashkil qildi va ushbu parlamentlararo guruhga bir nechta senator ham kiritilishini va ulardan biri unga rahbarlik qilishini e’lon qildi. ", Comment = "Parlamentlar o‘rtasida hamkorlik to‘g‘risidagi bitimlar qanday tuziladi? saylangan xalq vakillarining xalqaro miqyosdagi faoliyati to‘g‘risida mamlakat aholisining ma’lumotlar berish va saylovchilarni xabardor qilish qanday tartibda amalga oshiriladi? Senat harakatlariga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 42, Question = "O‘zbekiston Respublikasi Oliy Majlisining Qonunchilik palatasiga kelib tushgan qonun loyihasi uch o‘qishda qabul qilinib, ma’qullash uchun O‘zbekiston Respublikasi Oliy Majlisining Senatiga yuborildi. Biroq, qonun Senat tomonidan rad etilib,Qonunchilik palatasiga qaytarildi. Senat tomonidan rad etilgan qonun qayta ko‘rib chiqilib, Qonunchilik palatasi deputatlar umumiy sonining uchdan ikki qismidan iborat ko‘pchilik ovozi bilan yana ma’qullandi hamda Senatga yuborildi. ", Comment = "Vaziyatga huquqiy baho bering. Qonun qabul qilish tartibi jarayonini normativ-huquqiy hujjatlar asosida tahlil qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 43, Question = "Qonunchilik palatasi tomonidan O‘zbekiston Respublikasining “Parlament nazorati to‘g‘risida”gi qonun loyihasi uchinchi o‘qishda qabul qilinganidan keyin va Oliy Majlis Senati tomonidan ma’qullangandan so‘ng, qonun loyihasi imzolash uchun O‘zbekiston Respublikasi Prezidentiga yuborildi. Biroq, davlat rahbari qonunni imzolamadi va e’tirozlar bilan qaytarib berdi. Bunday holda, Oliy Majlis palatalari dastlabki qabul qilingan holatda qonunni takroriy ovoz berishga qo‘yishi yoki davlat rahbarining e’tirozlarini inobatga olib, uni qayta qabul qilishlari shart edi. Parlament palatalari birinchi variantni afzal ko‘rishdi. Oliy Majlis Qonunchilik palatasi va Senatining a’zolari umumiy sonning ¾ miqdorida ovoz berish orqali qonun qabul qilindi, ya’ni Prezidentning vetosi chetlab o‘tildi. Biroq, davlat rahbari qayta ovoz berish tartibi qo‘pol ravishda buzilganligini ta’kidlab, Qonunga imzo chekmadi. ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 44, Question = "O‘zbekiston Respublikasi Bosh vaziri va O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi o‘rtasida qat’iy ziddiyatlar paydo bo‘lgani tufayli O‘zbekiston Respublikasi Prezidentiga ishonchsizlik votumi berish to‘g‘risida rasmiy taklif kiritildi. Qonunchilik palatasi deputatlari umumiy sonining kamida uchdan bir qismi miqdori ishtirokida davlat rahbari ushbu taklifni ko‘rib chiqib, uni Oliy Majlis palatalarining qo‘shma majlisi muhokamasiga taqdim etdi va parlament palatalari Bosh vazirga ishonch bildirmadi. Natijada O‘zbekiston Respublikasi Vazirlar Mahkamasi iste’foga chiqdi. Biroq, Vazirlar Mahkamasining iste’fosi davlat hokimiyati organlari raislariga, xususan, ijro etuvchi hokimiyatning ajralmas qismlari hisoblangan va ierarxik ravishda Vazirlar Mahkamasiga bo‘ysunadigan qo‘mitalar, idoralar, komissiyalar va markazlarga ta’sir qilmadi va ular o‘z joylarida qoldi. ", Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 45, Question = "“Staples” MChJ o‘z reklamasida O‘zbekiston Respublikasi gerbi tasviri va davlat madhiyasidan foydalanish uchun O‘zbekiston Respublikasi Oliy Majlisi Senatidan ruxsat oldilar. Toshkent shahar hokimining o‘rinbosari Senatga “O‘zbekiston Respublikasining Davlat bayrog‘i to‘g‘risida” gi va “O‘zbekiston Respublikasining Davlat madhiyasi to‘g‘risida” gi O‘zbekiston Respublikasi qonunlari buzilganligi to‘g‘risida taqdimnoma kiritdi va davlat ramzlari bo‘lmish gerb va bayroqdan tijorat faoliyatida foydalanish mumkin emasligini ta’kidladi. Shu bilan birga, “Staples” MChJ va Senat vakillariga nisbatan O‘zbekiston Respublikasi madhiyasi musiqasiga mualliflik huquqini himoya qilish bo‘yicha fuqarolik ishi qo‘zg‘atildi.", Comment = "  Ushbu vaziyatni Konstitutsiyaviy huquq normalari asosida tahlil qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 46,
                Question = @"Toshkentning 2200 yilligini nishonlash chog‘ida shahar markaziga kirish cheklandi. Fuqaro F.Burov fuqarolik ishlari bo‘yicha Mirzo Ulug‘bek tuman sudiga Mustaqillik ko‘chasi 13-uyda ijara shartnomasi bo‘yicha ijaraga olgan xonadonga kirishiga to‘sqinlik qilinganligi uchun huquqni muhofaza qilish organlari xodimlarining xatti-harakatlari ustidan shikoyat bilan murojaat qildi. Shikoyatda ko‘rsatilgan e’tirozlarga javoban, O‘zbekiston Ichki Ishlar Vazirligi tomonidan O‘zbekiston Vazirlar Mahkamasining `Ommaviy tadbirlarni tashkil etish va o‘tkazish tartibini yanada takomillashtirish chora-tadbirlari to‘g‘risida`gi Qaroriga muvofiq ushbu organga transport vositalari va fuqarolarning ayrim hudud va ob’ektlarga kirishiga yo‘l qo‘ymaslik huquqi berilganligini ta’kidladi.Shuningdek, O‘zbekiston Respublikasi Konstitutsiyasining 28 - moddasiga muvofiq, inson va fuqaro huquqlari hamda erkinliklarini cheklash davlat xavfsizligini ta’minlash maqsadida qonunda belgilangan tartibda amalga oshirilishi mumkin.Fuqaro F.Burov bunday xulosani asossiz deb hisoblab, Konstitutsiyaning 28 - moddasida,
                shuningdek,2 - moddasida: `davlat xalq irodasini ifoda etadi, uning manfaatlariga xizmat qiladi. Davlat organlari va mansabdor shaxslar jamiyat va fuqarolar uchun mas’uldirlar`,
                shuning uchun davlatning xavfsizlik masalalari fuqarolarning huquqlari va erkinliklarini cheklashlikka yo‘l qo‘yish noqonuniy ekanligini iddao qildi. ",
                Comment = "Vaziyat qanday hal qilinishi kerak ? "
            });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 47, Question = "Direktorning buyrug‘i bilan “Nur” nomli jamoat tashkilotida jamoat Kengashi tashkil etildi. Xodim o‘z huquq va manfaatlarini himoya qilish maqsadida direktorga jamoatchilik Kengashi a’zosi bo‘lish iltimosi bilan yozma ravishda murojaat qildi. Bunga javoban direktor xodim kasaba uyushmasi boshlang‘ich tashkiloti faoliyati doirasida o‘z huquq va manfaatlarini himoya qilishi mumkinligini aytib o‘tdi. Bunga javoban fuqaro O‘zbekiston Respublikasi Prezidentining `O‘zbekiston Respublikasi Prezidenti huzurida jamoatchilik palatasini tashkil etish to‘g‘risida` gi Farmoni asosida jamoatchilik kengashlari jamoatchilik palatasi tomonidan tasdiqlanishi kerakligini aytdi. ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 48, Question = "Fuqaro A.Murodov o‘z avtomashinasini to‘xtash taqiqlangan belgi zonasiga to‘xtatib qo‘yganligi munosabati bilan YPX maxsus xizmati tomonidan avtomobili evakuatsiya qilingan. A.Murodov maxsus yo‘l harakati xavfsizligi xizmati xodimlarining xatti-harakatlari Konstitutsiyada kafolatlangan mulk huquqini buzganligi sababli ularni qonunga xilof deb hisoblab, Konstitutsiyaviy sudga uning masalasini ayrim toifali ishlar bo‘yicha ish yuritish jarayonida ko‘rib chiqish talabi bilan murojaat qilgan. Konstitutsiyaviy sud vakolati doirasida faqat muayyan ishda qo‘llanilgan yoki qo‘llanilishi kerak bo‘lgan qonunlarning Konstitutsiyaga muvofiqligi yuzasidan ishlarni ko‘rib chiqishini ta’kidlab, masalani hal qilishdan bosh tortdi. Shuningdek, shikoyatda YPX xodimlarining xizmati borasida noaniqliklar mavjudligini ko‘rsatib, ushbu masala bo‘yicha YPX xizmatining Konstitutsiyaga zid harakatlari aniqlanmaganligini ta’kidladi. ", Comment = "Ayrim toifadagi ishlar bo‘yicha konstitutsiyaviy ish yuritish tartibi qanday? Ayrim toifadagi ishlar bo‘yicha protsessda konstitutsiyaviy shikoyat berish uchun talablar mavjudmi?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 49, Question = "Saylov kuni saylov uchastkasiga kelgan Samarqand viloyat teleradiokanali xodimlari, avvalo, nomzodga nima sababdan ovoz berayotgani, saylovda kim g‘olib chiqishi mumkinligi, saylovchilar bu saylovlardan qanday natija kutayotgani haqidagi fikrlarini o‘rgana boshladi. Buning ortidan viloyat teleradiokanali xodimlari saylov natijalarini bashorat qila boshlashdi. Shu bilan birga, uchastka saylov komissiyasi raisi bu haqda bilib qolib, viloyat teleradiokanali xodimlariga radioeshittirish, intervyu va reportajlarni ta’qiqlab qo‘ydi. Saylov uchastkasi raisining harakatlaridan norozi bo‘lgan viloyat teleradiokanali xodimlari saylov qonunchiligi normalariga muvofiq ochiqlik, oshkoralik, erkinlik, adolat tamoyillariga muvofiq o‘tishi kerakligini aytib, o‘z e’tirozlarini bildirishdi. Bundan tashqari, ular uchastka saylov komissiyasi raisi ustidan, Markaziy saylov komissiyasiga shikoyat qilishlarini ta’kidladilar. ", Comment = "Vaziyatga huquqiy baho bering." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 50, Question = "O‘zbekiston Respublikasi Konstitutsiyasining 94-moddasiga binoan O‘zbekiston Respublikasi Prezidenti O‘zbekiston Respublikasi Konstitutsiyasi va qonunlariga asosan va unga muvofiq respublikaning butun hududida majburiy bo‘lgan farmonlar, qarorlar va farmoyishlar chiqaradi. Shuningdek, O‘zbekiston Respublikasi Konstitutsiyasining 98-moddasida Vazirlar Mahkamasi konstitutsiyaviy normalar doirasida va amaldagi qonun hujjatlariga muvofiq O‘zbekiston Respublikasining butun hududidagi barcha organlar, korxonalar, muassasalar, tashkilotlar, mansabdor shaxslar va fuqarolar uchun majburiy bo‘lgan qarorlar va farmoyishlar chiqaradi. O‘zbekiston Respublikasining `Normativ - huquqiy hujjatlar to‘g‘risida` gi Qonuning 5 - moddasida normativ - huquqiy hujjatlarning turlari O‘zbekiston Respublikasi Prezidentining farmonlari va qarorlari, lekin Vazirlar Mahkamasining normativ - huquqiy hujjatlar qismida faqat qarorlar ko‘rsatilgan.Vazirlar Mahkamasining farmoyishida normativ-huquqiy hujjat turi sifatida ko‘rsatilmagan.", Comment = " Vaziyatga amaldagi normativ huquqiy hujjatlar doirasida tahlil qiling." });









        }

        private void Generator_MockData_Uz_K()
        {
            this.Logical_question_1 = new List<Quiz_Item>();
            this.Logical_Cases_1 = new List<Quiz_Item>();
            #region Old Quiz
            /*this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Suverenitet tushunchasining mohiyati nimadan iborat? Nima uchun aynan “oliy hokimiyat” degan maʼnoni anglatuvchi mazkur tushuncha davlatga nisbatan qo‘llanila boshlangan deb o‘ylaysiz?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "O‘zbekiston Respublikasi Oliy Majlisini shakllantirish tartibini muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "O‘zbekiston Respublikasi Oliy Majlisi Senatining shakllantirish tartibini Konstitutsiya va qonunchilik asosida yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "O‘zbekiston Respublikasida qonunchilik tashabbusi huquqiga ega bo‘lgan subyektlarning o‘ziga xos xususiyatlarini izohlab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "O‘zbekiston Respublikasi Oliy Majlisi palatalarining o‘zaro munosabatlarini Konstitutsiya va qonunchilik asosida atroflicha tahlil qiling. Ushbu munosabatlarni amaliy nuqtai nazardan yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi faoliyatini tashkil etish tartibi va uning tarkibiy tuzilmalari haqida atroflicha to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi deputati va Senat a’zosi vakolatlarini muddatidan ilgari tugatish asoslarini yoritib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "O‘zbekiston Respublikasida mahalliy oʻzini o‘zi boshqarish organlari faoliyati asoslarini ochib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "O‘zbekiston Respublikasi prokuratura organlarining tizimi qanday va ularning davlat organlari tizimida tutgan o‘rni va ahamiyatini ochib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "O‘zbekiston Respublikasi prokuratura organlari vakolatlari va faoliyat yo‘nalishlari mazmunini ochib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Harakatlar strategiyasi natijasida O‘zbekiston Respublikasida amalga oshirilgan konstitutsiyaviy islohotlarning mazmun-mohiyatini batafsil yoritib bering. Uning amaldagi ijrosi masalasiga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "O‘zbekistonda saylov tizimini takomillashtirish borasida olib borilayotgan islohotlar mazmuniga huquqiy tavsif bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi Spikerining huquqiy maqomini yoritib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "O‘zbekiston Respublikasi Oliy Majlisi tomonidan Konstitutsiyaga o‘zgartishlar kiritish haqidagi qonun, konstitutsiyaviy qonun, qonun hamda qarorlarni qabul qilishda o‘xshash va farqli jihatlarni tahlil etib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Konstitutsiyaviy huquqning jamiyat va davlat qurilishi sohasidagi ahamiyatini huquqiy jihatdan ifodalab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Jahonda konstitutsiyalar paydo bo‘lishining asosiy zaruriyati nimada va ular paydo bo‘lganidan so‘ng qanday ijobiy o‘zgarishlar bo‘ldi?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Konstitutsiyaviy huquq fanining boshqa huquqiy fanlar bilan aloqasini huquqiy jihatdan asoslab bering. Ushbu aloqadorlik amaliyotda qanday o‘z ifodasini topgan? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Konstitutsiyaviy huquq manbalariga nimalar kiradi? Ushbu manbalar nima uchun konstitutsiyaviy huquq manbasi bo‘lib xizmat qilishini asoslab bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Konstitutsiya muqaddimasi g‘oyalarining konstitutsiya normalarida aks etishi xususida so‘z yuriting. Ushbu g‘oyalarning ijtimoiy munosabatlardagi o‘rnini huquqiy jihatdan izohlab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "O‘zbekiston xalqi nomidan ish olib borishning konstitutsiyaviy asoslarini tushuntirib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Demokratiyaning umuminsoniy prinsiplarga asoslanishi deganda nimani tushunasiz? Huquqiy manbalarda ushbu prinsip o‘zining qanday ifodasini topgan? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "O‘zbekiston fuqarolarini chet ellarda huquqiy himoya qilish tartibi qanday? Xorijiy davlatlarda ushbu masala bo‘yicha qanday asoslar mavjud?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Saylov tizimining konstitutsiyaviy va huquqiy asoslariga tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "Konstitutsiyaning mohiyati va uning asosiy belgilari nimalardan iborat? Konstitutsiyaning funksiyalarini tavsiflab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Hokimiyatning yangi va muvoziy tarkiblarini tuzish Konstitutsiyaga xilof hisoblanashini tahlil qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Xususiy mulkning daxlsizligini va uning davlat tomonidan himoyalanishini huquqiy asoslarini  yoriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Konstitutsiyaning qanday turlari mavjud? Konstitutsiyaning turlari bir-biridan mazmun jihatdan qanday farqlanadi?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Mustaqillikning ilk yillari O‘zbekiston Respublikasi Konstitutsiyasining loyihasini ishlab chiqish tarixini yoritib bering. Konstitutsiyani qabul qilishdagi ijtimoiy zarurat qanday edi? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "O‘zbekiston Respublikasi Konstitutsiyasiga o‘zgartirish kiritish tartibini qonunchilik doirasida batafsil yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Hozirgi kunga qadar O‘zbekiston Respublikasi Konstitutsiyasiga necha marta o‘zgartish va qo‘shimchalar kiritilganligini batafsil yoritib bering va misollar keltiring." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Xalqaro huquqning umume’tirof etilgan normalarini O‘zbekiston Respublikasi Konstitutsiyasida o‘z ifodasini topishi xususida batafsil mulohaza yuriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Konstitutsiya va qonunchiligimizda O‘zbekiston Respublikasi suverenitetining davlat-huquqiy belgilariga atroflicha to‘xtalib, batafsil yoriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Sud hokimiyati organlari tizimini yoritib bering. Sud tizimidagi oxirgi konstitutsiyaviy islohotlarning mazmun-mohiyati va ahamiyatini tushuntirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "O‘zbekistonda sud hokimiyati mustaqilligini ta’minlash masalasi qonunchilikda qanday o‘z ifodasini topgan? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi deputati va Senati a’zosining huquqlari nimalardan iborat?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Normativ-huquqiy hujjatlar tizimida O‘zbekiston Respublikasi Konstitutsiyasining tutgan o‘rniga huquqiy tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "O‘zbekiston Respublikasi Oliy Majlisi palatalarining O‘zbekiston Respublikasining ma’muriy-hududiy tuzilishi sohasidagi vakolatlarini tavsiflab bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "O‘zbekiston Respublikasi davlat ramzlari: bayroq, madhiya va gerbning qabul qilinishi xususida fikr bildiring. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Davlat organlari va mansabdor shaxslarning jamiyat va fuqarolar oldida mas’ulligi nimalarda namoyon bo‘ladi? Mas’uliyat va javobgarlik masalalariga huquqiy tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "O‘zbekiston Respublikasida davlat hokimiyatini amalga oshirish deganda nimani tushunasiz va davlat faoliyatining asosiy prinsiplarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Xalq hokimiyatchiligi deganda nimani tushunasiz? Xalq hokimiyatchiligining mazmun va mohiyatini batafsil yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Referendum nima? Mamlakatimizda referendumni o‘tkazishning huquqiy asoslarini aytib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "O‘zbekiston Respublikasida Bosh vazirni vazifasidan ozod qilish tartibini qonunchilik doirasida yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "O‘zbekiston Respublikasida Bosh vazirga ishonchsizlik votumini bildirish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Hukumatni parlament oldida hisob berishi masalasiga huquqiy tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "O‘zbekiston Respublikasi Bosh vaziri, uning o‘rinbosarlari va hukumat a’zolarining huquqiy maqomini milliy qonunchilik doirasida batafsil yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Mahalliy davlat hokimiyati faoliyatining konstitutsiyaviy-huquqiy asoslariga huquqiy tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Hokimlarning tegishli hududda ijtimoiy-iqtisodiy rivojlanishining eng muhim va dolzarb masalalari yuzasidan hisobotini xalq deputatlari Kengashi tomonidan eshitish tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Davlat hokimiyatining bo‘linishi prinsipi deganda nimani tushunasiz? Ushbu prinsipning mazmun va mohiyatiga to‘xtaling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Jamoatchilik nazorati deganda nimani tushunasiz? Mamlakatimizda jamoatchilik nazoratini kuchaytirish masalalari xususida va uning huquqiy asoslari haqida fikr yuriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Konstitutsiya va qonunlarning ustunligi deganda nimani tushunasiz? O‘zbekiston Respublikasida Konstitutsiya va qonunlarning ustunligini ta’minlanish masalalariga atroflicha to‘xtaling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "O‘zbekiston Respublikasida Inson huquqlari bo‘yicha vakil (Ombudsman)ning huquqiy maqomi va faoliyati yo‘nalishlarini batafsil yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Shaxsiy hayot daxlsizligi deganda nimani tushunasiz? Shaxsiy hayot daxlsizligini O‘zbekiston Respublikasi Konstitutsiyasi va qonunchiligidagi ifodasi haqida to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Vijdon va e’tiqod erkinligi deganda nimani tushunasiz? O‘zbekistonda vijdon va e’tiqod erkinligining konstitutsiyaviy kafolatlarini tahlil qiling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "So‘z va fikr erkinligi deganda nimani tushunasiz? So‘z va fikr erkinligining huquqiy kafolatlanishi xususida fikr-mulohazalaringizni bildiring." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Mamlakatimizda shaxsning huquq va erkinliklarini ta’minlash va kafolatlash borasida olib borilayotgan huquqiy islohotlarning mazmun va mohiyati haqida gapirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Fuqarolarning davlat va jamiyat ishlarini boshqarishda ishtirok etish huquqi deganda nimani tushunasiz? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "O‘zbekiston Respublikasi Konstitutsiyasiga muvofiq tashqi siyosatning asosiy prinsiplari qanday? Ularning o‘ziga xos xususiyatlarini yoriting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Inson va fuqarolarning huquq va burchlari deganda nimani tushunasiz? Inson huquqlari haqida xalqaro hujjatlarni ko‘rsating." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "O‘zbekiston Respublikasining Konstitutsiyasida inson va fuqarolarning huquq va erkinliklari ta’minlanishi masalalarini atroflicha muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Huquq va erkinliklarning konstitutsiyaviy cheklanishi asoslari va tartibini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Siyosiy huquq va erkinliklar tushunchasini yoritib bering. Siyosiy huquq va erkinliklarning qanday ko‘rinishlari mavjud? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasining konstitutsiyaviy-huquqiy maqomini Konstitutsiya va qonunchilik asosida yoritib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "O‘zbekiston Respublikasi Oliy Majlisi Senati vakolatlariga ularni guruhlarga ajratgan holda tavsif bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi faoliyatidagi professionalizm prinsipiga nazariy-huquqiy tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasining vakolatlarining mazmun-mohiyatiga to‘xtaling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasini shakllantirish tartibini tushuntirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Fuqarolarning asosiy burchlarini tasniflab, mazmunini ochib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Shaxsiy huquq va erkinliklar tushunchasiga atroflicha to‘xtaling. Shaxsiy huquq va erkinliklarning qanday ko‘rinishlari mavjud?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Iqtisodiy va ijtimoiy huquqlar tushunchasini yoritib bering. Iqtisodiy va ijtimoiy huquqlarning qanday ko‘rinishlari mavjud? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "O‘zbekiston Respublikasi fuqaroligi deganda nimani tushunasiz? O‘zbekiston Respublikasi fuqaroligining huquqiy asoslarini yoritib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Fuqarolikka ega bo‘lish va yo‘qotish asoslarini ko‘rsatib bering. Bu asoslar amaliyotda qayday o‘z ifodasini topgan?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Mulkdor va mulkka egalik qilish masalalarini Konstitutsiya asosida yortib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Mulkka egalik qilish, foydalanish, tasarruf qilish, mulkdan mahrum qilish deganda nimani tushunasiz? Ushbu tushunchalarga huquqiy jihatdan tavsif bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Jamoat birlashmalari deganda nimani tushunasiz? Jamoat birlashmalarining fuqarolik jamiyatini shakllantirishdagi ahamiyatini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Siyosiy partiyalar deganda nimani tushunasiz? Siyosiy partiyalar faoliyatining konstitutsiyaviy va huquqiy asoslarini batafsil muhokama qiling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Jamoat birlashmalarini davlat tomonidan qo‘llab-quvvatlash shakllari va huquqiy asoslarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "O‘zbekiston Respublikasi Prezidentining vakolatlarini mazmun-mohiyatini ularni tasniflagan holda oritib bering?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "O‘zbekiston Respublikasi Prezidenti tomonidan qabul qilinadigan normativ-huquqiy hujjatlarni atroflicha tahlil qilib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "O‘zbekiston Respublikasi Prezidentining davlat hokimiyati organlarini kelishilgan holda faoliyat yuritishini hamda hamkorligini ta’minlash funksiyasi amaliyotda o‘zining qanday ifodasiga ega? Ushbu funksiya qonunchiligimizda qachon joriy etildi?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "O‘zbekiston Respublikasi Vazirlar Mahkamasining shakllanish tartibi va huquqiy asoslari haqida gapirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "O‘zbekiston Respublikasi Vazirlar Mahkamasi vazifalarining konstitutsiyaviy asoslarini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Nodavlat notijorat tashkilotlarning huquqiy maqomini O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "O‘zbekiston Respublikasida demokratik institutlar tizimida ommaviy axborot vositalarining o‘rni va ahamiyatini yoritib bering. Ommaviy axborot vositalarini tartibga soluvchi huquqiy asoslarga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Ommaviy axborot vositalari faoliyatining huquqiy asoslarini batafsil muhokama qiling. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "O‘zbekiston Respublikasida oila institutining konstitutsiyaviy maqomini batafsil yoritib bering. Oilaning jamiyat va davlat hayotidagi o‘rnini yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Ota-ona va farzandlarning burchlari deganda nimani tushunasiz? O‘zbekiston Respublikasi Konstitutsiyasiga muvofiq ota-ona va farzandlarning burchlari mohiyatini muhokama qiling." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Konstitutsiyaviy huquqning yetakchi huquq sohasi sifatidagi o‘rnini yoritib bering. Konstitutsiyaviy huquqning jamiyat va davlat qurilishi sohasidagi ahamiyatini huquqiy jihatdan tavsiflab bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Sud orqali huquq va erkinliklarni himoya qilish deganda nimani tushunasiz? Huquq va erkinliklarni yana qanday yo‘llar bilan himoya qilish mumkin?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Fuqarolarning jamoat birlashmalariga uyushish va ommaviy harakatlarda ishtirok etish huquqini mazmun-mohiyatini batafsil yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Jismoniy va yuridik shaxslarning murojaatlari deganda nimani tushunasiz? Davlat organlari, muassasalariga va xalq vakillariga murojaat qilish huquqining mazmun-mohiyatini ochib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Hokimiyat tarmoqlari o‘rtasida tiyib turish va muvozanat saqlash prinsipining mohiyati va ahamiyatini O‘zbekiston Respublikasi Konstitutsiyasi normalariga tayangan holda yoritib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Saylov huquqi deganda nimani tushunasiz? Saylov huquqi – fuqarolarning siyosiy huquqi sifatidagi qarashlarga o‘z munosabatingizni bildiring." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Deputat va Senat a’zosini chaqirib olish tartibi va chaqirib olish asoslarini tushuntirib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Qonunchilik jarayoni va uning bosqichlarini qonunchilik doirasida batafsil yoritib bering. Qonunchilik tashabbusi subektlarini aytib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Parlament faoliyatida kelishuv komissiyasi tuzishdan ko‘zlangan maqsad va kelishuv komissiyasini tuzish tartibini tushuntirib bering." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Qonunni imzolash va uning kuchga kirishi tartibini qonunchilik doirasida batafsil yoritib bering. Ushbu jarayonni tartibga soluvchi huquqiy asoslarga to‘xtab o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "O‘zbekiston Respublikasi Prezidentining konstitutsiyaviy-huquqiy maqomini yoritib bering. O‘zbekiston Respublikasi Prezidenti faoliyatini tartibga soluvchi huquqiy asoslarga to‘xtalib o‘ting." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "O‘zbekiston Respublikasi Prezidenti saylovini tashkil etish va o‘tkazish tartibini batafsil yoritib bering. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Konstitutsiyada moliya va kredit masalalariga oid qanday normalar mavjud va ularni tushuntirib bering." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 1,
                Question = "O‘zbekiston Republikasi Prezidenti futbol sport turini rivojlantirish maqsadida asli Braziliya fuqarosi bo‘lgan, futbol sohasida katta tajribaga ega Robertoni O‘zbekiston terma jamoasi bosh murabbiyi sifatida taklif qilib, unga O‘zbekiston Respublikasi fuqaroligini berish yuzasidan farmoyish chiqardi. Bu holdan norozi bo‘lgan terma jamoaning avvalgi murabbiyi Braziliya fuqarosiga O‘zbekiston fuqaroligini bu vaziyatda berish mumkin emasligini, uning qonunga ko‘ra alohida tartibi mavjudligini keltirib o‘tgan.",
                Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling."
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 2,
                Question = @"Fuqaro T. Toshkent shahridagi ko‘p qavatli uyda yashar edi. 2023-yil 25-fevral kuni kechasi soat 23:30 da qo‘shni xonadondan baland musiqa va turli shovqinlar eshitila boshlandi. Bundan norozi bo‘lgan fuqaro T. qo‘shni xonadon eshigini taqillatib, uyida yosh bolasi borligi va bu shovqin uni qo‘rqitayotganligini ta’kidladi. Bunga javoban qo‘shni xonadon egasi uy uning xususiy mulki ekanligi va undan xohlaganicha foydalanishi mumkinligin aytib o‘tdi.
Holatni bartaraf qilish uchun fuqaro T. hududning profilaktika inspektoriga murojaat qildi, yetib kelgan profilaktika inspektori ham uy uning xususiy mulki ekanligini, bu holatga aralasha olmasligini aytib o‘tdi.",
                Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling."
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 3,
                Question = @"O‘zbekiston Respublikasi fuqarosi Xojimatov oliy ta’lim muassasida o‘qituvchi bo‘lib ishlardi. U o‘z bilimlariga tayangan holda qonun loyihasini tayyorlab, uni Oliy Majlis Qonunchilik palatasiga taqdim etdi. U “O‘zbekistonda sun’iy intellektdan foydalanishni tartibga solish to‘g‘risida”gi qonun loyihasiga quyidagilarni ilova qildi.
1)	 qonun loyihasiga tushuntirish xati;
2)	 o‘zgartirilishi va bekor qilinishi kerak bo‘lgan qonun osti hujjatlar ro‘yxati.
Biroq, Qonunchilik palatasi Spikeri qonun loyihasini ko‘rib chiqishdan bosh tortib, fuqaro Xojimatov qonunchilik tashabbusi subyekti emasligi vaji bilan taklifni qaytarib yubordi.",
                Comment = "Huquq ijodkorligida fuqarolarning ishtirokini muhokama eting va vaziyatga huquqiy yechim bering."
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 4,
                Question = @"Antiseptik va gigiena vositalari ishlab chiqarishga ixtisoslashgan “Biokosmik” xususiy korxonasining bir guruh xodimlari mazkur korxona egasiga ularning huquq va erkinliklariga rioya etilmayotganligi va ularning huquqlari buzilayotganligi masalasida murojaat qildi.
Ular ish sharoitlari, xususan, ish haqining kechiktirib to‘lanishi, shuningdek, mulkdorning qarindoshlari bo‘lgan xodimlarga maxsus imtiyoz va nafaqalar berilayotganligi yuzasidan prokuraturaga shikoyat bilan murojaat qilishlarini aytishdi. 
Bundan tashqari, ular kichik biznes subyekti sifatida korxonaning muayyan imtiyozlaridan mahrum bo‘lishiga erishish uchun antiseptik vositalarini belgilangan talab me’yorlar asosida tayyorlanmayotganligi haqida xabar berishlarini bildirishdi.
Bunga javoban korxona rahbari o‘zining xususiy korxonasida o‘zi istaganday ishlashini aytib, norozi bo‘lgan xodimlar bilan tuzilgan mehnat shartnomasini bekor qildi.",
                Comment = "Vaziyatga huquqiy baho bering."
            });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 5, Question = @"O‘zbekiston SSR fuqarosi G. Xolikova 1989-yil Ukraina Militsiya institutiga o‘qishga qabul qilindi. 1994-yil mazkur o‘qishni yakunlab, O‘zbekiston Respublikasiga qaytib keldi. O‘zbekiston Respublikasi fuqaroligini olishni so‘rab ichki ishlar idoralariga murojaat qildi. Unga 1995-yil O‘zbekiston Respublikasi fuqaroligi pasporti berildi. 
Biroq, 2007-yilda sudyalikka nomzod sifatida uning O‘zbekiston Respublikasi fuqaroligiga g‘ayriqonuniy yo‘l bilan ega bo‘lganligi aniqlandi va   G. Xolikovaning O‘zbekiston Respublikasi fuqaroligi bekor qilindi. G. Xolikovaning aytishicha, agar u O‘zbekiston fuqarosi bo‘lmasa, demak u sudya sifatida chiqargan hukmlari ham bekor qilinishi kerak. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 6,
                Question = @"2020-yil 2-may kuni Turkmaniston Respublikasi fuqarosi Z.Rahimov Xorazm viloyati Xonqa tumani IIB boshlig‘i G.Rametovga O‘zbekiston Respublikasi fuqaroligiga qabul qilinishni so‘rab murojaat qildi. Murojaatda O‘zbekiston Respublikasida tug‘ilgani, hozirda farzandlari O‘zbekiston Respublikasi fuqarosi bo‘lib, shu yerda yashashini keltirib o‘tdi. Shunga asosan, unga to‘g‘ridan-to‘g‘ri O‘zbekiston Respublikasining fuqaroligini berilishini talab etdi. Biroq, uning talabi qondirilmadi. 
Bundan norozi bo‘lgan Z.Rahimov shikoyat bilan sudga murojaat qildi.",
                Comment = "Vaziyatga huquqiy baho bering."
            });


            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 7,
                Question = @"2020-yil 5-may kuni Qirg‘iziston Respublikasi fuqarosi 17 yoshli 
K. O‘zbekiston Respublikasi fuqarosi bo‘lgan xolasi S. tomonidan farzandlikka olindi. 
Bir oy ichida K. Qirg‘iziston fuqaroligidan chiqdi. 
S. farzandi K.ni O‘zbekiston Respublikasi fuqaroligiga qabul qilinishini so‘rab ichki ishlar organiga murojaat qildi. Biroq, ichki ishlar organi tomonidan O‘zbekiston Respublikasi fuqaroligiga qabul qilish uchun chet el fuqarosi O‘zbekiston hududida besh yil davomida muqim yashashi kerakligi aytildi. 
Shu bois, bu talab bajarilmagani sababli S. tomonidan taqdim etilgan hujjatlar qaytarildi. Bundan norozi bo‘lgan S. sudga murojaat qildi.",
                Comment = "Vaziyatga huquqiy baho bering."
            });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 8, Question = @"Oqoltin tumanida yashovchi fuqaro B. Oliy Majlis Qonunchilik palatasi deputatligiga saylov o‘tkazuvchi 54-Bo‘z saylov okrugi raisiga Jamoatchilik nazoratini amalga oshirish maqsadida murojaat qildi. U o‘z murojaatida okrug saylov komissiyasi faoliyatini jamoatchilik nazoratiga oid qonunchilik normalari asosida hamda o‘z fuqarolik pozitsiyasidan kelib chiqqan holda amalga oshirmoqchi ekanligini ta’kidladi. Okrug saylov komissiyasi raisi fuqaro B. ni bunday huquqi yo‘qligini bildirib, uni Markaziy saylov komissiyasiga murojaat qilishi lozimligini bildirdi. Fuqaro B. mazkur holatdan norozi bo‘lib, O‘zbekiston Respublikasi Konstitutsiyaviy sudiga murojaat qildi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 9, Question = @"Fuqaro A.Akbarov o‘ziga tegishli bo‘lgan yer uchastkasini fuqaro 
V. Saidovga 35 ming AQSh dollariga sotib yubordi. Ushbu yer uchastkasining hujjatlarini rasmiylashtirish jarayonida davlat hokimiyati idoralari ushbu oldi-sotdi shartnomasini amalga oshirishga to‘sqinlik qildi. Yer umummilliy boylik sifatida uning erkin oldi-sotdi qilinishi taqiqlandi. A. Akbarov esa ushbu yer uchastkasi mulk qilib berilganligini, unga nisbatan mulk huquqi mavjud bo‘lib, uni tasarruf etish huquqi ham mulk huquqining elementi sifatida unga tegishli ekanligini keltirib sudga murojaat qildi.
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 10,
                Question = @"2018-yil 23-mart sanasida O‘zMTRK kanallarining birida yoshlar hayotidagi muammolar haqida tanqidiy ruhdagi ko‘rsatuv efirga uzatildi. Unda yosh yigit qizlarning markaziy xiyobonlarda uchrashuvlari aks etgan lavhalar markaziy o‘rin egalladi. Ko‘rsatuv efir yuzini ko‘rgach, televidenie orqali yuzi yashirilmagan holda namoyish etilgan va keng jamoatchilik tomonidan tanqid qilingan yoshlar ruhiyatida o‘zgarishlar kuzatildi. Hattoki, ijtimoiy tarmoqlarda ayrim yoshlar o‘z joniga qasd qilishga urinishlar haqida xabarlar tarqaldi. 
Mazkur holatda televidenie xodimlari hatti-harakatlarini inson va fuqarolarning shaxsiy hayotiga aralashish deb baholash mumkinmi?",
                Comment = "Vaziyatga huquqiy baho bering. "
            });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 11, Question = @"2020-yil 13-aprel kuni J. Erkinov T. Anvarova bilan nikoh tuzish uchun Fuqarolik holati dalolatnomalarini qayd etish bo‘limiga murojaat qildi. Fuqarolik holati dalolatnomalarini qayd etish bo‘limi mudirasi nikoh tuzish tartibini tushuntirdi. Birinchidan, nikoh tuzish uchun yozma rozilik bo‘lishi, ikkinchidan, nikoh tuzish uchun ariza berilgandan keyin bir oylik muddat belgilanishi, uchinchidan, nikoh nikohlanuvchilarning shaxsan ishtirokida qayd etilishi va nikohni vakil yoki ishonchnoma orqali rasmiylashtirishga yo‘l qo‘yilmasligini tushuntirdi. 
Biroq, J. Erkinov va T. Anvarova qonunchilikda bir oylik muddatning belgilanishi nikohlanuvchi shaxslar nikohga erkin, ixtiyoriy, tenglik hamda o‘zga shaxslarning majburlovisiz kirayotganligini aniqlashtirish uchun zarur ekanligini, ular bunday muddat belgilanmasa ham o‘zaro rozilik va ixtiyoriylik asosida turmush qurmoqchi ekanliklarini bildirib, nikohni ariza berilgan kuniyoq ro‘yxatdan o‘tkazishni talab qildilar. Fuqarolik holati dalolatnomalarini qayd etish bo‘limi mudirasi ushbu talabni rad etdi.
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 12, Question = @"L.Solieva Malayziya hukumati tomonidan e’lon qilingan Malayziya texnik hamkorlik dasturi grantida ishtirok etish uchun hujjatlar tayyorladi. L.Solieva faoliyat olib boradigan advokatlik hay’ati rahbari nomidan yo‘llanma xat oldi. Yo‘llanma xat o‘zbek tilida yozilgan edi. 
Malayziya texnik hamkorlik dasturi granti uchun hujjatlar Malayziyaning O‘zbekistondagi elchixonasiga O‘zbekiston Respublikasi Tashqi ishlar vazirligi orqali topshirilishi kerak edi. L.Solieva 2019-yil 15-mart kuni hujjatlarni Tashqi ishlar vazirligiga olib bordi. Ammo, Tashqi ishlar vazirligining chet el grantlari uchun mas’ul bo‘lgan boshqarmasida faoliyat olib boruvchi xodimi L.Solievaga o‘zbek tilida yozilgan yo‘llanma xatni qabul qila olmasligini, uni rus tilida tayyorlab kelishni so‘radi.    
L.Solieva buning sababi nimada ekanini so‘raganda Tashqi ishlar vazirligining grantlar bilan ishlaydigan boshqarmasi xalqaro grantlar nomzodlari uchun beriladigan yo‘llanma xatlar rus tilida qabul qilinishi tartib-qoidaga aylangani, bunga barcha nomzodlar rioya qilib kelayotganini ta’kidladi. 
L.Solieva bundan norozi bo‘lib 2019-yil 17-mart kuni O‘zbekiston Respublikasi Vazirlar Mahkamasining Davlat tilini rivojlantirish departamentiga shikoyat bilan murojaat etdi. Departament vakolatlari doirasida L.Soliyevaning murojaatini o‘rganib chiqishga kirishdi.  
O‘rganish natijalariga ko‘ra, Tashqi ishlar vazirligi tomonidan fuqaro L.Soliyevadan xalqaro grantda ishtirok etish uchun u faoliyat olib borayotgan muassasaning rahbari tomonidan o‘zbek tilida taqdim etilgan yo‘llanma xatni qabul qilish rad etilgani hamda uni rus tilida tayyorlab kelish talab etilgani davlat tili to‘g‘risidagi qonun hujjatalari bilan o‘rnatilgan qoidalarning buzilishiga olib kelgan. Ya’ni, bunda davlat hokimiyati va boshqaruv organlarida ish davlat tilida yuritilishi va fuqarolar davlat tashkilotlari va muassasalariga murojaatni davlat tilida taqdim etish huquqiga ega ekani e’tiborga olinmagan. 
O‘zbekiston Respublikasi Tashqi ishlar vazirligi tomonidan bunga javoban xalqaro grant nomzodlarining hujjatlari uchun berilgan yo‘llanma xatlar fuqaro murojaati hisoblanmasligi, o‘zbek tilida topshirilgan yo‘llanma xatlarni qabul qilmaslik esa davlat tilida ish yuritish jarayoni hisoblanmasligi aytildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 13, Question = @"D.Mahmudov 2020-yil 1-yanvar kuni yaqin do‘stlari bilan o‘tkazilgan ziyofatda ishtirok etdi. D.Mahmudov ziyofatda mobil telefonini stol ustida qoldirib tashqariga chiqib ketdi. Bu orada ziyofatda ishtirok etayotgan K. Ergashev uning telefonidan Telegram dasturi orqali boshqa shaxs bilan so‘zlashuvlarini o‘qib chiqdi. 
Ertasi kuni noma’lum shaxs D.Mahmudovga telefon qilib uning muhim bir siridan voqif ekanini aytdi. Biroq, D.Mahmudovga sirni oshkor qilish bilan bog‘liq hech qanday tahdid qilmadi. Shunga qaramay, bundan xavotirga tushgan 
D.Mahmudov ichki ishlar organiga murojaat qildi. D.Mahmudov uning siridan voqif bo‘lish niyatida qasddan Telegram dasturi orqali boshqa shaxs bilan so‘zlashuvlarini o‘qib chiqqanlik va bu orqali o‘zganing siridan voqif bo‘lganlik uchun tegishli shaxslarni topib javobgarlikka tortishni so‘radi.
Biroq, D.Mahmudovga huquqni muhofaza qiluvchi organ tomonidan boshqa shaxs bilan so‘zlashuvlarini qasddan o‘qib chiqqanlik va bu orqali o‘zganing siridan voqif bo‘lganlik uchun hech qanday javobgarlik o‘rnatilmagani aytildi. Bundan norozi bo‘lgan D.Mahmudov sudga murojaat qildi. Sud O‘zbekiston Respublikasining Konstitutsiyasida birovning yozishmalar va telefonda so‘zlashuvlar sirini oshkor etish ta’qiqlanganini keltirib D. Mahmudovning talabini qanoatlantirishni rad etdi. Bundan norozi bo‘lgan D.Mahmudov yuqori turuvchi sudga apellyatsiya tartibida shikoyat qildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 14, Question = @"2020-yil 20-oktabr kuni bo‘lib o‘tgan Oliy Majlis Qonunchilik palatasining sessiyasida Andijon viloyatining Asaka shahrini Asaka tumaniga birlashtirish haqida qaror qabul qilindi.
Mazkur qabul qilingan qaror bilan Asaka shahrini Asaka tumaniga birlashtirilishi keyinchalik mazkur hududni ma’muriy jihatdan boshqarishda muayyan qiyinchiliklarni keltirib chiqardi. 
Tuman hokimi shaharning infratuzilmasi, aholi soni va yer maydoni shahar tashkil etishga yetarli ekanini asos qilib, shaharni qaytadan tashkil etishni so‘rab, Vazirlar Mahkamasiga iltimosnoma bilan murojaat qilish lozim ekanligini aytib tuman mahalliy kengashi qarorini chiqargan holda, O‘zbekiston Respublikasi Vazirlar Mahkamasiga murojaat qildi.
Biroq, xokim tomonidan qilingan murojaat Vazirlar Mahkamasi tomonidan rad etildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 15, Question = @"2019-yil 5-oktabr kuni Xalq deputatlari Buxoro viloyati Kengashi tomonidan Buxoro viloyatining ma’muriy hududiy birligining o‘zgartirish maqsadida qaror qabul qilindi. O‘zbekiston Respublikasi Oliy Majlisi Senatidan mazkur qarorni tasdiqlab berilishi so‘raldi. 
O‘zbekiston Respublikasi Oliy Majlisi Senatining navbatdagi sessiyasida Buxoro viloyati xalq deputatlarining ma’muriy hududiy birligini o‘zgartirish yuzasidan Senatga yuborilgan qaror ko‘rib chiqildi. Ko‘rib chiqish natijalari yuzasidan Senat qarori qabul qilindi. 
O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi Spikeri bunday masala Oliy Majlis palatalari qo‘shma majlisida muhokama etilib, so‘ng tegishli qaror qabul qilinishi kerakligini aytib e’tiroz bildirdi.", Comment = "Vaziyatga huquqiy baho bering" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 16, Question = @"Yakkasaroy tumani “A’lo” mahallasi hududida istiqomat qiluvchi fuqaro A.Komilov vafot etdi. Vorislari bo‘lmaganligi sababli uning ko‘chmas mulki egasiz qoldi. Mahalla fuqarolar yig‘ini tomonidan ushbu uchastka kam ta’minlangan, boquvchisini yo‘qotgan fuqaro R. Vohidov va uning oilasiga beriladigan bo‘ldi. Ma’lum vaqt o‘tganidan so‘ng, mahalla hisobidagi mablag‘larning noqonuniy tasarruf etilishi yuzasidan prokuratura idoralari tomonidan taftish o‘tkazila boshlandi. O‘rganish jarayonida egasiz uyning M.F.Y. qarori asosida fuqaro R.Vohidovga berilgani ham aniqlandi va prokuratura tomonidan mazkur qaror haqiqiy emas deb topilib, uy davlat foydasiga o‘tkazildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 17, Question = @"2020-yil 5-mart kuni fuqaro N.Alimova bo‘sh ish o‘rinlar mavjud bo‘lgan davlat tashkilotiga ish so‘rab murojaat qildi. Tashkilot rahbari fuqaro 
N. Alimovadan ma’lumotnoma olib kelishni so‘radi. Tashkilot rahbari mazkur ma’lumotnomada Fuqaro N.Alimovaning 2 yoshli farzandi borligini vaj sifatida ko‘rsatib uni ishga qabul qilmadi. Fuqaro N. Alimova mazkur holatda gender tengligi buzilgan deb hisoblab, tuman Mahalla va oilani qo‘llab-quvvatlash vazirligiga murojaat qildi. Vazirlik mazkur nizo bo‘yicha vakolatli emasligini bildirib, N. Alimova sudga murojaat qilishi lozimligini ma’lum qildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 18, Question = @"2015-yil 26-dekabr kuni Toshkent shahrida yashovchi fuqaro D. Rahimov tuman elektr tarmoqlari korxonasiga elektr haqini to‘lash uchun bordi. Kassa xodimasiga murojaat qilib, o‘zining qarzdorligi bo‘yicha ma’lumot so‘rab murojaat qilganida xodima fuqaroga rus tilida murojaat qildi. D.Rahimov rus tilini bilmaganligi bois, u bilan muloqot qilolmadi. Kassa xodimasiga o‘zbek tilida so‘zlasha olishini aytganda, u faqat rus tilida so‘zlasha olishini aytib, rus tilini bilmagan D. Rahimov ustidan kuldi. 
D. Rahimov ushbu holat yuzasidan ma’muriyatga arz qilmoqchi bo‘lganda, ma’muriyatdagilar “bizda qoida shunaqa” degan ma’noda uning murojaatini qanoatlantirishsiz qoldirishdi. Bundan norozi bo‘lgan fuqaro D. Rahimov prokuraturaga shikoyat qildi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 19, Question = @"Farg‘ona viloyatida joylashgan va kichik biznes subyekti bo‘lgan “Bruschatka” MChJ turli bruschatka va beton qorishmasidan tayyorlanadigan qurilish materiallarini ishlab chiqaradi. Mazkur korxonada ishlaydigan fuqaro Z. Karimov o‘zinig korxonadagi ijtimoiy holatidan, uning fikricha ish beruvchining yomon munosabatidan norozi bo‘lib hokimiyat organlariga murojaat qildi. 
U o‘z murojaatida korxonada faoliyat olib borayotgan 100 nafar ishchi bir xil mehnat sharoitlarida ishlamayotganligi va bir xil ish haqi olmayotganliklari hamda ayni vaqtda 20 nafar ishchi 100 nafar ishchi uchun ishlayotgani, qolgan 80 nafar ishchi ish beruvchi mulkdorning qarindoshlari ekanligi sababli ular umuman ishga kelmasligi, shunga qaramasdan ish haqi olishlari, shuningdek, belgilangan reja bajarilmasdan qolgan taqdirda aynan 20 nafar ishchilar bilan mehnat shartnomasini bekor qilishi mumkin ekanligini ko‘rsatib o‘tdi.", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 20, Question = @"Navoiy viloyati markazida faoliyat yuritayotgan sut va sut mahsulotlari ishlab chiqarishga ixtisoslashgan “Shirin-qaymoq” xususiy korxonasida inson huquq va erkinliklari ta’minlanmayotganligi masalasi yuzasidan bir guruh ishchilar mulkdorga murojaat qilishdi. O‘z murojaatlarida mehnat sharoiti, ijtimoiy tenglik hamda mehnatga yarasha haq to‘lanmasa mazkur holat yuzasidan prokuraturaga murojaat qilishlari, shuningdek korxona foyda ko‘rmasdan ishlash bilan birga sut mahsulotlarini yetarli darajada qayta ishlamasdan isrof qilinayotganligi faktini kerakli organlarga ma’lum qilgan holda ushbu korxonaning kichik biznes subyekti sifatida barcha imtiyozlardan mahrum qilinishiga erishishlarini ma’lum qilishdi.
Bunga javoban esa korxona rahbari u mulkdor ekanligi hamda xohlagan ishini qilishi mumkinligini ma’lum qilgan holda murojaat qilgan barcha ishchilar bilan mehnat shartnomasini bekor qildi.", Comment = "Vaziyatga huquqiy baho bering. " });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 21, Question = @"S.Mahkamov o‘zining “Huquqingizni bilasizmi?” nomli ko‘rsatuvida fuqarolik ishlari bo‘yicha tumanlararo sudiga o‘z ko‘rsatuvi uchun fuqarolar ishtirok etgan fuqarolik ishi materiallari bilan tanishish va ulardan nusxa olishni so‘rab murojaat qilganligini, sud unga ish materiallaridan ko‘chirma va nusxa olishi mumkinligi, lekin sud majlisi bayonnomasidan nusxa olish qonun normalarida belgilanmaganligi sababli undan nusxa olish mumkin emasligini bildirganligini, Fuqarolik protsessual kodeksi (FPK)ga muvofiq ishda ishtirok etuvchi shaxslar ish materiallari bilan tanishish, ulardan ko‘chirmalar olish, nusxalar ko‘chirish huquqlariga egaligini ma’lum qilib, Konstitutsiyaviy sudda FPK dagi “ish materiallari” so‘zlari sud majlisi bayonnomasini ham nazarda tutishi yoki tutmasligi yuzasidan sharh berishni so‘ragan. O‘zbekiston Respublikasi Konstitutsiyaviy sudi ushbu normaga sharh berishni rad etgan.
", Comment = "Vaziyatga huquqiy baho bering. " });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 22,
                Question = @"K.Anvarov 2019-yil 14-sentabr kuni tana harorati 39 darajani ko‘rsatib, tanasida og‘riq sezganligi sababli shifoxonaga murojaat qildi.
Shifoxonada navbatchi vrach K.Anvarovning doimiy yashash manzili bo‘yicha shifoxonaga murojaat etishi lozimligini ma’lum qilib, uning holati qoniqarli ekanligi sababli uni statsionar sharoitda davolash uchun qabul qila olmasligini aytdi.
Bunga javoban, K.Anvarov vrachga murojaat etib, hech bo‘lmasa uni tibbiy ko‘rikdan o‘tkazishni va dastlabki tashxis qo‘yishni so‘radi.
Navbatchi vrach dastlabki tashxis qo‘ymasligini, bunday harakat qilish bo‘yicha rahbariyat tomonidan unga majburiyat yuklanmaganligini ma’lum qildi.
Bundan darg‘azab bo‘lgan K.Anvar konstitutsiyaviy huquqini tiklab berilishini so‘rab sudga shikoyat qildi.",
                Comment = "Vaziyatga huquqiy baho bering."
            });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 23, Question = @"2014-yil oktabrda fuqaro R.Rashidov saylov uchastkasiga murojaat qilib o‘zini saylovchilar ro‘yxatiga kiritib qo‘yishini so‘raydi. Uchastka raisi unga aniq saylovchilar miqdori bor ekanligini, saylovchilar ro‘yxatga olingan vaqtda u yashash joyida bo‘lmaganligi tufayli kiritilmaganligini ta’kidlaydi. O‘z navbatida, R.Rashidov bir kun avval O‘zbekiston Respublikasi fuqaroligiga ega bo‘lganligini va barcha fuqarolar kabi saylovda ishtirok etish huquqiga egaligini aytib o‘tdi. Saylov uchastkasi raisi R.Rashidov bildirgan vajlarga e’tibor qaratmasdan, ro‘yxatga olish jarayoni yakunlanganligini va ro‘yxat yuqori turuvchi komissiyaga taqdim etilganligini ma’lum qildi. R.Rashidov yuzaga kelgan holat bo‘yicha jinoyat ishlari bo‘yicha tuman sudiga shikoyat arizasi bilan murojaat qildi.
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 24, Question = @"“A” Siyosiy partiya parlamentga bo‘lib o‘tadigan saylovlarda muvaffaqiyatli qatnashish maqsadida xalqaro tashkilotdan hamda siyosiy platformasida aks ettirilgan g‘oya va maqsadlariga xayrixoh bo‘lgan chet el fuqarosidan ko‘p miqdorda chet el valyutasidagi xayriya yordamini oldi. Olingan mablag‘lar hisobidan siyosiy partiya nomzodlar bilan uchrashuvlarni tashkil etdi, uchrashuvlarga kelgan fuqarolarga o‘z hisobidan dasturxon tashkil etdi, esdalik sovg‘alarini hadya qildi. Mahalliy davlat hokimiyati organlari va bank-moliya idoralari tomonidan taqdim etilgan ma’lumotlar asosida Markaziy saylov komissiyasi partiyani saylov jarayonida ishtirok etishdan chetlatdi. Siyosiy partiyaning faollaridan biri mazkur qarordan norozi bo‘lib Konstitutsiyaviy sudga shikoyat arizasi bilan murojaat etdi.  
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 25, Question = @"2019-yil 15-oktabr kuni “Beshchashma” MFY faollari qishloq hududida joylashgan masjiddan foydalanishga ruxsat berishini so‘rab tuman hokimligiga murojaat qildi. Tuman hokimiyati qishloq aholisining ehtiyojini inobatga olib, faqat mazkur hududni obodonlashtirish, ko‘kalamzorlashtirish hamda doimiy ravishda toza va ozoda bo‘lish sharti bilan diniy ibodat uchun foydalanishga ruxsat berdi. 
Masjid va uning atrofidagi hududlarga kerakli daraxt ko‘chatlari, gul ekish majburiyat sifatida qishloq aholisi zimmasiga yuklandi. Biroq, oradan ko‘p o‘tmasdan viloyat adliya boshqarmasi tuman hokimining qarorini bekor qilgan holda ushbu masjiddan foydalanishni taqiqladi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 26, Question = @"Bir guruh deputatlar tomonidan Oliy Majlis Qonunchilik palatasiga yangi qonun loyihasini taqdim etdilar. Qonun loyihasida Qonunchilik palatasining reglamentiga o‘zgartirishlar kiritish nazarda tutilgan bo‘lib, unga ko‘ra Qonunchilik palatasi Kengashiga yangi qo‘mitalar tuzish, vaqtinchalik komissiyalar tuzish huquqi berilgan, Qonunchilik palatasining qo‘mitalari esa Qonunchilik palatasi nomidan muayyan masalalar bo‘yicha qarorlar qabul qilish huquqiga ega edi. Qonun loyihasi tashabbuskorlarining fikricha, ushbu amaliyot xorijiy mamlakatlar parlamentlarida keng tarqalgan bo‘lib, quyi palata faoliyatini optimallashtirish va samaradorligini oshirishga xizmat qiladi.
", Comment = "Vaziyatga huquqiy baho bering. Oliy Majlisi Qonunchilik palatasining tarkibiy bo‘linmalarini shakllantirish tartibini yoriting." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 27, Question = @"O‘zbekiston Respublikasi Prezidenti vakolati muddati tugashi munosabati bilan iste’foga chiqdi hamda O‘zbekiston Respublikasi Konstitutsiyasining 97-moddasiga binoan O‘zbekiston Respublikasi Oliy Majlisi Senatining umrbod a’zosi lavozimini egalladi. Mazkur munosabat bidan Senat Kengashining navbatdagi majlisida parlament yuqori palatasi Raisi Senat tarkibi Konstitutsiyaga muvofiq 100 nafar senatordan iborat bo‘lishi kerakligini ko‘rsatgan holda davlat boshlig‘i tomonidan O‘zbekiston Respublikasi Konstitutsiyasining 77-moddasi asosida tayinlangan 16 nafar senatordan birini Senat a’zoligi lavozimidan ozod etish taklifi bilan Prezidentga murojaat qilish to‘g‘risidagi masalani kun tartibiga kiritdi. Biroq Oliy Majlisi Senati Kengashining boshqa a’zolari Kengash raisining taklifiga e’tiroz bildirib, parlamentning yuqori palatasi 100 nafar a’zodan ortiq tarkibda ham faoliyat yuritishi qonunchilikka zid emasligini ta’kidlab o‘tdilar.
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 28, Question = @"2019-yil 15-sentabr kuni Y. Olimov Toshkent shahriga vaqtinchalik xizmat vazifasini bajarish uchun oilasi bilan ko‘chib keldi. Uchastka noziri 5 kun ichida turgan joyi bo‘yicha hisobga turishi lozimligini rasman ma’lum qildi. Y. Olimov doimiy ro‘yxatdan o‘tmoqchi bo‘lib hududdagi militsiya tayanch punktiga murojaat etganida uchastka inspektori Y. Olimovni Toshkent shahrida doimiy ro‘yxatdan o‘tishga huquqi yo‘qligini aytib, turgan joyi bo‘yicha ro‘yxatdan o‘tishi mumkinligini ta’kidlab o‘tdi. 
Y. Olimov turgan joyi bo‘icha ro‘yxatdan o‘tmoqchi bo‘lganda esa hujjatlardagi ayrim kamchiliklarni vaj qilib fuqaroning murojaatini rad etdi. 
Bundan norozi bo‘lgan Y. Olimov prokuratura organlariga murojaat qildi. U o‘z murojaatida O‘zbekiston Respublikasi Konstitutsiyasida fuqaro respublika hududida bir joydan ikkinchi joyga ko‘chish huquqi mavjud ekanligini qayd etdi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 29, Question = @"Fuqaro Smirnov “Istiqbol” xususiy firmasiga menejer lavozimiga ishga kirish uchun ariza bilan murojaat qildi. “Ictiqbol” xususiy firmasining rahbari Atavullayev Smirnovning davlat tili – o‘zbek tilini bilmasligini asos qilib, u bilan 3 oylik sinov muddati vaqtida, firmada tashkil qilingan to‘lov asosida o‘zbek tilini o‘rgatadigan kursda o‘qishini va o‘zbek tilini o‘rganganidan so‘ng ishga qabul qilishi mumkinligini aytdi.
Bu vaziyatdan norozi bo‘lgan Smirnov O‘zbekiston Respublikasi Konstitutsiyasi bo‘yicha uning mehnat qilish huquqlari poymol bo‘lganligini vaj qilib prokuraturaga murojaat qildi.
", Comment = "Vaziyatga huquqiy baho bering. O‘zbekiston Respublikasi Davlat tilining huquqiy maqomini muhokama qiling." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 30, Question = @"Medol MChJ tijorat siri bilan hamda bevosita mijozlar bilan aloqa qiladigan lavozimda ishlaydigan sobiq xodimi S.Raxmatovga murojaat etib, jamiyatda mehnat faoliyatini olib borgan paytda u bilan tuzilgan mehnat shartnomasi va qo‘shimcha moddiy javobgarlik to‘g‘risidagi kelishuvda mehnat shartnomasi bekor qilinganidan so‘ng raqobatchi bo‘lgan boshqa korxonada 3 yil davomida ishga joylashishi yoki ish beruvchi bo‘lgan tadbirkorlik subyektining biznes yo‘nalishi bilan bir xil bo‘lgan mehnat faoliyati bilan shug‘lllanish mumkin emasligini nazarda tutilganligini ma’lum qiladi.
S.Raxmatov 2019-yil 2-mart kunidan Medol MChJda mahsulotlarni realizatsiya qilish va mijozlar ma’lumot bazasini shakllantirish lavozimida mehnat faoliyatini yuritib keldi.
S.Raxmatov 2020-yil oktabr oyida Medol MChJ bilan mehnat shartnomasini bekor qildi.
Shundan so‘ng S.Raxmatov 2021-yil fevral oyida Medol MChJning raqobatchisi hisoblangan FarmKonsalt MChJga mahsulotlarni realizatsiya qilish va mijozlar ma’lumot bazasini shakllantirish lavozimida ish boshladi.
S.Raxmatov Medol MChJning murojaatiga javoban O‘zbekiston Respublikasining Konstitutsiyasiga ko‘ra erkin kasb tanlash, tadbirkorlik erkinligi, mehnat qilish huquqiga ega ekanini aytib, mazkur konstitutsiyaviy huquqini hech kim cheklashi mumkin emasligini ma’lum qildi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 31, Question = @"Toshkent shahar Adliya boshqarmasida davlat ro‘yxatidan o‘tgan “Buloq” nodavlat notijorat tashkiloti aholini toza ichimlik suvi bilan ta’minlash sohasidagi qonuniy huquq va manfaatlarini himoya qilish maqsadida 2014-yilda tuzilgan. Mazkur nodavlat notijorat tashkilot bir necha bor davlat tomonidan qo‘llab-quvvatlanishga erishish maqsadida nodavlat notijorat tashkilotlar va fuqarolik jamiyatining boshqa institutlarini qo‘llab-quvvatlash jamoat fondi mablag‘larini boshqarish bo‘yicha Parlament komissiyasiga hujjatlar topshirdi. 
Biroq, har doimgidek Parlament komissiyasi mazkur tashkilotga mablag‘ ajratish masalasida rad javobi berib kelar edi. Davlat granti olish bo‘yicha berilgan oxirgi murojaat ham ijobiy hal bo‘lmagandan keyin “Buloq” nodavlat notijorat tashkiloti a’zolari umumiy yig‘ilish chaqirish hamda yig‘ilish kun tartibiga tashkilotni ixtiyoriy tugatish haqida masalasini kiritish taklifini ilgari surishdi.
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 32,
                Question = @"2020-yil 10-yanvar kuni hududiy boshqarmalardan biriga A.Qayumov rahbar etib tayinlandi. A.Qayumov o‘zidan oldinroq ish boshlagan boshqa xodimlarga nisbatan tegishli sohada yetarlicha tajribaga ega emas edi. 
Boshqarma xodimlarining aksariyati ayollar edi. Yosh boshliq xodimlarning katta amaliy va hayotiy tajribasi, shuningdek, yoshiga e’tibor qaratmay, biroq ular ayollar ekanligini e’tibor olib, ularga texnik tusdagi ishlarni topshira boshladi. Xodimalarining muhim hujjatlar bilan ishlay olmaydi deb hisoblab, tahliliy ishlarga erkak xodimlarini jalb qilishni boshladi. 
Bundan norozi bo‘lgan xodimalar yuqori tashkilotga shikoyat bilan murojaat qildilar. ",
                Comment = "Vaziyatga huquqiy baho bering."
            });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 33, Question = @"Deputatlikka nomzodlar Markaziy saylov komissiyasi tomonidan ro‘yxatga olingan kundan boshlab, fuqaro Z.Saidov saylovoldi tashviqoti ‒ saylov kompaniyasi davrida siyosiy partiyani yoqlab ovoz berishga undashga qaratilgan faoliyat olib bora boshladi. U o‘z targ‘ibotida A. partiyani davlat partiyasi sifatida e’lon qildi. O‘zining fikriga asos sifatida amaldagi Prezident va hukumat mazkur partiya vakillari ekanligini keltirdi. Bu borada u nomzod A.Mansurovning siyosiy raqibi bo‘lgan J.Komilovning B. siyosiy partiyasini “muxolifatchi partiya” deb atadi. J.Komilov bundan xabar topgach A. partiyani sudga berdi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 34, Question = @"2019-yil 15-mart sanasida O‘zbekiston Respublikasida davlat va jamiyat hayotiga doir muhim masala referendumga qo‘yildi. Toshkent shahar Uchtepa tumanida vaqtinchalik ro‘yxatda turuvchi O‘zbekiston Respublikasi fuqarosi B.Saidov referendumda ovoz berish uchun borganda ovoz beruvchilar ro‘yxatida uning ismi sharifi yo‘qligi ma’lum bo‘ldi. Ovoz berish uchastkasi kotibi B.Saidovni u yashash joyida vaqtinchalik ro‘yxatda turganligi tufayli saylovchilar ro‘yxatiga kiritilmaganini ma’lum qildi. Komissiya kotibi tomonidan fuqaroga doimiy turar joyida tashkil etilgan ovoz berish uchastkasida referendumda qatnashishi mumkinligi to‘g‘risida ma’lumot berildi. Bundan norozi bo‘lgan fuqaro B.Saidov prokuratura organiga shikoyat qildi. Prokuratura xodimi ushbu masala sudga tegishli deb shikoyatni rad etdi. Bu orada referendum tugab, natijalar chiqdi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 35, Question = @"Ma’lum qilinishicha, aholi 5ta mezon asosida “Temir daftar”ga kiritib borilmoqda. Prezidentning 2020-yil 26-avgustdagi “Aholini ijtimoiy qo‘llab-quvvatlashga qaratilgan qo‘shimcha chora-tadbirlar to‘g‘risida”gi qarori bilan O‘zbekistondagi uch toifa, xususan “Temir daftar”dagi oilalar farzandlariga 500 ming so‘mdan pul tarqatish belgilandi.
Ushbu bir martalik moddiy yordam ko‘rsatilishidan xabar topgan “Kamolon” mahallasining o‘ziga to‘q, moddiy sharoiti yaxshi ahvolda bo‘lgan 5 nafar fuqarolari ushbu qarordan norozi bo‘lishdi. Ular ushbu yordam Konstitutsiyada belgilangan ijtimoiy tenglik tamoyillariga zid bo‘lib, pandemiya davrida barchaga birdek moddiy yordam ko‘rsatilishi kerak deb hisoblashdi. Shu tufayli ular moddiy yordam so‘rab mahalla fuqarolar yig‘iniga murojaat qilishdi. Rad javobi olgach, prokuraturaga MFY raisining qarori ustidan shikoyat bilan murojaat etishdi. 
", Comment = "Vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 36, Question = @"Fuqaro U. Davronov Toshkent shahar Olmazor tumanining mahallalaridan birida joylashgan jami 4 xonadan iborat uyda o‘zi va oilasidan tashqari ota-onasi hamda 2 nafar aka-ukalari va ularning oilalari bilan birga yashab kelar edi. Ushbu xonadonda jami 15 kishining yashashi har tomonlama noqulay edi.
Fuqaro U. Davronov 2019-yil 22-aprel kuni Toshkent shahar Olmazor tumani hokimining qabulida bo‘ldi. U hokimdan istiqomat qilib kelayotgan uyning qurilganiga 50 yildan oshgani, uyning hovlisi kichik ekani, xonalar soni oila a’zolariga mutanosib emasligini, shu bois mazkur uyda yashab kelayotgan har bir oilaga davlat hisobidan yangi qurilayotgan ko‘p qavatli uylardan alohida kvartira ajratib berilishini so‘radi. 
Olmazor tuman hokimi buning iloji yo‘q ekani, uy-joy sharoitlarini yaxshilashga muhtoj bo‘lgan fuqarolarning kreditga uy-joy olishlari uchun tegishli tartib qoidalar mavjudligi, fuqaro U. Davronov mazkur qoidalarga amal qilgan holda uy olishi mumkinligini aytdi. 
Fuqaro U. Davronov kreditga uy olishi uchun dastlabki badalni to‘lashga imkoniyati yo‘q ekani, biron joyda ishlamasligini ma’lum qildi. Olmazor tuman hokimiga O‘zbekiston Respublikasining Konstitutsiyasi muqaddimasida “respublika fuqarolarining munosib hayot kechirishlarini ta’minlashga intilib” degan so‘zlar davlat tomonidan moddiy qiyinchilikka duch kelgan, uy-joy sharoitlarini yaxshilashga muhtoj bo‘lgan fuqarolarga davlat hisobidan uy-joy berilishiga asos bo‘la olishi, agar unga va u bilan birga bir xonadonda yashab kelayotgan oilalarga davlat hisobidan uy-joy berilmasa, tegishli tartibda yuqori organlarga murojaat qilishini aytdi.
", Comment = @"Kazus yuzasidan topshiriq:
1.	Vaziyatga huquqiy baho bering.
2.	Javobingizni O‘zbekiston Respublikasining muqaddimasi hamda asosiy qismida mustahkamlangan inson va fuqarolarning huquq va erkinliklariga doir normalarni qiyosiy tahlil etgan holda asoslab bering." });



            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 37, Question = @"2019-yil 15-may kuni O‘zbekiston Respublikasi Oliy Majlisi tomonidan O‘zbekiston Respublikasining Ma’muriy javobgarlik to‘risidagi kodeksiga o‘zgartish kiritishni nazarda tutuvchi qonun qabul qilindi. Unga ko‘ra ichki ishlar organi xodimi asosli tarzda jinoyat sodir etishga moyil deb hisoblagan shaxs boshqa shaxslar bilan bir jamoat joyida to‘plansa, ichki ishlar organi xodimi ularning tarqalishiga buyruq berishi, ushbu buyruqqa bo‘ysunmagan shaxslarni javobgarlikka tortish chorasini ko‘rishga haqli ekani nazarda tutildi. Qonunning asosiy maqsadi shaharlarda jinoyat ko‘rsatkichini pasaytirish va xavfsiz hududlarni yaratish ekani, shuningdek bezorilik, odam o‘ldirish va giyohvand moddalar bilan bog‘liq jinoyatlarning oldini olishga qaratilgani aytildi. 
2019-yil 1-iyun kuni kechki soat 21.00 da oilaviy janjal sababli uydan asabiy holda chiqqan T. Vahobov Amir Temur hiyobonida sayr qilib yurar edi. Unga xotini qo‘ng‘iroq qilganda telefonda u bilan baland ovozda janjallashib ketdi. So‘ng o‘rtog‘iga qo‘ng‘iroq qilib Amir Temur hiyoboniga kelishini va u bilan gaplashadigan gapi borligini aytdi. O‘rtog‘i R. Mansurov aytgan joyga yetib keldi. Ushbu holatni boshidan kuzatib turgan ichki ishlar organi xodimi ularni jinoyat sodir etishga moyil shaxslar deb topdi va ularning yoniga kelib tarqalishlarini buyurdi. 
T. Vahobov bunga qarshilik ko‘rsatdi. Shunda ichki ishlar organi xodimi tomonidan unga O‘zbekiston Respublikasining Ma’muriy javobgarlik kodeksida ko‘rsatilgan huquqbuzarlikni sodir etgani uchun bayonnoma rasmiylashtirdi. 
Keyinchalik T.Vahobov O‘zbekiston Respublikasi Konstitutsiyaviy sudiga murojaat qildi. Murojaatda 2019-yil 15-mayda qabul qilingan qonun insonning respublika hududida bir joydan ikkinchi joyga ko‘chish, shuningdek erkinlik va shaxsiy daxlsizlik singari konstitutsiyaviy huquqlarini poymol etgani sababli mazkur qonunni O‘zbekiston Respublikasining Konstitutsiyasiga zid deb topishni so‘radi.
", Comment = @"Kazus yuzasidan topshiriq:
1.	Siz O‘zbekiston Respublikasi Konstitutsiyaviy sud sudyasi bo‘lganingizda 2019-yil 15-may kuni O‘zbekiston Respublikasi Oliy Majlisi tomonidan qabul qilingan O‘zbekiston Respublikasining Ma’muriy javobgarlik to‘risidagi kodeksiga o‘zgartish kiritishni nazarda tutuvchi qonunni O‘zbekiston Respublikasining Konstitutsiyasiga mos deb hisoblagan bo‘larmidingiz? Fikringizni asoslang.
2.	Yuqoridagi savol yuzasidan xulosaga kelish uchun O‘zbekiston Respublikasining Konstitutsiyasining tegishli normalarini sharhlash lozim. Bunda siz sharhlashning qanday usullaridan foydalangan bo‘lar edingiz?" });


            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 38, Question = @"O‘zbekiston Respublikasi Oliy Majlisining Qonunchilik palatasiga kelib tushgan qonun loyihasi uch o‘qishda qabul qilinib, ma’qullash uchun O‘zbekiston Respublikasi Oliy Majlisining Senatiga yuborildi. Biroq, qonun loyihasi Senat tomonidan rad etilib, Qonunchilik palatasiga qaytarildi.
Senat tomonidan rad etilgan qonun qayta ko‘rib chiqilib, Qonunchilik palatasi deputatlar umumiy sonining uchdan ikki qismidan iborat ko‘pchilik ovozi bilan yana ma’qullandi hamda Senatga yuborildi.
", Comment = "Vaziyatga huquqiy baho bering. Qonun qabul qilish tartibi va jarayonini normativ-huquqiy hujjatlar asosida tahlil qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 39, Question = @"O‘zbekiston Respublikasi Bosh vaziri va Oliy Majlisi Qonunchilik palatasi o‘rtasida qat’iy ziddiyatlar paydo bo‘lgani tufayli Prezidentga ishonchsizlik votumi berish to‘g‘risida rasmiy taklif kiritildi. Qonunchilik palatasi deputatlari umumiy sonining kamida uchdan bir qismi miqdori ishtirokida davlat rahbari ushbu taklifni ko‘rib chiqib, uni Oliy Majlis palatalarining qo‘shma majlisi muhokamasiga taqdim etdi va parlament palatalari Bosh vazirga ishonch bildirmadi. Natijada Vazirlar Mahkamasi iste’foga chiqdi. Biroq, hukumatning iste’fosi davlat hokimiyati organlari raislariga, xususan, ijro etuvchi hokimiyatning ajralmas qismlari hisoblangan va iyerarxik ravishda Vazirlar Mahkamasiga bo‘ysunadigan qo‘mitalar, idoralar, komissiyalar va markazlarga ta’sir qilmadi va ular o‘z joylarida qoldi.
 ", Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 40, Question = @"“Staples” MChJ  o‘z reklamasida O‘zbekiston Respublikasi gerbi tasviri va davlat madhiyasidan foydalanish uchun O‘zbekiston Respublikasi Oliy Majlisi Senatidan ruxsat oldi. Toshkent shahar hokimining o‘rinbosari Senatga “O‘zbekiston Respublikasining Davlat bayrog‘i to‘g‘risida”gi va “O‘zbekiston Respublikasining Davlat madhiyasi to‘g‘risida”gi O‘zbekiston Respublikasi qonunlari buzilganligi to‘g‘risida taqdimnoma kiritdi va davlat ramzlari bo‘lmish gerb va bayroqdan tijorat faoliyatida foydalanish mumkin emasligini ta’kidladi. 
", Comment = "Ushbu vaziyatni Konstitutsiyaviy huquq normalari asosida tahlil qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 41, Question = @"O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasiga 2014 yilning 21 dekabr kuni bo‘lib o‘tgan saylovlardan so‘ng qonunchilikda belgilangan tartibda O‘zbekiston Respublikasi Bosh vaziri tasdiqlandi va u O‘zbekiston Respublikasi Prezidenti bilan kelishilgan holda O‘zbekiston Respublikasi Vazirlar Mahkamasi tarkibini shakllantiridi. Hukumat tarkibi shakllantirilganidan so‘ng, bir qator vazirlar va davlat qo‘mitalari raislarining o‘rinbosarlari, shuningdek davlat boshqaruvining boshqa organlari rahbarlari O‘zbekiston Respublikasi Prezidenti tomonidan to‘g‘ridan-to‘g‘ri lavozimga tayinlanadi. Biroq, O‘zbekiston Respublikasi Bosh vaziri O‘zbekiston Respublikasi Konstitutsiyasiga muvofiq, Vazirlar Mahkamasi faoliyatini tashkil etishi va unga rahbarlik qilishi, uning samarali ishlashi uchun javobgar shaxs ekanligini ko‘rsatdi hamda ushbu lavozimlarga nomzodlar ham u bilan kelishilishi lozimligi haqida fikrlar paydo bo`ldi. 
", Comment = @"Vaziyatga huquqiy baho bering. 
Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 42, Question = @"Fuqaro A.Murodov o‘z avtomashinasini to‘xtash taqiqlangan belgi zonasiga to‘xtatib qo‘yganligi munosabati bilan YPX maxsus xizmati tomonidan avtomobili evakuatsiya qilingan. A.Murodov maxsus yo‘l harakati xavfsizligi xizmati xodimlarining xatti-harakatlari Konstitutsiyada kafolatlangan mulk huquqini buzganligi sababli ularni qonunga xilof deb hisoblab, Konstitutsiyaviy sudga uning masalasini ayrim toifali ishlar bo‘yicha ish yuritish jarayonida ko‘rib chiqish talabi bilan murojaat qilgan. Konstitutsiyaviy sud vakolati doirasida faqat muayyan ishda qo‘llanilgan yoki qo‘llanilishi kerak bo‘lgan qonunlarning Konstitutsiyaga muvofiqligi yuzasidan ishlarni ko‘rib chiqishini ta’kidlab, masalani hal qilishdan bosh tortdi. Shuningdek, shikoyatda YPX xodimlarining xizmati borasida noaniqliklar mavjudligini ko‘rsatib, ushbu masala bo‘yicha YPX xizmatining Konstitutsiyaga zid harakatlari aniqlanmaganligini ta’kidladi.
", Comment = "Ayrim toifadagi ishlar bo‘yicha konstitutsiyaviy ish yuritish tartibi qanday? Ayrim toifadagi ishlar bo‘yicha protsessda konstitutsiyaviy shikoyat berish uchun talablar mavjudmi?" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 43, Question = @"“Bahor” mahalla fuqarolar yig‘ini raisi (oqsoqoli) va uning maslahatchilari saylovini tashkil etish hamda o‘tkazish uchun tuzilgan Ishchi guruh fuqarolar yig‘ini raisi (oqsoqoli) lavozimiga nomzodlarga doir hujjatlarni tayyorlab, tuman hokimi bilan kelishish uchun tegishli tuman komissiyasiga taqdim etdi. Tuman xokimi taqdim etilgan 5ta nomzodning hujjatlarini o‘rganib chiqdi hamda taqdim etilgan 3ta nomzodni nomunosib nomzod sifatida ro‘yxatdan chiqarish haqida ko‘rsatma berdi.
“Bahor” mahalla fuqarolar yig‘ini hududida istiqomat qiluvchi bir guruh fuqarolar tomonidan Ishchi guruhga tavsiya qilingan nomzod D.Jalilovning nomzodi ham tuman xokimi tomonidan ma’qullanmadi. Shu sababli, uning nomzodini qo‘llab-quvvatlovchi bir guruh fuqarolar D.Jalilovning buzilgan huquqlarini himoya qilishda yordam berishni so‘rab tuman prokuraturasiga  murojaat qilishdi.
", Comment = @"Vaziyatga huquqiy baho bering.
Fuqarolar yig‘ini raisi (oqsoqoli) nomzodlarini xokim bilan kelishish" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 44, Question = @"Qonun loyihasi O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi tomonidan uchinchi o‘qishda qabul qilinib, Senat tomonidan ma’qullanganidan so‘ng, O‘zbekiston Respublikasi Prezidentiga imzolash uchun yuborildi. Biroq davlat boshlig‘i o‘z e’tirozlari bilan Qonuni imzolamasdan qaytardi. Bunday holatda Oliy Majlis palatalari Qonunni avvalgi qabul qilingan tahririda qayta ovozga qo‘yish yoki davlat boshlig‘i e’tirozlari inobatga olgan holda uni qayta ishlab, so‘ng qabul qilishi lozim edi. Parlament palatalari birinchi yo‘lni tanladi. Qonun avvalgi tahrirda Qonunchilik palatasi deputatlari va Senati a’zolari umumiy sonining to‘rtdan uch qismidan iborat ko‘pchilik ovozi bilan ma’qullandi, ya’ni Prezident vetosi yengib o‘tildi. Biroq davlat boshlig‘i qayta ovoz berish protsedurasi qo‘pol ravishda buzilganligini ko‘rsatib Qonunni imzolamasdan qoldirdi.
", Comment = @"Vaziyatga huquqiy baho bering. 
Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 45, Question = @"Navoiy viloyati xalq deputatlari kengashining navbatdan tashqari sessiyasida Navoiy viloyati Karmana tumani hokimini o‘z vazifasidan ozod etildi. Hamda Navoiy viloyati Karmana tumaniga rahbarlik qilishni Vazirlar Mahkamasining qaroriga asosan tuman hokimi o‘z vazifasidan ozod etilganligi bois, ushbu hududga rahbarlikni Xatirchi tumani hokimiga topshirdi. Endilikda Xatirchi tumani hokimi ham Karmana tumaniga ham Xatirchi tumaniga rahbarlikni amalga oshira boshladi. 
Mazkur masala yuzasidan O‘zbekiston Respublikasi Oliy Majlis qonunchilik palatasi Vazirlar Mahkamasiga o‘z e’tirozini bildirgan holda mazkur holat amaldagi qonun me’yorlari talablariga muvofiq emasligini ko‘rsatgan holda ushbu qarorini noqonuniy deb hisoblagan holda bu holat ikki tumanning ma’muriy hududiy birligiga ham ma’lum bir ma’noda ta’sir ko‘rsatishini ya’ni birlashtirib yuborilishini anglatishini ta’kidladi.
", Comment = @"Vaziyatga huquqiy baho bering.
Vazirlar Mahkamasi tomonidan mazkur amalga oshirilgan holat amaldagi qonunchilik talablari doirasida qabul qilinganmi mazkur holatni muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 46, Question = @"Fuqaro F. o‘z oilasi bilan Uchtepa tumanidagi ko‘p qavatli uyda yashaydi. Uning keksa onasi davlat muassasasi (Qariyalar uyi) qaramog‘iga olingan. Onasi tuman sudiga murojat qilib o‘g‘li undan xabar olmayotganligidan shikoyat qiladi. 
Uchtepa tuman sudi F.ni chaqirtirib unga onasining holidan xabar olib turishi kerakligini, agar fuqaro o‘z konstitutsiyaviy majburiyatini bajarmasa va onasiga g‘amxo‘rlik qilmasa aliment to‘lash majburiyati yuklatilishini bildirib, ogohlantiradi. 
Fuqaro F. dam olish kuni oilasi bilan onasini ko‘rgani muassasaga boradi. Onasi fuqaro F.ga o‘zining ehtiyojlari uchun 1 000 000 (bir million) so‘m miqdorda pul zarurligini aytib, shu pulni berishini so‘raydi. Lekin fuqaro F. onasiga so‘ragan pulini berishdan bosh tortadi va onasini moddiy yordamga muhtoj emasligi chunki u davlat muassasasi qaramog‘ida ekanligini vaj qilib keltiradi.
", Comment = @"Ushbu vaziyatga huquqiy baho bering. 
F.ning xatti-harakatlari qonuniymi? Buni huquqiy asoslarini muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 47, Question = @"Gazeta jurnalisti F.O. oziq-ovqat yarmarkasida holatni videotasvirga olish paytida Chinoz tumani hokimi o‘rinbosari uning qo‘lidan telefonni olishga harakat qilgan.  Keyinroq uni tuman ichki ishlar bo‘limiga olib keltirgan va ushlab turgan.  IIB binosida jurnalistning telefon qurilmasidagi videoyozuvlar o‘chirib tashlangan. 
Jurnalist o‘zining huquq-erkinliklari qo‘pol buzilishi borasida huquqiy baho berishni so‘rab Bosh prokuraturaga murojaat qildi. 
Jurnalist faoliyatiga to‘sqinlik qilib, jurnalistga qo‘pol munosabatda bo‘lgan hokimiyat vakili esa bu yerda o‘zining aybdor emasligini, o‘sha kuni yarmarkada anglashilmovchilik ro‘y berganini aytib, fuqarodan og‘zaki uzr so‘raydi. 
", Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qilib, vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 48, Question = @"2015 yil 18 iyun saylov o‘tkaziladigan kuni Jizzax viloyati telekanali xodimlari kelib saylov uchastkasidagi saylovchilarning fikr-mulohazalarni, birinchi navbatda, saylovchilardan nomzodga nima sabablar tufayli ovoz berayotganligini, saylovda kim yutib chiqishi haqidagi fikrlarni saylovchidan kelgusida nima natijalar kutayotganligini o‘rgana boshlanadi. O‘z navbatida viloyat telekanali xodimlari saylovning natijasi yuzasidan prognozlar chiqara boshladi. Shu payt saylov uchastkasi raisi bu holatdan xabar topib, telekanali xodimlaridan o‘z ishini to‘xtatishini, intervyu va reportajlar olishini taqiqladi. Viloyat telekanali xodimlari saylov uchastkasi raisi harakatlaridan norozi bo‘lib, saylov to‘g‘risidagi qonunchilik normalariga ko‘ra saylovlar ochiq, oshkoralik, erkinlik, adolatlilik, mas’ullik prinsiplariga asosan o‘tkazilishi lozimligini aytib e’tiroz bildirdi. Shuningdek, saylov uchastkasi raisi ustidan Markaziy saylov komissiyaga shikoyat qilishini bildirdi.
", Comment = @"Vaziyatga huquqiy baho bering.
 Ushbu holatda qaysi qonun hujjatlari buzilganligini muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 49, Question = @"Mirobod tumanida yashovchi fuqaro A. 2012 yil noyabr oyida tuman hokimiyatiga murojat qilib farzand asrab olmoqchiligini aytadi. Tuman hokimiyati unga o‘zi xaqidagi ma’lumotlarni berishi va ish joyidan ma’lumotnoma olib kelishligini so‘raydi. Fuqaro A. aytilgan barcha hujjatlarni olib keladi, lekin hujjatlar ichida fuqaro A. qaerda ishlashi haqidagi ma’lumotnoma chiqmaydi. Shundan so‘ng tuman hokimiyati xodimi unga hujjatlarida kamchiligi borligini aytib, agarda, u tegishli hujjatlarni ikki kun ichida olib kelmasa unga farzand asrab olishga ruxsat berilmasligini aytadi. Ayrim mutaxassislar sudga bu masalada murojaat etishni bildirdilar. Fuqaro A ushbu holat yuzasidan O‘zbekiston Respublikasi Konstitutsiyaviy sudiga murojaat qiladi va o‘zining konstitutsiyaviy huquqlari buzilganligidan e’tiroz bildiradi. O‘zbekiston Respublikasi Konstitutsiyaviy sudi ushbu murojaatda ko‘tarilgan masalalar fuqarolik ishlari bo‘yicha tumanlararo sud vakolatiga tegishli bo‘lganligi sababli, mazkur shikoyat Konstitutsiyaviy sud vakolat doirasiga kirmasligini bildirdi. 
", Comment = @"Ushbu vaziyatga huquqiy baho bering. 
Ushbu vaziyatda Konstitutsiyaviy sudning Fuqaro A.ga yo‘llagan javobi qonuniymi? Tegishli huquqiy hujjatlar asosida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 50, Question = @"O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasiga bo‘lib saylov natijalariga ko‘ra, hech bir nomzod qonunda nazarda tutilgan yetarli ovozlarni to‘play olmaganligi tufayli 35 ta saylov okrugida takroriy ovoz berish hamda 5 ta saylov okrugidan saylovlar jarayonida qonun buzilishlariga yo‘l qo‘yilganligi tufayli takroriy saylov o‘tkazish zarurligi ma’lum bo‘ldi. 
Boshqa saylov okruglardan saylangan ayrim deputatlar esa ushbu saylov okruglarida takroriy ovoz berish va takroriy saylov natijalari ma’lum bo‘lmasdan turib ham Oliy Majlis Qonunchilik palatasini saylangan va o‘z faoliyatini boshlashi mumkin deb hisoblab, Markaziy saylov komissiyasi raisiga Qonunchilik palatasining birinchi majlisini chaqirish, palata rahbar organlari va qo‘mitalari tarkibini shakllantirish   to‘g‘risida ariza bilan murojaat qilishdi. Markaziy saylov komissiyasi raisi mazkur arizaga nisbatan rad javobini berdi. 
", Comment = @"Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qilib, vaziyatga huquqiy baho bering.
 Saylangan deputatlarning talablari asoslimi? Mazkur holat qanday hal qilinishi lozim?" });*/

            #endregion

            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатасини шакллантириш тартибини амалдаги қонунчилик асосида ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Ўзбекистон Республикаси Олий Мажлиси Сенатининг шакллантириш тартибини амалдаги қонунчилик асосида ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Ўзбекистон Республикасида қонунчилик ташаббуси ҳуқуқига эга бўлган субъектлар қайсилар? Уларнинг ўзига хос хусусиятларини изоҳлаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси фаолиятини ташкил этиш тартиби ва унинг таркибий тузилмалари ҳақида атрофлича тўхталиб ўтинг. Янги таҳрирдаги Конституцияда Олий мажлис Қонунчилик палатаси фаолиятига оид қандай ўзгартиришлар киритилди?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси депутати ва Сенат аъзоси ваколатларини муддатидан илгари тугатиш асосларини ва қай тартибда амалга оширилишини ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Ўзбекистон Республикасида маҳаллий ўзини ўзи бошқариш органлари қандай ташкилотларни ўз ичига олади? Маҳаллий ўзини ўзи бошқариш органлари фаолияти асосларини очиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Ўзбекистон Республикаси прокуратура органларининг тизими қандай ва ваколатларини тушунтиринг. Уларнинг давлат органлари тизимида тутган ўрни ва аҳамиятини очиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Референдум нима? Мамлакатимизда референдумни ўтказишнинг ҳуқуқий асосларини айтиб беринг. Мамлакатимизда ўтказилган референдумлар ҳақида нималарни биласиз?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Ўзбекистон Республикаси прокуратура органлари ваколатлари ва фаолияти қандай принципларга асосланганлигини очиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Ўзбекистон Республикаси ҳудудида тезкор-қидирув, тергов ва бошқа вазифаларни бажарувчи хусусий ташкилотлар тузиш ва уларнинг фаолияти тақиқланиши ҳақидаги нормага нисбатан фикрларингизни баён этинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "“Миранда қоидаси” нима ва янги таҳрирдаги Конституцияда унга оид қандай норма мавжуд?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Ўзбекистонда сайлов тизимини такомиллаштириш борасида олиб борилаётган ислоҳотлар мазмунига ҳуқуқий тавсиф беринг. Янги таҳрирдаги Конституцияга кўра таҳлил қилинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Фуқароларнинг олий таълим муассасаларида давлат ҳисобидан таълим олиши ва инклюзив таълим ҳақида тушунча беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Ўзбекистон Республикаси Олий Мажлиси томонидан Конституцияга ўзгартишлар киритиш ҳақидаги қонун, конституциявий қонун, қонун ҳамда қарорларни қабул қилишда ўхшаш ва фарқли жиҳатларни таҳлил этиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Конституциявий ҳуқуқнинг жамият ва давлат қурилиши соҳасидаги аҳамиятини қай даражада эканлигини ҳуқуқий жиҳатдан ифодалаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Жаҳонда конституциялар пайдо бўлишининг асосий зарурияти нимада ва улар пайдо бўлганидан сўнг қандай ижобий ўзгаришлар бўлди? Бугунги кунда инсон ҳаёти учун конституция қанчалик муҳим?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Конституциявий ҳуқуқ фанининг бошқа ҳуқуқий фанлар билан алоқасини ҳуқуқий жиҳатдан асослаб беринг. Ушбу алоқадорлик амалиётда қандай ўз ифодасини топган? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Конституциявий ҳуқуқ манбаларига нималар киради? Ушбу манбалар нима учун конституциявий ҳуқуқ манбаси бўлиб хизмат қилишини асослаб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Конституция муқаддимаси ғояларининг конституция нормаларида қанчалик акс этганлиги хусусида сўз юритинг. Ушбу ғояларнинг ижтимоий муносабатлардаги ўрнини ҳуқуқий жиҳатдан изоҳлаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Ўзбекистон Республикасида судьяларни сайлаш ва тайинлаш тартибини тушунтириб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Хабеас корпус тушунчаси ва унинг конституциявий асоси ҳақида фикр юритинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Ўзбекистон Республикаси Олий суди Пленумининг таркибий тузилиши ва ваколатларини муҳокама қилинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Ўзбекистон Республикасида  адвокатура институтининг конституциявий-ҳуқуқий асосларини ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "Ногиронлиги бўлган шахсларнинг ҳуқуқлари ҳақида атрофлича фикр юритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Конституциянинг моҳияти ва унинг асосий белгилари нималардан иборат? Конституциянинг функциялари ва принциплари ҳақида қисқача тўхталинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Ҳокимиятлар бўлиниши принципини Конституция асосида таҳлил қилинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Хусусий мулкнинг дахлсизлиги, унинг давлат томонидан ҳимояланишининг ҳуқуқий асослари  ва хусусий мулк ҳуқуқининг қонунга мувофиқ бекор бўлиши оқибатларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = " Конституциянинг қандай турлари мавжуд? Конституциянинг турлари бир-биридан мазмун жиҳатдан қандай фарқланади?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "Мустақилликнинг илк йиллари Ўзбекистон Республикаси Конституциясининг лойиҳасини ишлаб чиқиш тарихини ёритиб беринг. Янги таҳрирдаги Конституцияни қабул қилишдаги ижтимоий зарурат қандай эди? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Ўзбекистон Республикаси Конституциясига ўзгартириш киритиш тартибини қонунчилик доирасида батафсил ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Ўзбекистон Республикаси ҳуқуқий, ижтимоий ва дунёвий давлат деган конституциявий нормани батафсил ёритиб беринг ва мисоллар келтиринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Халқаро ҳуқуқнинг умумэътироф этилган нормаларини Ўзбекистон Республикаси Конституциясида ўз ифодасини топиши хусусида батафсил мулоҳаза юритинг. Халқаро шартномалар Ўзбекистон Республикаси Конституциясига зид келганда, Республикамиз ҳудудида қайси ҳужжат орқали иш кўрилади?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Ўзбекистон Республикаси Олий суди Раёсати ва унинг ваколатларини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Ўзбекистонда суд ҳокимияти мустақиллигини таъминлаш масаласи қонунчиликда қандай ўз ифодасини топган? Судьялар корпуси қандай тартибда шакллантирилади?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси депутати ва Сенати аъзосининг ҳуқуқлари ва мажбуриятлари нималардан иборат?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Норматив-ҳуқуқий ҳужжатлар турларини ёритиб беринг. Мазкур тизимда Ўзбекистон Республикаси қонунчилик тизимида Конституциясининг тутган ўрнига ҳуқуқий тавсиф беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Ўзбекистон Республикаси Олий Мажлиси палаталарининг Ўзбекистон Республикасининг маъмурий-ҳудудий тузилиши соҳасидаги ваколатлари нималардан иборат? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Ўзбекистон Республикаси давлат рамзлари: байроқ, мадҳия ва гербнинг қабул қилиниши хусусида фикр билдиринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Давлат органлари ва мансабдор шахсларнинг жамият ва фуқаролар олдида масъуллиги нималарда намоён бўлади? Масъулият ва жавобгарлик масалаларига ҳуқуқий тавсиф берган ҳолда ҳаётий мисоллар келтиринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Ўзбекистон Республикасида давлат ҳокимиятини амалга ошириш деганда нимани тушунасиз ва давлат фаолиятининг асосий принципларини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Халқ ҳокимиятчилиги деганда нимани тушунасиз? Халқ ҳокимиятчилигининг мазмун ва моҳиятини батафсил ёритиб беринг. Сизнингча, демократиянинг тўлақонли ишлаши давлат учун хавф туғдирадими?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Ўзбекистон Республикасида Бош вазирининг лавозимига тасдиқланиши ва вазифасидан озод қилиш тартибини қонунчилик доирасида ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Ўзбекистон Республикасида Бош вазирга ишончсизлик вотумини билдириш қай тартибда амалга оширилади?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Ҳукуматни парламент олдида ҳисоб бериши масаласига ҳуқуқий тавсиф беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Ўзбекистон Республикаси Судьялар Олий Кенгашининг асосий вазифаларини қонунчиликка мувофиқ ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Маҳаллий давлат ҳокимияти фаолиятининг конституциявий-ҳуқуқий асосларига ҳуқуқий тавсиф беринг. Маҳаллий вакиллик ва ижроия ҳокимияти бошлиғини лавозимига тайинлаш ва лавозимдан озод этиш қандай амалга оширилишини изоҳланг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Ҳокимларнинг тегишли ҳудудда ижтимоий-иқтисодий ривожланишининг энг муҳим ва долзарб масалалари юзасидан ҳисоботини халқ депутатлари Кенгаши томонидан эшитиш тартибини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Давлат ҳокимиятининг бўлиниши принципи деганда нимани тушунасиз? Ушбу принципнинг мазмун ва моҳиятига тўхталинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Жамоатчилик назорати деганда нимани тушунасиз? Жамоатчилик назорати субъектлари кимлар ва мазкур назоратни амалга оширишнинг қандай шакллари мавжуд?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Ўзбекистон Республикаси Олий Мажлиси палаталарининг ўзаро муносабатларини Конституция ва қонунчилик асосида атрофлича таҳлил қилинг. Ушбу муносабатларни амалий нуқтаи назардан ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Конституция ва қонунларнинг устунлиги деганда нимани тушунасиз? Ўзбекистон Республикасида Конституция ва қонунларнинг устунлигини таъминланиш масалаларига атрофлича тўхталинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Ўзбекистон Республикасида Инсон ҳуқуқлари бўйича вакил (Омбудсман)нинг ҳуқуқий мақоми ва фаолияти йўналишларини батафсил ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Шахсий ҳаёт дахлсизлиги деганда нимани тушунасиз? Шахсий ҳаёт дахлсизлигини Ўзбекистон Республикаси Конституцияси ва қонунчилигидаги ифодаси ҳақида тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Виждон ва эътиқод эркинлиги деганда нимани тушунасиз? Ўзбекистонда виждон ва эътиқод эркинлигининг конституциявий кафолатларини таҳлил қилинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Сўз ва фикр эркинлиги деганда нимани тушунасиз? Сўз ва фикр эркинлигининг ҳуқуқий кафолатланиши хусусида фикр-мулоҳазаларингизни билдиринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Инсон билан давлат органларининг ўзаро муносабатларида юзага келадиган қонунчиликдаги барча зиддиятлар ва ноаниқликлар инсон фойдасига талқин этилиши ҳақида гапириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Конституцияда белгиланган қонунийлик, ижтимоий адолат ва бирдамлик принциплари деганда нимани тушунасиз? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Ўзбекистон Республикаси Конституциясига мувофиқ ташқи сиёсатнинг асосий принциплари қандай? Уларнинг ўзига хос хусусиятларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Ватандош тушунчаси нима? Уларга нисбатан фуқароликка оид қонунчилик ҳужжатлари қандай тартибда қўлланилади ?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Ўзбекистон Республикасининг Конституциясида инсон ва фуқароларнинг ҳуқуқ ва эркинликлари ҳар кимга туғилганидан бошлаб берилиши ҳақидаги нормани атрофлича муҳокама қилинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Ҳуқуқ ва эркинликларнинг конституциявий чекланиши асослари ва тартибини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Сиёсий ҳуқуқ ва эркинликлар тушунчасини ёритиб беринг. Сиёсий ҳуқуқ ва эркинликларнинг қандай кўринишлари мавжуд? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Ўзбекистон Республикасининг фуқаролари давлат хизматига кришда тенг ҳуқуқлилигини қонун ҳужжатларига асосан таҳлил қилинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Ўзбекистон Республикаси Олий Мажлиси Сенати Раисининг ваколатларига тавсиф беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси Спикерининг ваколатларига тавсиф беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси ва Сенатининг қўшма қарори билан парламент текшируви ўтказиладиган ҳолатлар ҳақида фикрларингизни баён этинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатасини шакллантириш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Ҳар ким уй-жойга эга бўлиш ҳуқуқига эгалиги ҳақидаги нормани изоҳланг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Илмий, техникавий ва бадиий ижод эркинлигининг қандай кўринишлари мавжуд?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Ҳар ким қулай атроф-муҳит ҳолати тўғрисида ишончли ахборотга эга бўлиш ҳуқуқининг мазмун-моҳиятини тушунтириб беринг? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Ўзбекистон Республикаси фуқаролиги деганда нимани тушунасиз? Ўзбекистон Республикаси фуқаролигининг ҳуқуқий асосларини ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Фуқароликка эга бўлиш ва йўқотиш асосларини кўрсатиб беринг. Бу асослар амалиётда қайдай ўз ифодасини топган?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Давлат қулай инвестициявий ва ишбилармонлик муҳитини яратиши ҳақидаги нормани қонун ҳужжатлари асосида ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Мулкка эгалик қилиш, фойдаланиш, тасарруф қилиш, мулкдан маҳрум қилиш деганда нимани тушунасиз? Ушбу тушунчаларга ҳуқуқий жиҳатдан тавсиф беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Жамоат бирлашмалари деганда нимани тушунасиз? Жамоат бирлашмаларининг фуқаролик жамиятини шакллантиришдаги аҳамиятини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Сиёсий партиялар деганда нимани тушунасиз? Сиёсий партиялар фаолиятининг конституциявий ва ҳуқуқий асосларини батафсил муҳокама қилинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Жамоат бирлашмаларини давлат томонидан қўллаб-қувватлаш шакллари ва ҳуқуқий асосларини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "Ўзбекистон Республикаси Президентининг ваколатларини мазмун-моҳиятини уларни таснифлаган ҳолда ёритиб беринг?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "Ўзбекистон Республикаси Президенти томонидан қабул қилинадиган норматив-ҳуқуқий ҳужжатларни атрофлича таҳлил қилиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "Ўзбекистон Республикаси Президентининг давлат ҳокимияти органларини келишилган ҳолда фаолият юритишини ҳамда ҳамкорлигини таъминлаш функцияси амалиётда ўзининг қандай ифодасига эга? Ушбу функция қонунчилигимизда қачон жорий этилди?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Ўзбекистон Республикаси Вазирлар Маҳкамасининг шаклланиш тартиби ва ҳуқуқий асослари ҳақида гапириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Ўзбекистон Республикаси Вазирлар Маҳкамаси вазифаларининг конституциявий асосларини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Нодавлат нотижорат ташкилотларнинг ҳуқуқий мақомини Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "Ўзбекистон Республикасида демократик институтлар тизимида оммавий ахборот воситаларининг ўрни ва аҳамиятини ёритиб беринг. Оммавий ахборот воситаларини тартибга солувчи ҳуқуқий асосларга тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Оммавий ахборот воситалари фаолиятининг ҳуқуқий асосларини батафсил муҳокама қилинг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "Ўзбекистон Республикасида оила институтининг конституциявий мақомини батафсил ёритиб беринг. Оиланинг жамият ва давлат ҳаётидаги ўрнини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Ота-она ва фарзандларнинг бурчлари деганда нимани тушунасиз? Ўзбекистон Республикаси Конституциясига мувофиқ ота-она ва фарзандларнинг бурчлари моҳиятини муҳокама қилинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Конституциявий ҳуқуқнинг етакчи ҳуқуқ соҳаси сифатидаги ўрнини ёритиб беринг. Конституциявий ҳуқуқнинг жамият ва давлат қурилиши соҳасидаги аҳамиятини ҳуқуқий жиҳатдан тавсифлаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Суд орқали ҳуқуқ ва эркинликларни ҳимоя қилиш деганда нимани тушунасиз? Ҳуқуқ ва эркинликларни яна қандай йўллар билан ҳимоя қилиш мумкин?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Ўзбекистон Республикаси Конституциявий судининг ваколатларини батафсил ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Жисмоний ва юридик шахсларнинг мурожаатлари деганда нимани тушунасиз? Давлат органлари, муассасаларига ва халқ вакилларига мурожаат қилиш ҳуқуқининг мазмун-моҳиятини очиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Ҳокимият тармоқлари ўртасида тийиб туриш ва мувозанат сақлаш принципининг моҳияти ва аҳамиятини Ўзбекистон Республикаси Конституцияси нормаларига таянган ҳолда ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Сайлов ҳуқуқи деганда нимани тушунасиз? Мажоритар ва пропорционал сайлов тизимининг мазмун-моҳиятини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Депутат ва Сенат аъзоси дахлсизлик ҳуқуқининг мазмун-моҳиятини тушунтириб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Қонунчилик жараёни ва унинг босқичларини батафсил ёритиб беринг. Қонунчилик ташаббуси субъектларини айтиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Парламент фаолиятида келишув комиссияси тузишдан кўзланган мақсад ва комиссияни тузиш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Қонунни имзолаш ва унинг кучга кириши тартибини қонунчилик доирасида батафсил ёритиб беринг. Ушбу жараённи тартибга солувчи ҳуқуқий асосларни ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Ўзбекистон Республикаси Президентининг конституциявий-ҳуқуқий мақомини ёритиб беринг. Ўзбекистон Республикаси Президенти фаолиятини тартибга солувчи ҳуқуқий асосларга тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Ўзбекистон Республикаси Президенти сайловини ташкил этиш ва ўтказиш тартибини батафсил ёритиб беринг. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Марказий банкнинг ваколатлари ва ўз фаолиятини бажарашидаги мустақиллигига изоҳ беринг. " });


            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 1,
                Question = "2024-йил 4-феврал куни Ж.Х. М.К билан никоҳ тузиш учун Фуқаролик ҳолати далолатномаларини қайд этиш бўлимига мурожаат қилди. Фуқаролик ҳолати далолатномаларини қайд этиш бўлими мудираси никоҳ тузиш тартибини тушунтирди. Биринчидан, никоҳ тузиш учун ёзма розилик бўлиши, иккинчидан, никоҳ тузиш учун ариза берилгандан кейин уч ойлик муддат белгиланиши, учинчидан, никоҳ никоҳланувчиларнинг шахсан иштирокида қайд этилиши ва никоҳни вакил ёки ишончнома орқали расмийлаштиришга йўл қўйилмаслигини тушунтирди. \r\nБироқ, Ж.Х. ва М.К қонунчиликда бир ойлик муддатнинг белгиланиши никоҳланувчи шахслар никоҳга эркин, ихтиёрий, тенглик ҳамда ўзга шахсларнинг мажбурловисиз кираётганлигини аниқлаштириш учун зарур эканлигини, улар бундай муддат белгиланмаса ҳам ўзаро розилик ва ихтиёрийлик асосида турмуш қурмоқчи эканликларини билдириб, никоҳни ариза берилган куниёқ рўйхатдан ўтказишни талаб қилдилар. Фуқаролик ҳолати далолатномаларини қайд этиш бўлими мудираси ушбу талабни рад этди. Ж.Х. қонун ҳужжатлари ижроси таъминланмаётганини асос қилиб, ҳудудий прокуратура органларига мурожаат қилди.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 2,
                Question = "2024-йил 17-январ  куни Тошкент шаҳрида яшовчи фуқаро А.Дониёров туман электр тармоқлари корхонасига электр ҳақини тўлаш учун борди. Касса ходимасига мурожаат қилиб, ўзининг қарздорлиги бўйича маълумот сўраб мурожаат қилганида ходима фуқарога рус тилида мурожаат қилди. А.Дониёров рус тилини билмаганлиги боис, у билан мулоқот қилолмади. Касса ходимасига ўзбек тилида сўзлаша олишини айтганда, у фақат рус тилида сўзлаша олишини айтиб, рус тилини билмаган А. Дониёров устидан кулди. \r\nА.Дониёров ушбу ҳолат юзасидан маъмуриятга арз қилмоқчи бўлганда, маъмуриятдагилар “бизда қоида шунақа” деган маънода унинг мурожаатини қаноатлантиришсиз қолдиришди. Бундан норози бўлган фуқаро А. Дониёров прокуратурага шикоят қилди.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 3,
                Question = "2023-йил 6-август куни фуқаро С.Сулаймонова бўш иш ўринлар мавжуд бўлган давлат ташкилотига иш сўраб мурожаат қилди. Ташкилот раҳбари фуқаро С.Сулаймоновадан маълумотнома олиб келишни сўради. Ташкилот раҳбари мазкур маълумотномада Фуқаро С.Сулаймованинг\r\n4 ёшли фарзанди борлигини важ сифатида кўрсатиб уни ишга қабул қилмади. Фуқаро С.Сулаймонова мазкур ҳолатда гендер тенглиги бузилган деб ҳисоблаб, туман Маҳалла ва оилани қўллаб-қувватлаш вазирлигига мурожаат қилди. Вазирлик мазкур низо бўйича ваколатли эмаслигини билдириб, С.Сулаймонова маъмурий ишлар бўйича судга мурожаат қилиши лозимлигини маълум қилди. \r\n",
                Comment = "Вазиятга амалдаги қонунчиликка асосланган ҳолда ҳуқуқий баҳо беринг."
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 4,
                Question = "Президент давлат ҳокимияти бошқарув органлари фаолиятини танқидий кўриб чиқди ва бир неча раҳбарларни лавозимидан озод қилди. Мавжуд бўш лавозимларни тўлдириш мақсадида давлат раҳбари конституциявий ваколатлари доирасида Ўзбекистон Республикаси Бош прокурори ва Марказий банки бошқарув раиси номзодлари кўриб чиқиш учун Олий Мажлис Қонунчилик палатасига, Давлат хавфсизлик хизмати раисини лавозимига номзодни маъқуллаш учун Олий Мажлис Сенатига, Конституциявий суд, Олий суд, Судьялар Олий кенгаши таркибларига номзодлар, шунингдек коррупцияга қарши курашиш ва монополияга қарши курашиш органлари раҳбарлигига номзодлар юзасидан маслаҳатлашувлар ўтказиш учун Олий Мажлис палаталарига тақдим қилди ва тегишли хулосалар асосида юқоридаги номзодларни лавозимига тайинлади. \r\nКонституциявий суд Президент қарорини Конституцияга мослигини ўрганиб чиқмоқчи бўлди. \r\n",
                Comment = "Ушбу ҳолатни Ўзбекистон Республикаси Конституцияси доирасида муҳокама қилиб, вазиятга ҳуқуқий баҳо беринг. Мазкур ҳолат қандай ҳал қилиниши лозим?\r\n   "
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 5,
                Question = "Фуқаро Салимов жиноят ишида гумонланиб ички ишлар ходимлари томонидан ушланди ва ушлаш давомида унга ҳеч қандай маълумот берилмади. 52 соат давом этган ушлаб туриш чоғида ҳам на Салимовга, на унинг адвокати ва яқин қариндошларига ушлаш сабаблари билан боғлиқ ҳеч қандай маълумот берилмади. Шунингдек, ички ишлар ходимлари ушлаб туриш давомида гумонланувчи ва унинг яқин қариндошларини кўришишларига ҳам рухсат беришмади. Бундан норози бўлган Салимовнинг яқин қариндошлари ҳудудий прокуратурага ички ишлар ходимлари хатти-ҳаракати устидан шикоят қилдилар.",
                Comment = "Вазиятга амалдаги қонунчиликдан асослар келтирган ҳолда ҳуқуқий баҳо беринг. Ички ишлар ходимларининг ҳаракатларига баҳо беринг. Ушбу ҳолатда Салимовнинг қандай ҳуқуқлари поймол қилинган. Ҳудудий прокуратура ушбу вазиятда қандай ҳаракат қилиши лозим."
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 6,
                Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатасига бўлиб ўтган сайлов натижаларига кўра, ҳеч бир номзод қонунда назарда тутилган етарли овозларни тўплай олмаганлиги туфайли 35 та сайлов округида такрорий овоз бериш ҳамда 5 та сайлов округидан сайловлар жараёнида қонун бузилишларига йўл қўйилганлиги туфайли такрорий сайлов ўтказиш зарурлиги маълум бўлди. \r\nБошқа сайлов округлардан сайланган айрим депутатлар эса ушбу сайлов округларида такрорий овоз бериш ва такрорий сайлов натижалари маълум бўлмасдан туриб ҳам Олий Мажлис Қонунчилик палатасини сайланган ва ўз фаолиятини бошлаши мумкин деб ҳисоблаб, Марказий сайлов комиссияси раисига Қонунчилик палатасининг биринчи мажлисини чақириш, палата раҳбар органлари ва қўмиталари таркибини шакллантириш тўғрисида ариза билан мурожаат қилишди. Марказий сайлов комиссияси раиси мазкур аризага нисбатан рад жавобини берди. \r\n",
                Comment = "Ушбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилиб, вазиятга ҳуқуқий баҳо беринг.\r\n Сайланган депутатларнинг талаблари асослими? Мазкур ҳолат қандай ҳал қилиниши лозим?\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 7,
                Question = "Миробод туманида яшовчи фуқаро А. 2023-йил ноябр ойида туман ҳокимиятига мурожат қилиб фарзанд асраб олмоқчилигини айтади. Туман ҳокимияти унга ўзи ҳақидаги маълумотларни бериши ва иш жойидан маълумотнома олиб келишлигини сўрайди. Фуқаро А. айтилган барча ҳужжатларни олиб келади, лекин ҳужжатлар ичида фуқаро А. қаерда ишлаши ҳақидаги маълумотнома чиқмайди. Шундан сўнг туман ҳокимияти ходими унга ҳужжатларида камчилиги борлигини айтиб, агарда, у тегишли ҳужжатларни икки кун ичида олиб келмаса унга фарзанд асраб олишга рухсат берилмаслигини айтади. Айрим мутахассислар судга бу масалада мурожаат этишни билдирдилар. Фуқаро А ушбу ҳолат юзасидан Ўзбекистон Республикаси Конституциявий судига мурожаат қилади ва ўзининг конституциявий ҳуқуқлари бузилганлигидан эътироз билдиради. Ўзбекистон Республикаси Конституциявий суди ушбу мурожаатда кўтарилган масалалар фуқаролик ишлари бўйича туманлараро суд ваколатига тегишли бўлганлиги сабабли, мазкур шикоят Конституциявий суд ваколат доирасига кирмаслигини билдирди. \r\n",
                Comment = "Ушбу вазиятга ҳуқуқий баҳо беринг. \r\nУшбу вазиятда Конституциявий суднинг Фуқаро А.га йўллаган жавоби қонунийми? Тегишли ҳуқуқий ҳужжатлар асосида муҳокама қилинг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 8,
                Question = "2023 йил 9 июл сайлов ўтказиладиган куни Андижон вилояти телеканали ходимлари келиб сайлов участкасидаги сайловчиларнинг фикр-мулоҳазаларни, биринчи навбатда, сайловчилардан номзодга нима сабаблар туфайли овоз бераётганлигини, сайловда ким ютиб чиқиши ҳақидаги фикрларни сайловчидан келгусида нима натижалар кутаётганлигини ўргана бошланади. Ўз навбатида вилоят телеканали ходимлари сайловнинг натижаси юзасидан прогнозлар чиқара бошлади. Шу пайт сайлов участкаси раиси бу ҳолатдан хабар топиб, телеканали ходимларидан ўз ишини тўхтатишини, интервю ва репортажлар олишини тақиқлади. Вилоят телеканали ходимлари сайлов участкаси раиси ҳаракатларидан норози бўлиб, сайлов тўғрисидаги қонунчилик нормаларига кўра сайловлар очиқ, ошкоралик, эркинлик, адолатлилик, масъуллик принципларига асосан ўтказилиши лозимлигини айтиб эътироз билдирди. Шунингдек, сайлов участкаси раиси устидан Марказий сайлов комиссияга шикоят қилишини билдирди.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг.Ушбу ҳолатда қайси қонун ҳужжатлари бузилганлигини муҳокама қилинг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 9,
                Question = "Газета журналисти Ф.О. озиқ-овқат ярмаркасида ҳолатни видеотасвирга олиш пайтида Чиноз тумани ҳокими ўринбосари унинг қўлидан телефонни олишга ҳаракат қилган.  Кейинроқ уни туман ички ишлар бўлимига олиб келтирган ва ушлаб турган. ИИБ биноси тоифаланган обект ҳисобланиб, у ерда тасвирга олиш тақиқланганлиги боис, журналистнинг телефони олиб қўйилган ва баҳонада ундаги видеоёзувлар ўчириб ташланган. \r\nЖурналист ўзининг ҳуқуқ-эркинликлари қўпол бузилиши борасида ҳуқуқий баҳо беришни сўраб Бош прокуратурага мурожаат қилди. \r\nЖурналист фаолиятига тўсқинлик қилиб, журналистга қўпол муносабатда бўлган ҳокимият вакили эса бу ерда ўзининг айбдор эмаслигини, ўша куни ярмаркада англашилмовчилик рўй берганини айтиб, фуқародан оғзаки узр сўрайди.\r\nИчки ишлар органлари ходимлари эса ушбу взиятда ҳокимият вакилининг буйруғини бажаришганлигини айишган.  \r\n",
                Comment = "Ушбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилиб, вазиятга ҳуқуқий баҳо беринг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 10,
                Question = "Фуқаро Ф. ўз оиласи билан Учтепа туманидаги кўп қаватли уйда яшайди. Унинг кекса онаси давлат муассасаси (Қариялар уйи) қарамоғига олинган. Онаси туман судига мурожат қилиб ўғли ундан хабар олмаётганлигидан шикоят қилади. \r\nУчтепа туман суди Ф.ни чақиртириб унга онасининг ҳолидан хабар олиб туриши кераклигини, агар фуқаро ўз конституциявий мажбуриятини бажармаса ва онасига ғамхўрлик қилмаса алимент тўлаш мажбурияти юклатилишини билдириб, огоҳлантиради. \r\nФуқаро Ф. дам олиш куни оиласи билан онасини кўргани муассасага боради. Онаси фуқаро Ф.га ўзининг эҳтиёжлари учун 1 000 000 (бир миллион) сўм миқдорда пул зарурлигини айтиб, шу пулни беришини сўрайди. Лекин фуқаро Ф. онасига сўраган пулини беришдан бош тортади ва онасини моддий ёрдамга муҳтож эмаслиги чунки у давлат муассасаси қарамоғида эканлигини важ қилиб келтиради.\r\n",
                Comment = "Ушбу вазиятга ҳуқуқий баҳо беринг. \r\nФ.нинг хатти-ҳаракатлари қонунийми? Буни ҳуқуқий асосларини муҳокама қилинг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 11,
                Question = "Фарғона вилояти халқ депутатлари кенгашининг навбатдан ташқари сессиясида Фарғона вилояти Ўзбекистон тумани ҳокимини ўз вазифасидан озод этилди. Ҳамда Фарғона вилояти Ўзбекистон туманига раҳбарлик қилишни Вазирлар Маҳкамасининг қарорига асосан туман ҳокими ўз вазифасидан озод этилганлиги боис, ушбу ҳудудга раҳбарликни Учкўприк тумани ҳокимига топширди. Эндиликда Учкўприк тумани ҳокими ҳам Ўзбекистон туманига ҳам Учкўприк туманига раҳбарликни амалга ошира бошлади. \r\nМазкур масала юзасидан Ўзбекистон Республикаси Олий Мажлис Қонунчилик палатаси Вазирлар Маҳкамасига ўз эътирозини билдирган ҳолда мазкур ҳолат амалдаги қонун меъёрлари талабларига мувофиқ эмаслигини кўрсатган ҳолда ушбу қарорини ноқонуний деб ҳисоблаган ҳолда бу ҳолат икки туманнинг маъмурий ҳудудий бирлигига ҳам маълум бир маънода таъсир кўрсатишини яъни бирлаштириб юборилишини англатишини таъкидлади.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг.\r\nВазирлар Маҳкамаси томонидан мазкур амалга оширилган ҳолат амалдаги қонунчилик талаблари доирасида қабул қилинганми мазкур ҳолатни муҳокама қилинг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 12,
                Question = "Қонун лойиҳаси Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси томонидан учинчи ўқишда қабул қилиниб, Сенат томонидан маъқулланганидан сўнг, Ўзбекистон Республикаси Президентига имзолаш учун юборилди. Бироқ давлат бошлиғи ўз эътирозлари билан Қонуни имзоламасдан қайтарди. Бундай ҳолатда Олий Мажлис палаталари Қонунни аввалги қабул қилинган таҳририда қайта овозга қўйиш ёки давлат бошлиғи эътирозлари инобатга олган ҳолда уни қайта ишлаб, сўнг қабул қилиши лозим эди. Парламент палаталари биринчи йўлни танлади. Қонун дастлаб аввалги таҳрирда Қонунчилик палатаси депутатлари умумий сонининг тўртдан уч қисмидан иборат кўпчилик овози билан маъқулланди, кейин эса Сенат аъзоларининг учдан бир қисми билан маъқулланди ва  Президент ветоси енгиб ўтилди. Бироқ давлат бошлиғи қайта овоз бериш процедураси қўпол равишда бузилганлигини кўрсатиб Қонунни имзоламасдан қолдирди.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг. \r\nУшбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг.\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 13,
                Question = "“Ёшлик” маҳалла фуқаролар йиғини раиси ва унинг маслаҳатчилари сайловини ташкил этиш ҳамда ўтказиш учун тузилган Ишчи гуруҳ фуқаролар йиғини раиси лавозимига номзодларга доир ҳужжатларни тайёрлаб, туман ҳокими билан келишиш учун тегишли туман комиссиясига тақдим этди. Туман хокими тақдим этилган 5та номзоднинг ҳужжатларини ўрганиб чиқди ҳамда тақдим этилган 3та номзодни номуносиб номзод сифатида рўйхатдан чиқариш ҳақида кўрсатма берди.\r\n“Ёшлик” маҳалла фуқаролар йиғини ҳудудида истиқомат қилувчи бир гуруҳ фуқаролар томонидан Ишчи гуруҳга тавсия қилинган номзод Н.Алимовнинг номзоди ҳам туман ҳокими томонидан маъқулланмади. Шу сабабли, унинг номзодини қўллаб-қувватловчи бир гуруҳ фуқаролар Н.Алимовнинг бузилган ҳуқуқларини ҳимоя қилишда ёрдам беришни сўраб туман прокуратурасига  мурожаат қилишди.\r\n",
                Comment = "Вазиятга ҳуқуқий баҳо беринг.\r\nФуқаролар йиғини раиси номзодларини ҳоким билан келишиш\r\n"
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 14,
                Question = "Фуқаро А.Муродов ўз автомашинасини тўхташ тақиқланган белги зонасига тўхтатиб қўйганлиги муносабати билан ЙПХ махсус хизмати томонидан автомобили эвакуация қилинган. А.Муродов махсус йўл ҳаракати хавфсизлиги хизмати ходимларининг хатти-ҳаракатлари Конституцияда кафолатланган мулк ҳуқуқини бузганлиги сабабли уларни қонунга хилоф деб ҳисоблаб, Конституциявий судга унинг масаласини айрим тоифали ишлар бўйича иш юритиш жараёнида кўриб чиқиш талаби билан мурожаат қилган. Конституциявий суд ваколати доирасида фақат муайян ишда қўлланилган ёки қўлланилиши керак бўлган қонунларнинг Конституцияга мувофиқлиги юзасидан ишларни кўриб чиқишини таъкидлаб, масалани ҳал қилишдан бош тортди. Шунингдек, шикоятда ЙПХ ходимларининг хизмати борасида ноаниқликлар мавжудлигини кўрсатиб, ушбу масала бўйича ЙПХ хизматининг Конституцияга зид ҳаракатлари аниқланмаганлигини таъкидлади.\r\nАйрим тоифадаги ишлар бўйича конституциявий иш юритиш тартиби қандай? Айрим тоифадаги ишлар бўйича процессда конституциявий шикоят бериш учун талаблар мавжудми?\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 15,
                Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатасига 2024-йилнинг 25-феврал куни бўлиб ўтган сайловлардан сўнг қонунчиликда белгиланган тартибда Ўзбекистон Республикаси Бош вазири тасдиқланди ва у Ўзбекистон Республикаси Вазирлар Маҳкамаси таркибини шакллантириш бўйича Президентга тақдимнома киритди. Таклиф этилган номзодлар Президент томонидан лавозимига тайинланди. Бироқ, Ўзбекистон Республикаси Бош вазири Ўзбекистон Республикаси Конституциясига мувофиқ, Вазирлар Маҳкамаси фаолиятини ташкил этиши ва унга раҳбарлик қилиши, унинг самарали ишлаши учун жавобгар шахс эканлигини кўрсатди ҳамда ушбу лавозимларга номзодлар ҳам у билан келишилиши лозимлиги ҳақида фикрлар пайдо бўлди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\nУшбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 16,
                Question = "Ўзбекистон Республикаси Олий Мажлиси Қонунчилик палатасига 2024-йилнинг 25-феврал куни бўлиб ўтган сайловлардан сўнг қонунчиликда белгиланган тартибда Ўзбекистон Республикаси Бош вазири тасдиқланди ва у Ўзбекистон Республикаси Вазирлар Маҳкамаси таркибини шакллантириш бўйича Президентга тақдимнома киритди. Таклиф этилган номзодлар Президент томонидан лавозимига тайинланди. Бироқ, Ўзбекистон Республикаси Бош вазири Ўзбекистон Республикаси Конституциясига мувофиқ, Вазирлар Маҳкамаси фаолиятини ташкил этиши ва унга раҳбарлик қилиши, унинг самарали ишлаши учун жавобгар шахс эканлигини кўрсатди ҳамда ушбу лавозимларга номзодлар ҳам у билан келишилиши лозимлиги ҳақида фикрлар пайдо бўлди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\nУшбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 17,
                Question = "Ўзбекистон Республикаси Бош вазири ва Олий Мажлиси Қонунчилик палатаси ўртасида қатъий зиддиятлар пайдо бўлгани туфайли Президентга ишончсизлик вотуми бериш тўғрисида расмий таклиф киритилди. Қонунчилик палатаси депутатлари ва Сенаторлар умумий сонининг камида учдан яримидан кўп миқдори иштирокида давлат раҳбари ушбу таклифни кўриб чиқиб, уни Олий Мажлис палаталарининг қўшма мажлиси муҳокамасига тақдим этди ва парламент палаталари Бош вазирга ишонч билдирмади. Натижада Вазирлар Маҳкамаси истеъфога чиқди. Бироқ, ҳукуматнинг истеъфога чиқарилгани билан Президент фармони билан ўз фаолиятини вақтинча давом эттирди. Бундан ташқари иатеъфога чиқиш ҳақидаги қарор бошқарув функциясига эга бўлган давлат бошқарув органлари, хусусан Вазирлар Маҳкамасига бўйсунадиган қўмиталар, идоралар, комиссиялар ва марказларга таъсир қилмади ва улар ўз жойларида қолди.\r\n Ушбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 18,
                Question = "Ўзбекистон Республикаси Олий Мажлисининг Қонунчилик палатасига келиб тушган қонун лойиҳаси уч ўқишда қабул қилиниб, маъқуллаш учун Ўзбекистон Республикаси Олий Мажлисининг Сенатига юборилди. Бироқ, қонун лойиҳаси Сенат томонидан 60 кун ичида кўриб чиқилди ва рад этилиб, Қонунчилик палатасига қайтарилди.\r\nСенат томонидан рад этилган қонун қайта кўриб чиқилиб, Қонунчилик палатаси депутатлар умумий сонининг учдан икки қисмидан иборат кўпчилик овози билан яна маъқулланди ҳамда 10 кун ичида Сенатга юборилди.\r\nВазиятга ҳуқуқий баҳо беринг. Қонун қабул қилиш тартиби ва жараёнини норматив-ҳуқуқий ҳужжатлар асосида таҳлил қилинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 19,
                Question = "2023 йил 30 май куни Ўзбекистон Республикаси Олий Мажлиси томонидан Ўзбекистон Республикасининг Маъмурий жавобгарлик тўрисидаги кодексига ўзгартиш киритишни назарда тутувчи қонун қабул қилинди. Унга кўра ички ишлар органи ходими асосли тарзда жиноят содир этишга мойил деб ҳисоблаган шахс бошқа шахслар билан бир жамоат жойида тўпланса, ходим уларнинг тарқалишига буйруқ бериши, ушбу буйруққа бўйсунмаган шахсларни жавобгарликка тортиш чорасини кўришга ҳақли экани назарда тутилди. Қонуннинг асосий мақсади шаҳарларда жиноят кўрсаткичини пасайтириш ва хавфсиз ҳудудларни яратиш экани, шунингдек безорилик, одам ўлдириш ва гиёҳванд моддалар билан боғлиқ жиноятларнинг олдини олишга қаратилгани айтилди. \r\n2023 йил 13 июн куни кечки соат 22:30 да оилавий жанжал сабабли уйдан асабий ҳолда чиққан Т. Ваҳобов Амир Темур ҳиёбонида сайр қилиб юрар эди. Унга хотини қўнғироқ қилганда телефонда у билан баланд овозда жанжаллашиб кетди. Сўнг ўртоғига қўнғироқ қилиб Амир Темур ҳиёбонига келишини ва у билан гаплашадиган гапи борлигини айтди. Ўртоғи Р. Мансуров айтган жойга етиб келди. Ушбу ҳолатни бошидан кузатиб турган ички ишлар органи ходими уларни жиноят содир этишга мойил шахслар деб топди ва уларнинг ёнига келиб тарқалишларини буюрди. \r\nТ. Ваҳобов бунга қаршилик кўрсатди. Шунда ички ишлар органи ходими томонидан унга Ўзбекистон Республикасининг Маъмурий жавобгарлик кодексида кўрсатилган ҳуқуқбузарликни содир этгани учун баённома расмийлаштирди. \r\nКейинчалик Т.Ваҳобов Ўзбекистон Республикаси Конституциявий судига мурожаат қилди. Мурожаатда 2023 йил 30 майда қабул қилинган қонун инсоннинг сўз эркинлиги, шунингдек эркинлик ва шахсий дахлсизлик сингари конституциявий ҳуқуқларини поймол этгани сабабли мазкур қонунни Ўзбекистон Республикасининг Конституциясига зид деб топишни сўради.\r\nКазус юзасидан топшириқ:\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 20,
                Question = "Фуқаро У. Давронов Тошкент шаҳар Олмазор туманининг маҳаллаларидан бирида жойлашган жами 4 хонадан иборат уйда ўзи ва оиласидан ташқари ота-онаси ҳамда 2 нафар ака-укалари ва уларнинг оилалари билан бирга яшаб келар эди. Ушбу хонадонда жами 15 кишининг яшаши ҳар томонлама ноқулай эди.\r\nФуқаро У. Давронов 2023 йил 1 август куни Тошкент шаҳар Олмазор тумани ҳокимининг қабулида бўлди. У ҳокимдан истиқомат қилиб келаётган уйнинг қурилганига 50 йилдан ошгани, уйнинг ҳовлиси кичик экани, хоналар сони оила аъзоларига мутаносиб эмаслигини, шу боис мазкур уйда яшаб келаётган ҳар бир оилага давлат ҳисобидан янги қурилаётган кўп қаватли уйлардан алоҳида квартира ажратиб берилишини сўради. \r\nОлмазор туман ҳокими бунинг иложи йўқ экани, уй-жой шароитларини яхшилашга муҳтож бўлган фуқароларнинг кредитга уй-жой олишлари учун тегишли тартиб қоидалар мавжудлиги, фуқаро У. Давронов мазкур қоидаларга амал қилган ҳолда уй олиши мумкинлигини айтди. \r\nФуқаро У. Давронов кредитга уй олиши учун дастлабки бадални тўлашга имконияти йўқ экани, бирон жойда ишламаслигини маълум қилди. Олмазор туман ҳокимига Ўзбекистон Республикасининг Конституцияси муқаддимасида “Республика фуқароларининг муносиб ҳаёт кечиришини таъминлашни мақсад қилган ҳолда”, 1-моддасида эса “Ўзбекистон ижтимоий давлат” деган сўзлар давлат томонидан моддий қийинчиликка дуч келган, уй-жой шароитларини яхшилашга муҳтож бўлган фуқароларга давлат ҳисобидан уй-жой берилишига асос бўла олиши, агар унга ва у билан бирга бир хонадонда яшаб келаётган оилаларга давлат ҳисобидан уй-жой берилмаса, тегишли тартибда юқори органларга мурожаат қилишини айтди.\r\nКазус юзасидан топшириқ:\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 21,
                Question = "Маълум қилинишича, аҳоли 5 та мезон асосида “Темир дафтар”га киритиб борилмоқда. Президентнинг 2020 йил 26 августдаги “Аҳолини ижтимоий қўллаб-қувватлашга қаратилган қўшимча чора-тадбирлар тўғрисида”ги қарори билан Ўзбекистондаги уч тоифа, хусусан “Темир дафтар”даги оилалар фарзандларига 500 минг сўмдан пул тарқатиш белгиланди.\r\nУшбу бир марталик моддий ёрдам кўрсатилишидан хабар топган “Камолон” маҳалласининг ўзига тўқ, моддий шароити яхши аҳволда бўлган 5 нафар фуқаролари ушбу қарордан норози бўлишди. Улар ушбу ёрдам Конституцияда белгиланган қонунийлик, ижтимоий адолат ва бирдамлилик принципларига зид бўлиб, пандемия даврида барчага бирдек моддий ёрдам кўрсатилиши керак деб ҳисоблашди. Шу туфайли улар моддий ёрдам сўраб маҳалла фуқаролар йиғинига мурожаат қилишди. Рад жавоби олгач, прокуратурага МФЙ раисининг қарори устидан шикоят билан мурожаат этишди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 22,
                Question = "2023-йил 30-апрел санасида Ўзбекистон Республикаси Конституциясига ўзгартиришлар киритиш бўйича умумхалқ референдуми ўтказилиши белгиланганди. Тошкент шаҳар Учтепа туманида вақтинчалик рўйхатда турувчи Ўзбекистон Республикаси фуқароси Т.Жўраев референдумда овоз бериш учун борганда овоз берувчилар рўйхатида унинг исми шарифи йўқлиги маълум бўлди. Овоз бериш участкаси котиби Т.Жўраевни у яшаш жойида вақтинчалик рўйхатда турганлиги туфайли сайловчилар рўйхатига киритилмаганини маълум қилди. Комиссия котиби томонидан фуқарога доимий турар жойида ташкил этилган овоз бериш участкасида референдумда қатнашиши мумкинлиги тўғрисида маълумот берилди. Бундан норози бўлган фуқаро Т.Жўраев прокуратура органига шикоят қилди. Прокуратура ходими ушбу масала судга тегишли деб шикоятни рад этди. Бу орада референдум тугаб, натижалар чиқди. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 23,
                Question = "Депутатликка номзодлар Марказий сайлов комиссияси томонидан рўйхатга олинган кундан бошлаб, фуқаро Қ.Азаматов сайловолди ташвиқоти ‒ сайлов компанияси даврида сиёсий партияни ёқлаб овоз беришга ундашга қаратилган фаолият олиб бора бошлади. У ўз тарғиботида А. партияни давлат партияси сифатида эълон қилди. Ўзининг фикрига асос сифатида амалдаги Президент ва ҳукумат мазкур партия вакиллари эканлигини келтирди. Бу борада у номзод М. Азизовнинг сиёсий рақиби бўлган М. Нуриллоевнинг Б. сиёсий партиясини “мухолифатчи партия” деб атади. М. Нуриллоев бундан хабар топгач А. партияни судга берди. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 24,
                Question = "2024 йил 1 феврал куни ҳудудий бошқармалардан бирига А.Қаюмов раҳбар этиб тайинланди. А.Қаюмов ўзидан олдинроқ иш бошлаган бошқа ходимларга нисбатан тегишли соҳада етарлича тажрибага эга эмас эди. \r\nБошқарма ходимларининг аксарияти аёллар эди. Ёш бошлиқ ходимларнинг катта амалий ва ҳаётий тажрибаси, шунингдек, ёшига эътибор қаратмай, бироқ улар аёллар эканлигини эътибор олиб, уларга техник тусдаги ишларни топшира бошлади. Ходималарининг муҳим ҳужжатлар билан ишлай олмайди деб ҳисоблаб, таҳлилий ишларга эркак ходимларини жалб қилишни бошлади. \r\nБундан норози бўлган ходималар юқори ташкилотга шикоят билан мурожаат қилдилар. \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 25,
                Question = "Фуқаро И. Сергеев “Чароғон” хусусий фирмасига менежер лавозимига ишга кириш учун ариза билан мурожаат қилди. “Чароғон” хусусий фирмасининг раҳбари Н. Хаитов И.Сергеевнинг давлат тили – ўзбек тилини билмаслигини асос қилиб, у билан 3 ойлик синов муддати вақтида, фирмада ташкил қилинган тўлов асосида ўзбек тилини ўргатадиган курсда ўқишини ва ўзбек тилини ўрганганидан сўнг ишга қабул қилиши мумкинлигини айтди.\r\nБу вазиятдан норози бўлган И.Сергеев Ўзбекистон Республикаси Конституцияси бўйича унинг меҳнат қилиш ҳуқуқлари поймол бўлганлигини важ қилиб прокуратурага мурожаат қилди.\r\nВазиятга ҳуқуқий баҳо беринг. Ўзбекистон Республикаси Давлат тилининг ҳуқуқий мақомини муҳокама қилинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 26,
                Question = "Бир гуруҳ депутатлар томонидан Олий Мажлис Қонунчилик палатасига янги қонун лойиҳасини тақдим этдилар. Қонун лойиҳасида Қонунчилик палатасининг регламентига ўзгартиришлар киритиш назарда тутилган бўлиб, унга кўра Қонунчилик палатаси Кенгашига янги қўмиталар тузиш, вақтинчалик комиссиялар тузиш ҳуқуқи берилган, Қонунчилик палатасининг қўмиталари эса Қонунчилик палатаси номидан муайян масалалар бўйича қарорлар қабул қилиш ҳуқуқига эга эди. Қонун лойиҳаси ташаббускорларининг фикрича, ушбу амалиёт хорижий мамлакатлар парламентларида кенг тарқалган бўлиб, қуйи палата фаолиятини оптималлаштириш ва самарадорлигини оширишга хизмат қилади.\r\nВазиятга ҳуқуқий баҳо беринг. Олий Мажлиси Қонунчилик палатасининг таркибий бўлинмаларини шакллантириш тартибини ёритинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 27,
                Question = "Ўзбекистон Республикаси Президенти ваколати муддати тугаши муносабати билан истеъфога чиқди ҳамда Ўзбекистон Республикаси Конституциясининг 113-моддасига биноан Ўзбекистон Республикаси Олий Мажлиси Сенатининг умрбод аъзоси лавозимини эгаллади. Мазкур вазиятда Сенат Кенгашининг навбатдаги мажлисида парламент юқори палатаси Раиси Сенат таркиби Конституцияга мувофиқ 65 нафар сенатордан иборат бўлиши кераклигини кўрсатган ҳолда давлат бошлиғи томонидан Ўзбекистон Республикаси Конституциясининг 92-моддаси асосида тайинланган 9 нафар сенатордан бирини Сенат аъзолиги лавозимидан озод этиш таклифи билан Президентга мурожаат қилиш тўғрисидаги масалани кун тартибига киритди. Бироқ Олий Мажлиси Сенати Кенгашининг бошқа аъзолари Кенгаш раисининг таклифига эътироз билдириб, парламентнинг юқори палатаси 65 нафар аъзодан ортиқ таркибда ҳам фаолият юритиши қонунчиликка зид эмаслигини таъкидлаб ўтдилар.\r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 28,
                Question = "2023 йил 12 ноябр куни О.Соддаев Тошкент шаҳрига вақтинчалик хизмат вазифасини бажариш учун оиласи билан кўчиб келди. Участка нозири 5 кун ичида турган жойи бўйича ҳисобга туриши лозимлигини расман маълум қилди. О.Соддаев доимий рўйхатдан ўтмоқчи бўлиб ҳудуддаги милиция таянч пунктига мурожаат этганида участка инспектори О.СоддаевниТошкент шаҳрида доимий рўйхатдан ўтишга ҳуқуқи йўқлигини айтиб, турган жойи бўйича рўйхатдан ўтиши мумкинлигини таъкидлаб ўтди. \r\nО.Соддаев турган жойи бўича рўйхатдан ўтмоқчи бўлганда эса ҳужжатлардаги айрим камчиликларни важ қилиб фуқаронинг мурожаатини рад этди. \r\nБундан норози бўлган О.Соддаев прокуратура органларига мурожаат қилди. У ўз мурожаатида Ўзбекистон Республикаси Конституциясида фуқаро республика ҳудудида бир жойдан иккинчи жойга кўчиш ҳуқуқи мавжуд эканлигини қайд этди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 29,
                Question = "“Tu-on” МЧЖ тижорат сири билан ҳамда бевосита мижозлар билан алоқа қиладиган лавозимда ишлайдиган собиқ ходими З. Хайруллоевга мурожаат этиб, жамиятда меҳнат фаолиятини олиб борган пайтда у билан тузилган меҳнат шартномаси ва қўшимча моддий жавобгарлик тўғрисидаги келишувда меҳнат шартномаси бекор қилинганидан сўнг рақобатчи бўлган бошқа корхонада 3 йил давомида ишга жойлашиши ёки иш берувчи бўлган тадбиркорлик субъектининг бизнес йўналиши билан бир хил бўлган меҳнат фаолияти билан шуғллланиш мумкин эмаслигини назарда тутилганлигини маълум қилади.\r\nЗ.Хайруллоев2021-йил 2-август кунидан “Tu-on” МЧЖда маҳсулотларни реализация қилиш ва мижозлар маълумот базасини шакллантириш бўйича мутахассис лавозимида меҳнат фаолиятини юритиб келди.\r\nЗ.Хайруллоев 2022-йил ноябр ойида “Tu-on” МЧЖ билан меҳнат шартномасини бекор қилди.\r\nШундан сўнг З. Хайруллоев2023-йил март ойида “Ту-он” МЧЖнинг рақобатчиси ҳисобланган “Порлоқ юлдуз” МЧЖга маҳсулотларни реализация қилиш ва мижозлар маълумот базасини шакллантириш бўйича мутахассис лавозимида иш бошлади.\r\n“Tu-on” МЧЖ масъул ходими З.Хайруллоевнинг “Порлоқ юлдуз” МЧЖга ишга кирганлигини эшитгач унга қўнг ироқ қилиб, меҳнат шартномаси бекор қилинаётганда унга бошқа ушбу лавозимда меҳнат фаолиятини олиб бормаслик шартини қўйганлигини эслатади. \r\nЗ.Хайруллоев “Tu-on” МЧЖнинг мурожаатига жавобан Ўзбекистон Республикасининг Конституциясига кўра эркин касб танлаш, тадбиркорлик эркинлиги, меҳнат қилиш ҳуқуқига эга эканини айтиб, мазкур конституциявий ҳуқуқини ҳеч ким чеклаши мумкин эмаслигини маълум қилди. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 30,
                Question = "Тошкент шаҳар Адлия бошқармасида давлат рўйхатидан ўтган “Ватанпарвар” нодавлат нотижорат ташкилоти аҳолини тоза ичимлик суви билан таъминлаш соҳасидаги қонуний ҳуқуқ ва манфаатларини ҳимоя қилиш мақсадида 2023-йилда тузилган. Мазкур нодавлат нотижорат ташкилот бир неча бор давлат томонидан қўллаб-қувватланишга эришиш мақсадида нодавлат нотижорат ташкилотлар ва фуқаролик жамиятининг бошқа институтларини қўллаб-қувватлаш жамоат фонди маблағларини бошқариш бўйича Парламент комиссиясига ҳужжатлар топширди. \r\nБироқ, ҳар доимгидек Парламент комиссияси мазкур ташкилотга маблағ ажратиш масаласида рад жавоби бериб келар эди. Давлат гранти олиш бўйича берилган охирги мурожаат ҳам ижобий ҳал бўлмагандан кейин “Ватанпарвар”  нодавлат нотижорат ташкилоти аъзолари умумий йиғилиш чақириш ҳамда йиғилиш кун тартибига ташкилотни ихтиёрий тугатиш ҳақида масаласини киритиш таклифини илгари суришди.\r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 31,
                Question = "2024 йил 10 феврал куни “Авлод” МФЙ фаоллари қишлоқ ҳудудида жойлашган масжиддан фойдаланишга рухсат беришини сўраб туман ҳокимлигига мурожаат қилди. Туман ҳокимияти қишлоқ аҳолисининг эҳтиёжини инобатга олиб, фақат мазкур ҳудудни ободонлаштириш, кўкаламзорлаштириш ҳамда доимий равишда тоза ва озода бўлиш шарти билан диний ибодат учун фойдаланишга рухсат берди. \r\nМасжид ва унинг атрофидаги ҳудудларга керакли дарахт кўчатлари, гул экиш мажбурият сифатида қишлоқ аҳолиси зиммасига юкланди. Бироқ, орадан кўп ўтмасдан вилоят адлия бошқармаси туман ҳокимининг қарорини бекор қилган ҳолда ушбу масжиддан фойдаланишни тақиқлади. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 32,
                Question = "“Б” Сиёсий партия парламентга бўлиб ўтадиган сайловларда муваффақиятли қатнашиш мақсадида халқаро ташкилотдан ҳамда сиёсий платформасида акс эттирилган ғоя ва мақсадларига хайрихоҳ бўлган чет эл фуқаросидан кўп миқдорда чет эл валютасидаги хайрия ёрдамини олди. Олинган маблағлар ҳисобидан сиёсий партия номзодлар билан учрашувларни ташкил этди, учрашувларга келган фуқароларга ўз ҳисобидан дастурхон ташкил этди, эсдалик совғаларини ҳадя қилди. Маҳаллий давлат ҳокимияти органлари ва банк-молия идоралари томонидан тақдим этилган маълумотлар асосида Марказий сайлов комиссияси партияни сайлов жараёнида иштирок этишдан четлатди. Сиёсий партиянинг фаолларидан бири мазкур қарордан норози бўлиб Конституциявий судга шикоят аризаси билан мурожаат этди.  \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 33,
                Question = "2023 йил 9 июлда бўлиб ўтадиган Ўзбекистон Республикаси президенти сайловида қатнашиш учун фуқаро Д.Собиров сайлов участкасига мурожаат қилиб ўзини сайловчилар рўйхатига киритиб қўйишини сўрайди. Участка раиси унга аниқ сайловчилар миқдори бор эканлигини, сайловчилар рўйхатга олинган вақтда у яшаш жойида бўлмаганлиги туфайли киритилмаганлигини таъкидлайди. Ўз навбатида, Д. Собиров бир кун аввал Ўзбекистон Республикаси фуқаролигига эга бўлганлигини ва барча фуқаролар каби сайловда иштирок этиш ҳуқуқига эгалигини айтиб ўтди. Сайлов участкаси раиси Д.Собиров билдирган важларга эътибор қаратмасдан, рўйхатга олиш жараёни якунланганлигини ва рўйхат юқори турувчи комиссияга тақдим этилганлигини маълум қилди. Д. Собиров юзага келган ҳолат бўйича жиноят ишлари бўйича туман судига шикоят аризаси билан мурожаат қилди.\r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 34,
                Question = "А.Аллаёров 2023 йил 19 сентябр куни тана ҳарорати 39 даражани кўрсатиб, танасида оғриқ сезганлиги сабабли шифохонага мурожаат қилди. Шифохонада навбатчи шифокор А.Аллаёровнинг доимий яшаш манзили бўйича шифохонага мурожаат этиши лозимлигини маълум қилиб, унинг ҳолати қониқарли эканлиги сабабли уни стационар шароитда даволаш учун қабул қила олмаслигини айтди.\r\nБунга жавобан, А.Аллаёров шифокорга мурожаат этиб, ҳеч бўлмаса уни тиббий кўрикдан ўтказишни ва дастлабки ташхис қўйишни сўради. Навбатчи шифокор дастлабки ташхис қўймаслигини, бундай ҳаракат қилиш бўйича раҳбарият томонидан унга мажбурият юкланмаганлигини маълум қилди.\r\nБундан дарғазаб бўлган А.Аллаёров конституциявий ҳуқуқини тиклаб берилишини сўраб судга шикоят қилди.\r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 35,
                Question = "С.Сайдуллаев ўзининг “Ҳуқуқингизни биласизми?” номли кўрсатувида фуқаролик ишлари бўйича туманлараро судига ўз кўрсатуви учун фуқаролар иштирок этган фуқаролик иши материаллари билан танишиш ва улардан нусха олишни сўраб мурожаат қилганлигини, суд унга иш материалларидан кўчирма ва нусха олиши мумкинлиги, лекин суд мажлиси баённомасидан нусха олиш қонун нормаларида белгиланмаганлиги сабабли ундан нусха олиш мумкин эмаслигини билдирганлигини, Фуқаролик процессуал кодекси (ФПК)га мувофиқ ишда иштирок этувчи шахслар иш материаллари билан танишиш, улардан кўчирмалар олиш, нусхалар кўчириш ҳуқуқларига эгалигини маълум қилиб, Конституциявий судда ФПК даги “иш материаллари” сўзлари суд мажлиси баённомасини ҳам назарда тутиши ёки тутмаслиги юзасидан шарҳ беришни сўраган. Ўзбекистон Республикаси Конституциявий суди ушбу нормага шарҳ беришни рад этган.\r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 36,
                Question = "Самарқанд вилояти марказида фаолият юритаётган сут ва сут маҳсулотлари ишлаб чиқаришга ихтисослашган “So-milk” хусусий корхонасида инсон ҳуқуқ ва эркинликлари таъминланмаётганлиги масаласи юзасидан бир гуруҳ ишчилар мулкдорга мурожаат қилишди. Ўз мурожаатларида меҳнат шароити, ижтимоий тенглик ҳамда меҳнатга яраша ҳақ тўланмаса мазкур ҳолат юзасидан прокуратурага мурожаат қилишлари, шунингдек корхона фойда кўрмасдан ишлаш билан бирга сут маҳсулотларини етарли даражада қайта ишламасдан исроф қилинаётганлиги фактини керакли органларга маълум қилган ҳолда ушбу корхонанинг кичик бизнес субъекти сифатида барча имтиёзлардан маҳрум қилинишига эришишларини маълум қилишди.\r\nБунга жавобан эса корхона раҳбари у мулкдор эканлиги ҳамда хоҳлаган ишини қилиши мумкинлигини маълум қилган ҳолда мурожаат қилган барча ишчилар билан меҳнат шартномасини бекор қилди.\r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 37,
                Question = "Термиз шаҳрида жойлашган ва кичик бизнес субъекти бўлган “Қурувчи” МЧЖ турли брусчатка ва бетон қоришмасидан тайёрланадиган қурилиш материалларини ишлаб чиқаради. Мазкур корхонада ишлайдиган фуқаро З. Ҳасанов ўзиниг корхонадаги ижтимоий ҳолатидан, унинг фикрича иш берувчининг ёмон муносабатидан норози бўлиб ҳокимият органларига мурожаат қилди. \r\nУ ўз мурожаатида корхонада фаолият олиб бораётган 120 нафар ишчи бир хил меҳнат шароитларида ишламаётганлиги ва бир хил иш ҳақи олмаётганликлари ҳамда айни вақтда 30 нафар ишчи 120 нафар ишчи учун ишлаётгани, қолган 90 нафар ишчи иш берувчи мулкдорнинг қариндошлари эканлиги сабабли улар умуман ишга келмаслиги, шунга қарамасдан иш ҳақи олишлари, шунингдек, белгиланган режа бажарилмасдан қолган тақдирда айнан 30 нафар ишчилар билан меҳнат шартномасини бекор қилиши мумкин эканлигини кўрсатиб ўтди.\r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 38,
                Question = "Фуқаро Ш. Тошкент шаҳридаги намунали уйлардан бирида яшар эди. 2024 йил 15 феврал куни кечаси соат 00:10 да қўшни уйда туғилган кун уюштирилганлиги сабабли баланд мусиқа ва турли шовқинлар эшитила бошланди. Бундан норози бўлган фуқаро Ш. қўшни уй эшигини тақиллатиб, уйида бетоб ойиси борлиги ва бу шовқин уни безовта қилаётганлигини таъкидлади. Бунга жавобан қўшни уй унинг хусусий мулки эканлиги ва ундан хоҳлаганича фойдаланиши мумкинлигин айтиб ўтди. Қўшнилар орасида тортишув келиб чиқди.\r\nҲолатни бартараф қилиш учун уларнинг бошқа бир қўшниси фуқаро М. ҳудуднинг профилактика инспекторига мурожаат қилди, етиб келган профилактика инспектори ҳам уй унинг хусусий мулки эканлигини, бу ҳолатга аралаша олмаслигини айтиб, аксинча фуқаро Ш. қўшнисининг тинчини бузган ҳолда уни чақириб жалжал кўтаргани учун фуқаро Ш.ни ҳудудий ички ишлар органига олиб кетти.\r\nУшбу ҳолатни Ўзбекистон Республикаси қонунчилиги доирасида муҳокама қилинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 39,
                Question = "Ўзбекистон Республикаси фуқароси Солиев Ўзбекистон Республикаси Бош прокурори ўринбосари лавозимида ишларди. У ўз билимларига таянган ҳолда қонун лойиҳасини тайёрлаб, уни Олий Мажлис Қонунчилик палатасига тақдим этди. У “Ўзбекистонда сунъий интеллектдан фойдаланишни тартибга солиш тўғрисида”ги қонун лойиҳасига қуйидагиларни илова қилди.\r\n1)\r\n2)\r\nБироқ, Қонунчилик палатаси Спикери қонун лойиҳасини кўриб чиқишдан бош тортиб, фуқаро Солиев қонунчилик ташаббуси субъекти эмаслиги важи билан таклифни қайтариб юборди.\r\nҲуқуқ ижодкорлигида фуқароларнинг иштирокини муҳокама этинг ва вазиятга ҳуқуқий ечим беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 40,
                Question = "Яккасарой тумани “Ракат” маҳалласи ҳудудида истиқомат қилувчи фуқаро Б.Қодиров вафот этди. Ворислари бўлмаганлиги сабабли унинг кўчмас мулки эгасиз қолди. Маҳалла фуқаролар йиғини томонидан ушбу участка кам таъминланган, боқувчисини йўқотган фуқаро Э.Воҳидов ва унинг оиласига бериладиган бўлди. Аммо, уй маҳалла раиси номига расмийлаштирилди. Маълум вақт ўтганидан сўнг, маҳалла ҳисобидаги маблағларнинг ноқонуний тасарруф этилиши юзасидан прокуратура идоралари томонидан тафтиш ўтказила бошланди. Ўрганиш жараёнида эгасиз уйнинг М.Ф.Й. қарори асосида фуқаро Э.Воҳидовга берилгани ҳам аниқланди ва прокуратура томонидан мазкур қарор ҳақиқий эмас деб топилиб, уй давлат фойдасига ўтказилди. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 41,
                Question = "2023 йил 2 май куни Туркманистон Республикаси фуқароси К.Яхшимурадов Бухоро вилояти ИИБ бошлиғи С.Юлдошевга Ўзбекистон Республикаси фуқаролигига қабул қилинишни сўраб мурожаат қилди. Мурожаатда Ўзбекистон Республикасида туғилгани, қизи ҳам Ўзбекистон Республикасига турмушга чиқиб, ҳозирги пайтда Ўзбекистон Республикаси фуқароси эканлигини келтириб ўтди. Шунга асосан, унга тўғридан-тўғри Ўзбекистон Республикасининг фуқаролигини берилишини талаб этди. Бироқ, унинг талаби қондирилмади. \r\nБундан норози бўлган К.Яхшимурадов шикоят билан судга мурожаат қилди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 42,
                Question = "2023 йил 20 ноябрда куни бўлиб ўтган Олий Мажлис Қонунчилик палатасининг сессиясида Бухоро вилоятидаги Жондор туманини Бухоро шаҳрига бирлаштириш ҳақида қарор қабул қилинди.\r\nМазкур қабул қилинган қарор билан Бухоро вилоятидаги Жондор туманини Бухоро шаҳрига бирлаштирилиши кейинчалик мазкур ҳудудни маъмурий жиҳатдан бошқаришда муайян қийинчиликларни келтириб чиқарди. \r\nТуман ҳокими шаҳарнинг инфратузилмаси, аҳоли сони ва ер майдони шаҳар ташкил этишга етарли эканини асос қилиб, шаҳарни қайтадан ташкил этишни сўраб, Вазирлар Маҳкамасига илтимоснома билан мурожаат қилиш лозим эканлигини айтиб туман маҳаллий кенгаши қарорини чиқарган ҳолда, Ўзбекистон Республикаси Вазирлар Маҳкамасига мурожаат қилди.\r\nБироқ, хоким томонидан қилинган мурожаат Вазирлар Маҳкамаси томонидан рад этилди.\r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 43,
                Question = "Д.Сатторов 2024 йил 7 январ куни яқин дўстлари билан ўтказилган зиёфатда иштирок этди. Д.Сатторов зиёфатда мобил телефонини стол устида қолдириб ташқарига чиқиб кетди. Бу орада зиёфатда иштирок этаётган М.Эшонов унинг телефонидан Телеграм дастури орқали бошқа шахс билан сўзлашувларини ўқиб чиқди. \r\nЭртаси куни номаълум шахс Д.Сатторовга телефон қилиб унда Д.Сатторовга тегишли унинг обрўсини қадрсизлантирадиган расм ва видеолар борлигини айтди. Бундан хавотирга тушган Д.Сатторов ички ишлар органига мурожаат қилди. Д.Сатторов унинг сиридан воқиф бўлиш ниятида қасддан Телеграм дастури орқали бошқа шахс билан сўзлашувларини ўқиб чиққанлик ва бу орқали ўзганинг сиридан воқиф бўлганлик учун тегишли шахсларни топиб жавобгарликка тортишни сўради.\r\nБироқ, Д.Сатторовга ҳуқуқни муҳофаза қилувчи орган томонидан бошқа шахс билан сўзлашувларини қасддан ўқиб чиққанлик ва бу орқали ўзганинг сиридан воқиф бўлганлик учун ҳеч қандай жавобгарлик ўрнатилмагани айтилди. Бундан норози бўлган Д.Сатторов судга мурожаат қилди. Суд Ўзбекистон Республикасининг Конституциясида бировнинг ёзишмалар ва телефонда сўзлашувлар сирини ошкор этиш тақиқланганини келтириб Д.Сатторовнинг талабини қаноатлантиришни рад этди. Бундан норози бўлган Д.Сатторов юқори турувчи судга апелляция тартибида шикоят қилди.\r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 44,
                Question = "Д.Раззоқова Туркия ҳукумати томонидан эълон қилинган Туркия техник ҳамкорлик дастури грантида иштирок этиш учун ҳужжатлар тайёрлади. Д.Раззоқова фаолият олиб борадиган адвокатлик ҳайъати раҳбари номидан йўлланма хат олди. Йўлланма хат ўзбек тилида ёзилган эди.\r\nТуркия техник ҳамкорлик дастури гранти учун ҳужжатлар Туркиянинг Ўзбекистондаги элчихонасига Ўзбекистон Республикаси Ташқи ишлар вазирлиги орқали топширилиши керак эди. Д.Раззоқова 2023 йил 25 май куни ҳужжатларни Ташқи ишлар вазирлигига олиб борди. Аммо, Ташқи ишлар вазирлигининг чет эл грантлари учун масъул бўлган бошқармасида фаолият олиб борувчи ходими Д.Раззоқовага ўзбек тилида ёзилган йўлланма хатни қабул қила олмаслигини, уни рус тилида тайёрлаб келишни сўради.\r\nД.Раззоқова бунинг сабаби нимада эканини сўраганда Ташқи ишлар вазирлигининг грантлар билан ишлайдиган бошқармаси халқаро грантлар номзодлари учун бериладиган йўлланма хатлар рус тилида қабул қилиниши тартиб-қоидага айлангани, бунга барча номзодлар риоя қилиб келаётганини таъкидлади. \r\nД.Раззоқова бундан норози бўлиб 2023 йил 9 июн куни Ўзбекистон Республикаси Вазирлар Маҳкамасининг Давлат тилини ривожлантириш департаментига шикоят билан мурожаат этди. Департамент ваколатлари доирасида Д.Раззоқованинг мурожаатини ўрганиб чиқишга киришди.  \r\nЎрганиш натижаларига кўра, Ташқи ишлар вазирлиги томонидан фуқаро Д.Раззоқовадан халқаро грантда иштирок этиш учун у фаолият олиб бораётган муассасанинг раҳбари томонидан ўзбек тилида тақдим этилган йўлланма хатни қабул қилиш рад этилгани асосли деб кўрсатилган. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 45,
                Question = "Ўзбекистон Републикаси Президенти кураш спорт турини ривожлантириш мақсадида асли Куба фуқароси бўлган, юнон-рум курашида катта тажрибага эга М.Лопезни Ўзбекистон терма жамоаси бош мураббийи сифатида таклиф қилиб, унга Ўзбекистон Республикаси фуқаролигини бериш юзасидан Президент Администрациясига топшириқ берди. \r\nБу ҳолдан норози бўлган терма жамоанинг аввалги мураббийи Куба фуқаросига Ўзбекистон фуқаролигини бу вазиятда бериш мумкин эмаслигини таъкидлади ва Конституциявий судга мурожаат қилди. \r\nУшбу ҳолатни Ўзбекистон Республикасининг амалдаги қонунчилиги доирасида муҳокама қилинг.\r\n\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 46,
                Question = "2023 йил 12 декабр санасида ЎзМТРК каналларининг бирида ёшлар ҳаётидаги муаммолар ҳақида танқидий руҳдаги кўрсатув эфирга узатилди. Унда ёш йигит қизларнинг марказий хиёбонларда учрашувлари акс этган лавҳалар марказий ўрин эгаллади. Кўрсатув эфир юзини кўргач, телевидения орқали юзи яширилмаган ҳолда намойиш этилган ва кенг жамоатчилик томонидан танқид қилинган ёшлар руҳиятида ўзгаришлар кузатилди. Ҳаттоки, ижтимоий тармоқларда айрим ёшлар ўз жонига қасд қилишга уринишлар ҳақида хабарлар тарқалди. Юзи яширилмаган айрим ёшлар эса юқоридаги ҳолатни ўзларининг шахсий дахлсизлигига таҳдид деб баҳолашди ва судга мурожаат қилишди. \r\nМазкур ҳолатда телевидения ходимлари ҳатти-ҳаракатларини инсон ва фуқароларнинг шахсий ҳаётига аралашиш деб баҳолаш мумкинми? \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 47,
                Question = "Фуқаро А.Анваров ўзига тегишли бўлган ер участкасини фуқаро В.Саидовага 75 минг АҚШ долларига сотиб юборди. Ушбу ер участкасининг ҳужжатларини расмийлаштириш жараёнида давлат ҳокимияти идоралари ушбу олди-сотди шартномасини амалга оширишга тўсқинлик қилди. Ер умуммиллий бойлик сифатида унинг эркин олди-сотди қилиниши тақиқланди. А.Анваров эса ушбу ер участкаси мулк қилиб берилганлигини, унга нисбатан мулк ҳуқуқи мавжуд бўлиб, уни тасарруф этиш ҳуқуқи ҳам мулк ҳуқуқининг элементи сифатида унга тегишли эканлигини келтириб судга мурожаат қилди.\r\nВазиятга амалдаги қонунчиликка асосланган ҳолда ҳуқуқий баҳо беринг. Ер участкасини хусусийлаштириш юзасидан фикр мулоҳазаларингизни билдиринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 48,
                Question = "Тошкент вилоятида яшовчи фуқаро Д. Олий Мажлис Қонунчилик палатаси депутатлигига сайлов ўтказувчи 55-Паркент сайлов округи раисига Жамоатчилик назоратини амалга ошириш мақсадида мурожаат қилди. У ўз мурожаатида округ сайлов комиссияси фаолиятини жамоатчилик назоратига оид қонунчилик нормалари асосида видеокамера орқали суратга олишини ҳамда ўз фуқаролик позициясидан келиб чиққан ҳолда амалга оширмоқчи эканлигини таъкидлади. Округ сайлов комиссияси раиси фуқаро Б. ни бундай ҳуқуқи йўқлигини билдириб, уни Марказий сайлов комиссиясига мурожаат қилиши лозимлигини билдирди. Фуқаро Б. мазкур ҳолатдан норози бўлиб, Ўзбекистон Республикаси Фуқаролик ишлари бўйича Тошкент шаҳар судига мурожаат қилди. \r\nВазиятга ҳуқуқий баҳо беринг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 49,
                Question = "2023 йил 8 июн куни Қозоғистон Республикаси фуқароси 17 ёшли Қ. Ўзбекистон Республикаси фуқароси бўлган холаси Ж. томонидан фарзандликка олинди. Бир ой ичида Қ. Қозоғистон фуқаролигидан чиқди. Ж. фарзанди Қ.ни Ўзбекистон Республикаси фуқаролигига қабул қилинишини сўраб ФҲДЁга мурожаат қилди. Бироқ, мазкур орган томонидан Ўзбекистон Республикаси фуқаролигига қабул қилиш учун чет эл фуқароси Ўзбекистон ҳудудида беш йил давомида муқим яшаши кераклиги ва ота-онаси ҳам Ўзбекистон Республикасида туғилган ёки Ўзбекистон Республикаси фуқароси бўлиши лозимиги айтилди. \r\nШу боис, бу талаб бажарилмагани сабабли Ж. томонидан тақдим этилган ҳужжатлар қайтарилди. Бундан норози бўлган Қ. судга мурожаат қилди. \r\nВазиятга ҳуқуқий баҳо беринг. \r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 50,
                Question = "2023 йил 5 октябр куни Халқ депутатлари Бухоро вилояти Кенгаши Бухоро вилоятининг маъмурий ҳудудий бирлигини кенгайтириш мақсадида қарор қабул қилди. Ўзбекистон Республикаси Олий Мажлиси Сенатидан мазкур қарорни тасдиқлаб берилиши сўралди. \r\nЎзбекистон Республикаси Олий Мажлиси Сенатининг навбатдаги сессиясида Бухоро вилояти халқ депутатларининг маъмурий ҳудудий бирлигини ўзгартириш юзасидан Сенатга юборилган қарор кўриб чиқилди. Кўриб чиқиш натижалари юзасидан Сенат қарори қабул қилинди. \r\nЎзбекистон Республикаси Олий Мажлиси Қонунчилик палатаси Спикери бундай масала Вазирлар Маҳкамаси мажлисида муҳокама этилиб, сўнг тегишли қарор қабул қилиниши кераклигини айтиб эътироз билдирди.\r\nВазиятга ҳуқуқий баҳо беринг\r\n",
                Comment = ""
            });
        }
        private void Generator_MockData_Ru_K()
        {
            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Объясните роль конституционного права как ведущей отрасли права. Дайте юридическую характеристику значимости конституционного права в сфере общественного и государственного строительства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Объясните связь конституционного права с другими отраслями права. Как эта взаимосвязь находит свое выражение на практике? " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Проанализируйте отражение идей преамбулы Конституции в нормах Конституции. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Какая форма государственного правления действует в  Республике Узбекистан? Чем отличается форма государственного правления Узбекистана от формы правления зарубежных стран?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "В чем проявляется ответственность государственных органов и должностных лиц перед обществом и гражданами? Дайте правовую характеристику вопросу ответсвенности государственных органов и должностных лиц." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Объясните причины повышения узбекского языка до статуса государственного языка. Проанализируйте значимость государственного языка в отношениях общества и государства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Объясните конституционные основы выступления от имени народа Узбекистана." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Что для вас означает демократия, основанная на общечеловеческих принципах? Как этот принцип находит свое отражение в правовых источниках?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Какими принципами руководствуется государство в своей деятельности? Дайте правовую характеристику этим принципам." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Укажите основания приобретения и утраты гражданства. Как эти основания нашли свое выражение на практике?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Каков порядок правовой защиты граждан Узбекистана зарубежом? Какие основания существуют по защите прав граждан Узбекистана?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Что понимается под неприкосновенностью и защитой частной собственности со стороны государства?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Что понимается под владением, пользованием, распоряжением, отчуждением имущества? Дайте правовую характеристику этим понятиям." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Дайте характеристику конституционно-правовой основе избирательной системы." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Раскройте конституционные гарантии прав и свобод граждан? Охарактеризуйте  роль государства как защитника прав и свобод граждан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Что понимается под защитой прав и свобод человека и граждан через суд? Какими еще способами можно защитить права и свободы граждан?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Объясните правовой статус и направления деятельности уполномоченного по правам человека (омбудсмана)в Республике Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Объясните правовые основы гражданства Республики Узбекистан. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Что понимается под конституционными обязанностями. Перечислите конституционные обязанности. Разъясните их." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Дайте определение понятию личных прав и свобод. Расскажите о видах личных прав и свобод?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Выразите свое отношение к рассуждениям о том, что право на жизнь является естественным правом человека." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Что вы понимаете под неприкосновенностью частной жизни? Каким образом гарантирована неприкосновенность частной жизни в Конституции и законодательстве Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Как вы понимается   слова честь и достоинство человека? Выскажите свое мнение о правовой защите чести и достоинства человека." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "Что вы подразумеваете под свободой совести и убеждений? Проанализируйте конституционные гарантии свободы совести и убеждений в Узбекистане." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Что вы подразумеваете под свободой слова и мысли? Расскажите свое мнение по поводу гарантий свобод слова и мысли." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Расскажите о содержании и характере проводимых в нашей стране правовых реформ по обеспечению и гарантированию прав и свобод личности." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Расскройте суть политических прав и свобод граждан. Какие проявления политических прав и свобод вы знаете ?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Что понимается под правом граждан на участие в управлении делами государства и общества?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "В каких формах граждане вправе осуществлять свою социальную активность? Дайте правовую характеристику соответствующим формам." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Изложите суть и содержание и сущность прав граждан на общественные объединения для объединения и участия в массовых движениях." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Что понимается под обращениями физических и юридических лиц? Раскройте содержание и сущность права на обращение к государственным органам, учреждениям и представителям народа." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Расскажите об экономических и социальных правах. Каким образом реализуются экономические и социальные права?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Объясните суть принципа разделения властей, опираясь на нормы Конституции Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Объясните сущность и значение принципа сдержек и противовесов между ветвями власти, опираясь на нормы Конституции Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Объясните конституционные основы экономической системы общества в Узбекистане." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Что подразумевается под политическими институтами? Какие формы политических институтов существуют?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Каковы специфические особенности политических партий в системе политических институтов?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Объясните роль и значение средств массовой информации в системе демократических институтов в Республике Узбекистан? Дайте характеристику правовым основам, регулирующим средства массовой информации." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Что вы подразумеваете под избирательным правом?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Объясните порядок формирования Сената Олий Мажлиса Республики Узбекистан на основе Конституции и законодательства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Охарактеризуйте специфику субъектов права законодательной инициативы в Республике Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Проанализируйте взаимодействие палат Олий Мажлиса Республики Узбекистан на основе Конституции и законодательства. Объясните эти отношения с практической точки зрения." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Объясните конституционно-правовой статус Законодательной палаты Олий Мажлиса Республики Узбекистан на основе Конституции и законодательства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Объясните конституционно-правовой статус Сената Олий Мажлиса Республики Узбекистан на основе Конституции и законодательства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Объясните роль Сената Олий Мажлиса Республики Узбекистан в качестве палаты территориального представительства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Охарактеризуйте полномочия Сената Олий Мажлиса Республики Узбекистан, разделив их на группы." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Объясните взаимодействие Сената Олий Мажлиса Республики Узбекистан с органами государственной власти. Опишите эти отношения с практической точки зрения." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Дайте теоретико-правовую характеристику принципу профессионализма в деятельности Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Объясните суть и содержание полномочий Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Разъясните порядок формирования Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Объясните порядок организации деятельности Законодательной палаты Олий Мажлиса Республики Узбекистан и ее структурных подразделений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Объясните правовой статус депутата Законодательной палаты и члена Сената Олий Мажлиса Республики Узбекистан. Укажите направления их деятельности." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Расскажите основания досрочного прекращения полномочий депутата Законодательной палаты и члена Сената Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Объясните порядок отзыва депутата и члена Сената, и основания отзыва." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Опишите законодательный процесс и его этапы в рамках законодательства РУз. Перечислите субъектов права законодательной инициативы." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Объясните цель создания согласительной комиссии в деятельности парламента и порядок формирования согласительной комиссии." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Опишите законодательные основы порядка подписания закона и вступления его в силу. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Объясните конституционно-правовой статус Президента Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Опишите порядок организации и проведения выборов Президента Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Охарактеризуйте суть и содержание полномочий Президента Республики Узбекистан с их классификацией." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Проанализируйте нормативно-правовые акты, принимаемые Президентом Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Какое выражение на практике имеет функция Президента Республики Узбекистан по обеспечению согласованного функционирования и сотрудничества органов государственной власти?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Опишите конституционно-правовой статус Кабинета Министров Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Охарактеризуйте порядок формирования Кабинета Министров Республики Узбекистан на основе законодательства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Опишите конституционно-правовые основы задач Кабинета Министров Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "Опишите порядок освобождения Премьер-министра Республики Узбекистан от занимаемой должности." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Опишите порядок выражения вотума недоверия Премьер-министру в Республике Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Дайте правовую характеристику подотчетности правительства парламенту." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Опишите правовой статус Премьер-министра Республики Узбекистан, его заместителей и членов правительства в рамках национального законодательства." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Дайте правовую характеристику конституционно-правовым основам деятельности органов самоуправления." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Опишите порядок заслушивания Кенгашем народных депутатов отчетов хокимов по наиболее важным и актуальным вопросам социально-экономического развития соответствующей территории." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Проанализируйте роль хокима в системе органов власти на местах. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Дайте правовое объяснение порядку формирования органов самоуправления граждан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Дайте правовую характеристику взаимоотношениям органов самоуправления граждан с государтсвенными органами на местах, исходя из Конституции Республики Узбекистан и законодательных актов." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Дайте правовую оценку роли судебной власти в системе органов государственной власти Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Объясните систему судебной власти. Объясните суть и значение последних конституционных реформ в судебной системе." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Как выражается в законодательстве вопрос об обеспечении независимости судебной власти в Узбекистане?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "Какова система органов прокуратуры Республики Узбекистан, их место и значение в системе государственных органов." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "Раскройте содержание полномочий и направления деятельности органов прокуратуры Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "Каковы конституционные основы внешней политики Республики Узбекистан?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Подробно опишите суть и значение конституционных реформ, осуществленных в Республике Узбекистан в результате принятия Стратегии действий." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Дайте правовую характеристику содержанию проводимых в Узбекистане реформ по совершенствованию избирательной системы. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Охарактеризуйте правовые основы деятельности комитетов и комиссий Сената Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "Раскройте правовой статус спикера Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Дайте правовое объяснение роли комитетов палат Олий Мажлиса Республики Узбекистан в парламентской деятельности." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "Дайте правовое объяснение участию фракций политических партий в деятельности Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Проанализируйте сходства и различия в принятии Олий Мажлисом Республики Узбекистан закона о внесении изменений в Конституцию, конституционного закона, законов и постановлений”." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Расскажите об избирательной системе Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Дайте правовое объяснение участию комиссий палат Олий Мажлиса Республики Узбекистан в деятельности парламента." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Охарактеризуйте полномочия депутатов Законодательной палаты и членов Сената Олий Мажлиса Республики Узбекистан?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Объясните организационно-правовой порядок формирования органов самоуправления граждан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Расскажите о правовых основах назначения референдума в Узбекистане." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Дайте правовую характеристику положения Конституции Республики Узбекистан в системе нормативно-правовых актов." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Охарактеризуйте полномочия палат Олий Мажлиса Республики Узбекистан в области административно-территориального устройства Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Объясните сущность и значение социального партнерства на основе законодательства Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Объясните сущность и значение общественного контроля на основе законодательства Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Проанализируйте особенности государственного правления Узбекистана, исходя из норм Конституции Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Охарактеризуйте формы парламентского контроля. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Раскройте суть и содержание запроса депутата Законодательной палаты Олий Мажлиса Республики Узбекистан." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Раскройте суть и содержание запроса члена Сената Олий Мажлиса Республики Узбекистан." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 1,
                Question = @"Гражданка К. обратилась в Конституционный Суд Республики Узбекистан с жалобой на решение прокуратуры города прекратить уголовное дело по факту гибели ее мужа, мотивировав это обращение тем, что были ущемлены ее конституционные права на получение объективных данных о ходе и результатов расследования.",
                Comment = @"Правомерно ли обращение? Находится ли данная проблема в компетенции Конституционного суда Республики Узбекистан?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 2,
                Question = @"Бывший гражданин Казахстана Насыров приобрел в установленном порядке гражданство Узбекистана, при этом его супруга, проживающая вместе с ним, является лицом без гражданства.",
                Comment = @"Имеет ли право на приобретение гражданства Узбекисана их совместный четырнадцатилетний ребенок?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 3,
                Question = @"Гражданка Каримова явилась на избирательный участок и попросила выдать ей 7 бюллетеней для голосования – для нее, членов ее семьи и соседей, которые не имели возможности или желаний явиться на выборы. В доказательство она предоставила расписку, в которой указывалось, что названные лица передают ей свое право участвовать в выборах.",
                Comment = @"Дайте юридическую оценку ситуации. Как следует поступить членам участковой комиссии?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 4,
                Question = @"Азимова вызвали в органы внутренних дел в связи с жалобой, поступившей от его соседей, о проведении в его квартире неразрешенных религиозных собраний. Азимов явился в органы внутренних дел и разъяснил, что он является членом зарегистрированной религиозной общины, а в его квартире проходят различные обряды с участием членов общины и заинтересованных лиц. Азимов отметил, что своего здания религиозная община пока не имеет, а законодательство Республики Узбекистан гарантирует свободное проведение богослужений, обрядов и подобных мероприятий.",
                Comment = @"Правомерны ли действия Азимова?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 5,
                Question = @"Гражданин А.Мурадов припарковал свой автомобиль в зоне действия знака “Остановка запрещена”, в связи с чем его автомобиль был эвакуирован специальной службой ГАИ. А.Мурадов счёл действия специальной службы ГАИ неправомерными, так как они нарушили право собственности, гарантированное Конституцией, и обратился с жалобой в Конституционный суд с требованием рассмотреть его вопрос в порядке судопроизводства по отдельным категориям дел. Конституционный суд отказал в разрешении вопроса, сославшись на то, что он рассматривает конституционность законов, применённых или подлежащих применению в конкретном деле, а также объяснив, что в жалобе не содержится обоснование неопределённости в вопросе о том, соответствует ли Конституции действия специальной службы ГАИ.",
                Comment = @"Каков порядок конституционного судопроизводства по отдельным категориям дел? Установлены ли требования к подаче конституционной жалобы в производство по отдельным категориям дел?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 6,
                Question = @"15 марта 2021 года судья Верховного суда Республики Узбекистан Ш. Вахобов прибыл в Ташкентский международный аэропорт в составе делегации с рабочим визитом в Германию.
Вахобов сообщил сотрудникам аэропорта и официальным лицам, что он имеет право на неприкосновенность как судья, поскольку все личные вещи проверяются перед посадкой на борт.
Однако официальные лица аэропорта подчеркнули, что это правило не действует в аэропорту, и подчеркнули, что такая проверка очень важна для безопасности самолета и его пассажиров, и попросили Ш. Вахобова пройти проверку, как и все остальные.
",
                Comment = @"Дайте юридическую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 7,
                Question = @"Гражданка Республики Узбекистан вступила в брак с гражданином ФРГ, пребывавшим на территории Республики Узбекистан в связи с заключением срочного трудового договора. После рождения ребёнка иностранный гражданин покинул территорию Республики Узбекистан, отказавшись дать согласие на приобретение ребёнком гражданства Республики Узбекистан.",
                Comment = @"Имеются ли основания для предоставления ребёнку гражданства Республики Узбекистан? В каком порядке он будет приобретать гражданство Республики Узбекистан?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 8,
                Question = @"В Законодательную палату Олий Мажлиса Республики Узбекистан группой депутатов был внесён проект Закона. В проекте Закона предусматривалось внесение изменений в Регламент Законодательной палаты Олий Мажлиса, согласно которому Кенгашу Законодательной палаты даётся право создавать новые комитеты, создание временных комиссий, также комитеты Законодательной палаты имели право принимать решения по некоторым вопросам от имени Законодательной палаты. По мнению инициаторов законопроекта, данная практика широко распространена в парламентах зарубежных стран, она служит оптимизации и повышению эффективности деятельности нижней палаты.",
                Comment = @"Обсудите порядок формирования структурных подразделений Законодательной палаты Олий Мажлиса Республики Узбекистан, их полномочия и направления деятельности."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 9,
                Question = @"Согласно решению хокима Ш. Ромитанского района Бухарской области, гражданину А. было отделено 3 гектаров площади земли для стройки дома. Гражданин А. начал стройку сооружения недвижимого имущества и завершил стройку на данной площади земли. После завершения стройки данного сооружения через заявление в суд со стороны районной прокуратуры, было признано, что решение хокима об отделении площади земли является недействительным. После этого, сооружение, вместе с площадью земли было отобрано от гражданина А. 
Недовольный гражданин А. обратился с жалобой в органы областной прокуратуры. Прокурор области оценил действия прокурора района законным. После этого гражданин А. обратился в суд по гражданским делам. 
",
                Comment = @"Дайте юридическую оценку ситуации. Обсудите основы и порядок решений хокима."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 10,
                Question = @"В сход граждан поступило коллективная жалоба о том, что расположенный на территории схода граждан «Богишамол», автомобильное предприятие загрязняет территорию махали, выбрасывает большое количество мусора и приводит в непригодность асфальтное покрытие улиц махали. Однако председатель схода граждан устно отказал принимать меры ссылаясь на то, что это государственное предприятие.",
                Comment = @"Дайте юридическую оценку ситуации. Обсудите какие полномочия у схода граждан по данному случаю в соответствии действующим законодательством."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 11,
                Question = @"Гражданин Республики Туркменистан К.Авезов обратился к руководителю УВД района Хонка Хорезмской области Очилбекову А., с заявлением о принятии его в гражданство Республики Узбекистан. В своем обращении, в качестве обоснования, К.Авезов указал, что он родился в Республике Узбекистан, а его родители и родственники являются гражданами Республики Узбекистан и проживают на территории Узбекистана. Но, руководитель УВД района Хонка Хорезмской области Очилбеков А. отклонил данное обращение.",
                Comment = @"1.	Правомерно ли отклонение обращения?
2.	Дайте правовую оценку ситуации.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 12,
                Question = @"Гражданин Х.Саломов в 2017 году развелся с супругой. Имеют новорожденного сына, в воспитании и в материальном содержании которого  он не участвовал. Х.Саломов решает покинуть территорию Республики Узбекистан и отправляется в США, где решает получить гражданство этой страны. Возмущенная неучастием мужа в воспитании сына, супруга Саломова подает на мужа в гражданский суд с иском о выплате алиментов. ",
                Comment = @"1.	Каким будет исход ситуации?
2.	Выйдет ли Саломов из гражданства Республики Узбекистан?
3.	Дайте правовую оценку данной ситуации.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 13,
                Question = @"Гражданка Республики Узбекистан С.Авазова решила усыновить гражданина Киргизии А.Самедова. А.Самедову было 17 лет, поэтому выход из гражданства Киргизии и принятие в гражданство Республики Узбекистан был процессом, который требует отдельного внимания. Через месяц А.Самедов вышел из гражданства Киргизии. Но, согласно законодательству Республики Узбекистан, ему, для принятия гражданства Республики Узбекистан требовалось постоянное проживание на территории страны в течение пяти лет, что гражданка С.Авазова отметила, что получение гражданства после усыновления осуществляется по-иному и А.Самедов является гражданином Республики Узбекистан с момента обращения в органы опеки и попечительства.",
                Comment = @"1.Дайте правовую оценку данной ситуации.
2. Каковы особенности получения гражданства в данной ситуации?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 14,
                Question = @"Гражданка Узбекистана Мелиева Ш. вышла замуж за гражданина России и выехала из Республики Узбекистан на постоянное место жительство в Иран. 
Через год у них родился ребенок, который приобрел гражданство России. Ещё через три года Мелиева Ш. оформила развод и приехала в Республику Узбекистан для постоянного проживания. Мелиева обратилась в территориальный орган МВД по вопросам миграции с заявлением о приобретении  гражданства Узбекистана своему трёхлетнему сыну. Однако ей было отказано. Правомерно ли, решение территориального органа МВД?
",
                Comment = @"1.	Как должен быть решен вопрос получения гражданства в данной ситуации?
2.	Дайте правовую оценку ситуации.
"
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 15,
                Question = @"ООО “Э” и АО “С” получили разрешение от органов государственной власти на местах города Ташкента право на использование в своей коммерческой рекламе изображения герба и гимна Республики Узбекистан. Прокурор города Ташкент внес протест в орган государственной власти на местах о нарушении Закона «О государственном гербе» и «О государственном гимне». ",
                Comment = @"1.	Как вы думаете каким будет исход ситуации?
2.	Является ли это нарушением?
3.	Дайте правовую оценку ситуации. 
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 16,
                Question = @"Гражданин Каюмов И. припарковал свой автомобиль в зоне действия знака “Остановка запрещена”. Автомобиль был эвакуирован специальной службой Главного управления безопасности дорожного движения. Каюмов И. посчитал действия специальной службы Главного управления безопасности дорожного движения неправомерными, поскольку они нарушают право собственности, гарантированное статьей 36 Конституции Республики Узбекистан. Главное управление безопасности дорожного движения представило возражения, в которых указало, что реализация права собственности должно осуществляться в рамках, установленных действующим законодательством. Право Главного управления безопасности дорожного движения осуществлять эвакуацию транспортных средств, мешающих дорожному движению, предусмотрено действующим законодательством.",
                Comment = @"1.	Дайте правовую оценку ситуации.
2.	В чем выражается право на собственность? Какие существуют особенности реализации этого права?
3.	Дайте правовую оценку ситуации.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 17,
                Question = @"Гражданка Л. Солиева подготовила документы для участия в гранте Малазийской программы технического сотрудничества, объявленном правительством Малайзии. Л. Солиева получила рекомендательное письмо от имени главы коллегии адвокатов, которое было написано на узбекском языке.
Документы на грант Малайзийской программы технического сотрудничества должны были быть представлены в Посольство Малайзии в Узбекистане через Министерство иностранных дел Республики Узбекистан. 15 марта 2019 года Л.Солиева передала документы в МИД. Однако сотрудник Управления по иностранным грантам МИД попросил ее подготовить рекомендательное письмо на русском языке.
 На вопрос, в чем причина этого, Солиевой ответили, что Департамент грантов МИД установил правило принимать рекомендательные письма для международных соискателей грантов на русском языке.
Неудовлетворенная этим, Л. Солиева 17 марта 2019 года обратилась в Управление развития государственного языка Кабинета Министров Республики Узбекистан, в пределах компетенции которого было рассмотрено обращение Л.Солиевой. В своей жалобе Л.Солиева указала, что МИД отказал в приеме ее письма на узбекском языке, представленного руководителем учреждения для участия в международном гранте, и потребовал от нее подготовить его на русском языке. Солиева также отметила, что работа в органах государственной власти и управления ведется на государственном языке, и граждане имеют право подавать обращения в государственные организации и учреждения на государственном языке.
В ответ Министерство иностранных дел Республики Узбекистан отметило, что рекомендательные письма для соискателей международных грантов не считаются обращением граждан, а непринятие рекомендательных писем, представленных на узбекском языке, не является процессом на государственном языке.
",
                Comment = @"Дайте юридическую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 18,
                Question = @"В организации в понедельник около 11 часов утра поставили гимн Республики Узбекистан. Работники оказались недовольными включенным гимном. По их мнению, гимн помешал исполнению возложенных на сотрудников обязанностей и качественному выполнению работы. Возмущенные сотрудники обратились с жалобой к руководству. Руководство возмутилось жалобой сотрудников палаты. По мнению руководства, государственный символ в виде гимна не может служить препятствием качественной работы.",
                Comment = @"Дайте правовую оценку ситуации.
Кто прав? Руководство торгово-промышленной палаты или сотрудники?
Когда может быть исполнен государственный гимн?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 19,
                Question = @"15 марта 2018 года на референдум был вынесен вопрос касательно важных вопросов общества и государства Республики Узбекистан. В тот же день, временно прописанный в районе «Учтепа» города Ташкента гражданин Б.Саидов, пришел проголосовать на референдуме. Но обнаружилось, что его фамилия отсутствует в списке голосующих. Когда гражданин Б.Саидов спросил членов участковой избирательной комиссии, почему его фамилия отсутствует в списке избирателей, ему ответили, что, причиной является временная прописка гражданина, и что он может участвовать на референдуме по месту постоянной прописки. Несогласный с данным ответом гражданин Б. Саидов обратился с жалобой в органы прокуратуры.  Сотрудник прокуратуры отклонил жалобу, сказав, что это относится к ведению административного суда. За этот период референдум закончился и вышли результаты.",
                Comment = @"Дайте правовую оценку данной ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 20,
                Question = @"В 2019 году газета «П» публикует необоснованную статью про деятельность ООО «Б» на первой полосе.
ООО «Б» потребовал дать опровержение по опубликованному материалу в газете «П», которая оскорбляет честь и достоинство, престиж деловитости данного ООО.  Сначала, редакция задерживала публикацию об опровержении по причине того, что время и объем статьи может навредить деятельности СМИ. Затем, спустя месяц, когда предприятие повторно попросило об опубликовании опровержения, редакция отказала это сделать. ООО «Б» обратилась в суд с жалобой по этому вопросу.
",
                Comment = @"Дайте правовую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 21,
                Question = @"Гражданин А.Сафаров, проживавший на территории схода граждан «Аъло» скончался. Из-за отсутствия наследников его недвижимость осталась без владельца. Со стороны схода граждан недвижимое имущество было передано гражданке Р.Турсуновой и её семье, которые потеряли кормильца. Спустя определённое время началась проверка со стороны органов прокуратуры. Во время проверки выяснилось, что гражданке Р. Турсуновой было передано недвижимое имущество, не имеющее владельца, и  это решение было признано недействительным. Дом был передан в пользу государства.",
                Comment = @"Дайте правовую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 22,
                Question = @"Супруги Саломовы развелись. Развод был болезненным для обеих сторон. Разгневанный обстоятельствами супруг опубликовал в средствах массовой информации все телефонные разговоры и свою личную переписку с супругой. Недовольная Саломова обратилась в органы прокуратуры с жалобой о нарушении тайны переписки и телефонных разговоров. Органы прокуратуры отказались принимать данную жалобу, мотивировав тем, что нарушения тайны переписки и телефонных разговоров здесь нет. Оскорбленная и не имевшая представления что делать дальше Саломова обращается к Вам за помощью.",
                Comment = @"Имеет ли здесь место нарушение тайны переписки и телефонных разговоров?
Что бы вы в качестве юриста посоветовали Саломовой?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 23,
                Question = @"Гражданин Ю. Олимов переехал в Ташкент с семьей по необходимости. Участковый официально заявил ему, что в течение 5 дней он должен будет зарегистрироваться по месту жительства. Когда гражданин Ю. Олимов обратился в РОВД по месту жительства на постоянную регистрацию, участковый инспектор сообщил, что гражданин Ю. Олимов не имеет права на постоянную регистрацию в Ташкенте и может зарегистрироваться по месту жительства. Когда гражданин Ю. Олимов пытался зарегистрироваться по месту жительства, он отклонил заявление гражданина, сославшись на недостатки в документах. Недовольный этим гражданин Ю. Олимов обратился в прокуратуру. В своем обращении он отметил, что Конституция Республики Узбекистан предусматривает право гражданина перемещаться с одного места на другое на территории республики.",
                Comment = @"Дайте юридическую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 24,
                Question = @"Житель Акалтинского района, лицо без гражданства Желтков Георгий, обратился к председателю 54-го Бозского избирательного округа, где проводятся выборы в Законодательную палату Олий Мажлиса, с просьбой осуществлять общественный контроль. В своем обращении он отметил, что намерен осуществлять контроль деятельности окружной избирательной комиссии на основе законодательства об общественном контроле и исходя из своей гражданской позиции. Председатель участковой избирательной комиссии гражданин Б. заявил, что у него нет такого права. Георгий Желтков, недовольный сложившейся ситуацией, обратился в Конституционный суд Республики Узбекистан.",
                Comment = @"Дайте юридическую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 25,
                Question = @"Жительница Ташкентской области Гудкова Елена, находясь на 12 сроке беременности решила сделать аборт. С этой целью она направилась в медицинское учреждение. Дипломированный медицинский врач отказался осуществлять аборт, ссылаясь на статью 24 Конституции Республики Узбекистан. По его словам, право на жизнь возникает не с момента рождения ребенка, а с момента зачатия в чреве матери. ",
                Comment = @"Прокомментируйте данную ситуацию.
С какого момента наступает право на жизнь? Правомерен ли отказ врача?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 26,
                Question = @"Гражданка А. оказалась тяжело больна. Врачи диагностировали рак последней стадии. Стадия была настолько серьезна, что гражданку А. сопровождали мучительные боли. Бессильная переносить болезнь гражданка А. умоляла мужа ввести в вену инъекцию, провоцирующую остановку сердца. Муж был против, но гражданка убедила его, что виновным он (муж) не будет, она (гражданка А) напишет расписку, которая снимет с него ответственность. Муж, видя беспомощность жены, не смог ей отказать и ввел в кровь инъекцию, в последствии которой гражданка А. скончалась. ",
                Comment = @"Прокомментируйте данную ситуацию.
Что означает право на жизнь?
Включает ли в себя «право на жизнь» право ею распоряжаться?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 27,
                Question = @"В одном из управлений органа государственной власти, начальником был назначен молодой человек, не имевший опыта работы в данной сфере, по сравнению с остальными работавшими до него сотрудниками управления. Большинство сотрудников управления составляли женщины. Молодой начальник, невзирая на большой практический и жизненный опыт, а также возраст сотрудниц, начал поручать им техническую работу, акцентируя внимание, на том, что они женщины, и не смогут работать с важными документами, а для аналитической работы с бумагами привлекая сотрудников-мужчин. Такая ситуация вызвала недовольство сотрудниц и разлад в коллективе, что послужило причиной обсуждения данной проблемы за пределами управления.",
                Comment = @"Содержатся ли в законодательстве правовые гарантии равноправия мужчин и женщин? 
Уместно ли отстранять женщин от определенного вида научных и аналитических работ? 
Прокомментируйте ситуацию.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 28,
                Question = @"Директор школы №13 А., где обучатся несовершеннолетние с нарушением опорно-двигательного аппарата, обратился с заявлением в районную прокуратуру. В заявлении он указал, что здание школы находится в неудовлетворительном состоянии, а некоторые элементы конструкции здания представляют непосредственную угрозу для жизни и здоровья обучающихся. Так, местами разрушена кирпичная кладка цоколя здания, имеются следы протекания кровли, вследствие чего происходит вымокание и почернение внутренних стен с отслоением штукатурки, в учебных классах и спортзале имеется прогиб деревянного пола, здание школы не оборудовано пандусом для доступа маломобильных групп населения.",
                Comment = @"1. Какие действия должен предпринять прокурор района для восстановления здания школы и обеспечения безопасности детей?
2. Можно ли обратиться с жалобой на плохое техническое состояние здания школы в другие органы власти? Если да, то, в какие органы власти и целесообразно ли это?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 29,
                Question = @"Прокурор г. Ташкент возбудил уголовное дело против группы хулиганов, которые ворвались в помещение, принадлежащее местной религиозной организации, разбили обрядовую утварь и разогнали собравшихся. Было возбуждено уголовное дело по статье 145 Уголовного Кодекса «Нарушение свободы совести». Адвокат обвиняемых заявил, что дело подлежит прекращению, поскольку Конституция не раскрывает понятия “права на свободу совести” и не дает определение религиозного обряда. Кроме того, Конституция не содержит санкции на нарушение нормы о свободе совести, а следовательно, в составе данной нормы при наличии гипотезы и диспозиции отсутствует санкция. ",
                Comment = @"Подлежит ли дело прекращению на основании изложенных доводов защиты? 
В чем специфика такого элемента конституционно-правовой нормы, как санкция? 
Обладают ли нормы Конституции свойствами прямого действия?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 30,
                Question = @"Гражданин в течение 3 месяцев не получал заработную плату. Невыплату зарплаты руководство учреждения обосновало отсутствием необходимого финансирования. Гражданин обратился в Европейский суд по правам человека. По его мнению, невыплата денежных средств является нарушением его права собственности, поскольку эти средства он рассчитывал получить. Долохов просил, помимо взыскания задолженности, компенсировать моральный вред, причиненный задержкой зарплаты и, как следствие, отсутствием средств к существованию. Кроме того, заявитель полагал, что государство не обеспечивает его конституционное право на справедливые условия труда (статья 37), по сравнению с другими работниками других организаций. Возражая на жалобу Долохова, представитель Республики Узбекистан утверждал, что упомянутая правовая позиция в данном случае неприменима. Отрицая право на получение компенсации морального вреда, представитель Республики Узбекистан, ссылался на действующее национальное законодательство, которое не признает наличия морального вреда при нарушении имущественных прав, за исключением указанных в законе.",
                Comment = @"В чем отличие роли государства в обеспечении политических и личных прав и свобод, с одной стороны, и социально-экономических – с другой? 
Какое решение должен принять суд по жалобе Долохова?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 31,
                Question = @"Представьте, Вы депутат Законодательной палаты Олий Мажлис Республики Узбекистан. Вам поступает для предоставления заключения внесенный в Законодательную палату проект Закона об установлении уголовной ответственности за приобретение гражданами Республики Узбекистан второго гражданства. ",
                Comment = @"Какое бы Вы дали заключение?
Нужна ли уголовная ответственность? Почему?
Аргументируйте свой ответ.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 32,
                Question = @"В 2017 году в СМИ распространилась информация о задержании хокима района. СМИ опубликовали подробности уголовного дела, считая виновным хокима района в злоупотреблении властью и взяточничестве. Адвокат хокима считает, что СМИ нарушил принцип презумпции невиновности. По мнению адвоката СМИ должны быть сдержанными в распространении информации, поскольку формируют общественное сознание. ",
                Comment = @"Что такое презумпция невиновности?
Почему адвокат считает, что СМИ нарушили принцип презумпции невиновности?
На самом деле, на ваш взгляд, имеет ли здесь место нарушение принципа презумпции невиновности?
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 33,
                Question = @"Проживающая в Самарканде гражданка Республики Узбекистан Фарида вышла замуж в 18 лет, и в настоящее время проживает со свекровью, свекром и имеет двух детей. Фарида пыталась поступить в университет, но безуспешно. Пройти экзамен ей не удалось. Узнав о льготах поступления в ВУЗы Узбекистана после прохождения службы в армии, Фарида также узнала, что для женщин данные льготы при поступлении не предусмотрены. Расстроенная Фарида рассказала о факте ограничения прав женщин мужу, который сказал: «льготы после прохождения службы в армии не для женщин».",
                Comment = @"Дайте правовую оценку ситуации."
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 34,
                Question = @"Для успешного участия на парламентских выборах, политическая партия “А”, приняла большую сумму благотворительной валюты от международной организации, с которой имеет долгосрочное договорное сотрудничество и от иностранного гражданина, который поддерживает цели и идеи, закрепленные в политической платформе партии.  От полученных средств, политическая партия организовала встречу с кандидатами, стол для гостей за свой счет, раздала подарки на память. Согласно представленной информации от органов государственной власти на местах и банковских-финансовых управлений, Центральная избирательная комиссия отстранила политическую партию от участия на выборах. Активисты данной политической партии были не согласны с решением, и обратились с жалобой в Конституционный суд.",
                Comment = @"Дайте правовую оценку ситуации.
Определите порядок и условия финансирования политических партий на основе законодательных актов.
"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 35,
                Question = @"Гражданин Ш. оспаривает принятое сходом граждан махалли «Адолат» города Ташкента решение об обязательном ежегодном субботнике по уборке мусора, озеленению и благоустройстве придомовых территорий  населенных махалли. Ш. считает, что органы самоуправления не вправе принимать общеобязательные решения, поскольку они по Конституции не являются государственными органами, а значит и органами власти. Право на осуществление самоуправления – это право тех граждан, кто желает решать свои проблемы местного значения, однако поскольку подавляющее большинство избирателей (более 80%) даже не принимает участия в выборах органов самоуправления, то и права выступать от имени всех жителей у этих органов нет.",
                Comment = @"Какова правовая природа органов самоуправления граждан и особенности права граждан на осуществление самоуправления?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 36,
                Question = @"В областной газете в репортаже о конкурсе красоты была размещена фотография конкурсантки, курившей сидя на подоконнике в коридоре Дома культуры, где проходил конкурс. Героиня снимка посчитала это вмешательством в свою частную жизнь и обратилась с иском в газету, ссылаясь, помимо положений статьи 27 Конституции Узбекистана, на положения Гражданского кодекса о защите права лица на собственное изображение. Отвечая на иск, юристы газеты заявили, что нахождение человека в общественном месте, свободном для доступа других лиц, не может быть отнесено к сфере его частной жизни и следовательно никаких разрешений на съемку не требуется. ",
                Comment = @"Какое решение должен вынести суд?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 37,
                Question = @"В ежегодном отчете Уполномоченного по правам человека упоминалось о злоупотреблениях и превышении должностных полномочий служащими областного хокимията. Основываясь на этой информации, группа граждан обратилась в прокуратуру с просьбой возбудить уголовное дело по факту указанных злоупотреблений. Прокурор отказал в возбуждении уголовного дела, уведомив об этом хокима. Через 1,5 месяца хоким обратился в суд с иском против группы граждан, которые просили прокурора о возбуждении дела, требуя защиты чести, достоинства и деловой репутации, а также возмещения морального вреда, так как решения суда, подтверждающего виновность служащих, не выносилось. ",
                Comment = @"Какое решение должен принять суд? Можно ли привлечь к участию в судебном разбирательстве самого Уполномоченного по правам человека? Каковы юридические последствия изложения в отчете Уполномоченного по правам человека о нарушениях прав граждан?"
            });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 38,
                Question = @"После 3-х кратного отклонения предложенной кандидатуры на должность Премьер-министра Президент не распустил палаты Олий Мажлиса, а начал вести переговоры с лидерами партийных фракций и в результате предложил новую кандидатуру, которая и была утверждена. 
Вправе ли Президент трижды предлагать для утверждения в палаты Олий Мажлиса одну и ту же кандидатуру? Приведите правовые аргументы со ссылками на действующие правовые акты в обоснование своей позиции. Вправе ли палаты Олий Мажлиса утвердить четвертую по счету кандидатуру на должность премьер-министра, или она должна потребовать роспуска?
",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 39,
                Question = @"Депутат Законодательной палаты Олий Мажлиса во время заседания Законодательной палаты допустил высказывания, носившие националистический характер, направленные на возбуждение национальной вражды. Эти высказывания были воспроизведены им в интервью газете “Д”. В связи с указанными фактами Генеральным прокурором было возбуждено уголовное дело по части второй статьи 156 Уголовного кодекса и материалы дела вместе с подготовленным обвинительным заключением были представлены в Законодательную палату Олий Мажлиса. Для получения согласия на передачу дела в суд.",
                Comment = @"Что такое депутатский индемнитет и иммунитет, какова цель их юридического закрепления и правовое содержание? Может ли депутат быть привлечен к уголовной ответственности по части второй статьи 
156 Уголовного кодекса?"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 40,
                Question = @"Гражданин Республики Туркменистан К.Авезов обратился к руководителю УВД района Хонка Хорезмской области Очилбекову А., с заявлением о принятии его в гражданство Республики Узбекистан. В своем обращении, в качестве обоснования, Авезов К. указал, что родился в Республике Узбекистан, а его родители и родственники являются гражданами Республики Узбекистан и проживают на территории Узбекистана. Также, было отмечено, что второй абзац 2-пункта второй части 17 статьи закона 
«О гражданстве Республики Узбекистан» к нему не относится. Но, руководитель УВД района Хонка Хорезмской области Очилбеков А. отклонил данное обращение.",
                Comment = @"Дайте правовую оценку ситуации. Проанализируйте порядок приема в гражданство Республики Узбекистан."
            });

            /*this.Logical_Cases_1.Add(new Quiz_Item() { Id = 41, Question = @"O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasiga 2014 yilning 21 dekabr kuni bo‘lib o‘tgan saylovlardan so‘ng qonunchilikda belgilangan tartibda O‘zbekiston Respublikasi Bosh vaziri tasdiqlandi va u O‘zbekiston Respublikasi Prezidenti bilan kelishilgan holda O‘zbekiston Respublikasi Vazirlar Mahkamasi tarkibini shakllantiridi. Hukumat tarkibi shakllantirilganidan so‘ng, bir qator vazirlar va davlat qo‘mitalari raislarining o‘rinbosarlari, shuningdek davlat boshqaruvining boshqa organlari rahbarlari O‘zbekiston Respublikasi Prezidenti tomonidan to‘g‘ridan-to‘g‘ri lavozimga tayinlanadi. Biroq, O‘zbekiston Respublikasi Bosh vaziri O‘zbekiston Respublikasi Konstitutsiyasiga muvofiq, Vazirlar Mahkamasi faoliyatini tashkil etishi va unga rahbarlik qilishi, uning samarali ishlashi uchun javobgar shaxs ekanligini ko‘rsatdi hamda ushbu lavozimlarga nomzodlar ham u bilan kelishilishi lozimligi haqida fikrlar paydo bo`ldi. 
", Comment = @"Vaziyatga huquqiy baho bering. 
Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 42, Question = @"Fuqaro A.Murodov o‘z avtomashinasini to‘xtash taqiqlangan belgi zonasiga to‘xtatib qo‘yganligi munosabati bilan YPX maxsus xizmati tomonidan avtomobili evakuatsiya qilingan. A.Murodov maxsus yo‘l harakati xavfsizligi xizmati xodimlarining xatti-harakatlari Konstitutsiyada kafolatlangan mulk huquqini buzganligi sababli ularni qonunga xilof deb hisoblab, Konstitutsiyaviy sudga uning masalasini ayrim toifali ishlar bo‘yicha ish yuritish jarayonida ko‘rib chiqish talabi bilan murojaat qilgan. Konstitutsiyaviy sud vakolati doirasida faqat muayyan ishda qo‘llanilgan yoki qo‘llanilishi kerak bo‘lgan qonunlarning Konstitutsiyaga muvofiqligi yuzasidan ishlarni ko‘rib chiqishini ta’kidlab, masalani hal qilishdan bosh tortdi. Shuningdek, shikoyatda YPX xodimlarining xizmati borasida noaniqliklar mavjudligini ko‘rsatib, ushbu masala bo‘yicha YPX xizmatining Konstitutsiyaga zid harakatlari aniqlanmaganligini ta’kidladi.
", Comment = "Ayrim toifadagi ishlar bo‘yicha konstitutsiyaviy ish yuritish tartibi qanday? Ayrim toifadagi ishlar bo‘yicha protsessda konstitutsiyaviy shikoyat berish uchun talablar mavjudmi?" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 43, Question = @"“Bahor” mahalla fuqarolar yig‘ini raisi (oqsoqoli) va uning maslahatchilari saylovini tashkil etish hamda o‘tkazish uchun tuzilgan Ishchi guruh fuqarolar yig‘ini raisi (oqsoqoli) lavozimiga nomzodlarga doir hujjatlarni tayyorlab, tuman hokimi bilan kelishish uchun tegishli tuman komissiyasiga taqdim etdi. Tuman xokimi taqdim etilgan 5ta nomzodning hujjatlarini o‘rganib chiqdi hamda taqdim etilgan 3ta nomzodni nomunosib nomzod sifatida ro‘yxatdan chiqarish haqida ko‘rsatma berdi.
“Bahor” mahalla fuqarolar yig‘ini hududida istiqomat qiluvchi bir guruh fuqarolar tomonidan Ishchi guruhga tavsiya qilingan nomzod D.Jalilovning nomzodi ham tuman xokimi tomonidan ma’qullanmadi. Shu sababli, uning nomzodini qo‘llab-quvvatlovchi bir guruh fuqarolar D.Jalilovning buzilgan huquqlarini himoya qilishda yordam berishni so‘rab tuman prokuraturasiga  murojaat qilishdi.
", Comment = @"Vaziyatga huquqiy baho bering.
Fuqarolar yig‘ini raisi (oqsoqoli) nomzodlarini xokim bilan kelishish" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 44, Question = @"Qonun loyihasi O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasi tomonidan uchinchi o‘qishda qabul qilinib, Senat tomonidan ma’qullanganidan so‘ng, O‘zbekiston Respublikasi Prezidentiga imzolash uchun yuborildi. Biroq davlat boshlig‘i o‘z e’tirozlari bilan Qonuni imzolamasdan qaytardi. Bunday holatda Oliy Majlis palatalari Qonunni avvalgi qabul qilingan tahririda qayta ovozga qo‘yish yoki davlat boshlig‘i e’tirozlari inobatga olgan holda uni qayta ishlab, so‘ng qabul qilishi lozim edi. Parlament palatalari birinchi yo‘lni tanladi. Qonun avvalgi tahrirda Qonunchilik palatasi deputatlari va Senati a’zolari umumiy sonining to‘rtdan uch qismidan iborat ko‘pchilik ovozi bilan ma’qullandi, ya’ni Prezident vetosi yengib o‘tildi. Biroq davlat boshlig‘i qayta ovoz berish protsedurasi qo‘pol ravishda buzilganligini ko‘rsatib Qonunni imzolamasdan qoldirdi.
", Comment = @"Vaziyatga huquqiy baho bering. 
Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 45, Question = @"Navoiy viloyati xalq deputatlari kengashining navbatdan tashqari sessiyasida Navoiy viloyati Karmana tumani hokimini o‘z vazifasidan ozod etildi. Hamda Navoiy viloyati Karmana tumaniga rahbarlik qilishni Vazirlar Mahkamasining qaroriga asosan tuman hokimi o‘z vazifasidan ozod etilganligi bois, ushbu hududga rahbarlikni Xatirchi tumani hokimiga topshirdi. Endilikda Xatirchi tumani hokimi ham Karmana tumaniga ham Xatirchi tumaniga rahbarlikni amalga oshira boshladi. 
Mazkur masala yuzasidan O‘zbekiston Respublikasi Oliy Majlis qonunchilik palatasi Vazirlar Mahkamasiga o‘z e’tirozini bildirgan holda mazkur holat amaldagi qonun me’yorlari talablariga muvofiq emasligini ko‘rsatgan holda ushbu qarorini noqonuniy deb hisoblagan holda bu holat ikki tumanning ma’muriy hududiy birligiga ham ma’lum bir ma’noda ta’sir ko‘rsatishini ya’ni birlashtirib yuborilishini anglatishini ta’kidladi.
", Comment = @"Vaziyatga huquqiy baho bering.
Vazirlar Mahkamasi tomonidan mazkur amalga oshirilgan holat amaldagi qonunchilik talablari doirasida qabul qilinganmi mazkur holatni muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 46, Question = @"Fuqaro F. o‘z oilasi bilan Uchtepa tumanidagi ko‘p qavatli uyda yashaydi. Uning keksa onasi davlat muassasasi (Qariyalar uyi) qaramog‘iga olingan. Onasi tuman sudiga murojat qilib o‘g‘li undan xabar olmayotganligidan shikoyat qiladi. 
Uchtepa tuman sudi F.ni chaqirtirib unga onasining holidan xabar olib turishi kerakligini, agar fuqaro o‘z konstitutsiyaviy majburiyatini bajarmasa va onasiga g‘amxo‘rlik qilmasa aliment to‘lash majburiyati yuklatilishini bildirib, ogohlantiradi. 
Fuqaro F. dam olish kuni oilasi bilan onasini ko‘rgani muassasaga boradi. Onasi fuqaro F.ga o‘zining ehtiyojlari uchun 1 000 000 (bir million) so‘m miqdorda pul zarurligini aytib, shu pulni berishini so‘raydi. Lekin fuqaro F. onasiga so‘ragan pulini berishdan bosh tortadi va onasini moddiy yordamga muhtoj emasligi chunki u davlat muassasasi qaramog‘ida ekanligini vaj qilib keltiradi.
", Comment = @"Ushbu vaziyatga huquqiy baho bering. 
F.ning xatti-harakatlari qonuniymi? Buni huquqiy asoslarini muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 47, Question = @"Gazeta jurnalisti F.O. oziq-ovqat yarmarkasida holatni videotasvirga olish paytida Chinoz tumani hokimi o‘rinbosari uning qo‘lidan telefonni olishga harakat qilgan.  Keyinroq uni tuman ichki ishlar bo‘limiga olib keltirgan va ushlab turgan.  IIB binosida jurnalistning telefon qurilmasidagi videoyozuvlar o‘chirib tashlangan. 
Jurnalist o‘zining huquq-erkinliklari qo‘pol buzilishi borasida huquqiy baho berishni so‘rab Bosh prokuraturaga murojaat qildi. 
Jurnalist faoliyatiga to‘sqinlik qilib, jurnalistga qo‘pol munosabatda bo‘lgan hokimiyat vakili esa bu yerda o‘zining aybdor emasligini, o‘sha kuni yarmarkada anglashilmovchilik ro‘y berganini aytib, fuqarodan og‘zaki uzr so‘raydi. 
", Comment = "Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qilib, vaziyatga huquqiy baho bering." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 48, Question = @"2015 yil 18 iyun saylov o‘tkaziladigan kuni Jizzax viloyati telekanali xodimlari kelib saylov uchastkasidagi saylovchilarning fikr-mulohazalarni, birinchi navbatda, saylovchilardan nomzodga nima sabablar tufayli ovoz berayotganligini, saylovda kim yutib chiqishi haqidagi fikrlarni saylovchidan kelgusida nima natijalar kutayotganligini o‘rgana boshlanadi. O‘z navbatida viloyat telekanali xodimlari saylovning natijasi yuzasidan prognozlar chiqara boshladi. Shu payt saylov uchastkasi raisi bu holatdan xabar topib, telekanali xodimlaridan o‘z ishini to‘xtatishini, intervyu va reportajlar olishini taqiqladi. Viloyat telekanali xodimlari saylov uchastkasi raisi harakatlaridan norozi bo‘lib, saylov to‘g‘risidagi qonunchilik normalariga ko‘ra saylovlar ochiq, oshkoralik, erkinlik, adolatlilik, mas’ullik prinsiplariga asosan o‘tkazilishi lozimligini aytib e’tiroz bildirdi. Shuningdek, saylov uchastkasi raisi ustidan Markaziy saylov komissiyaga shikoyat qilishini bildirdi.
", Comment = @"Vaziyatga huquqiy baho bering.
 Ushbu holatda qaysi qonun hujjatlari buzilganligini muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 49, Question = @"Mirobod tumanida yashovchi fuqaro A. 2012 yil noyabr oyida tuman hokimiyatiga murojat qilib farzand asrab olmoqchiligini aytadi. Tuman hokimiyati unga o‘zi xaqidagi ma’lumotlarni berishi va ish joyidan ma’lumotnoma olib kelishligini so‘raydi. Fuqaro A. aytilgan barcha hujjatlarni olib keladi, lekin hujjatlar ichida fuqaro A. qaerda ishlashi haqidagi ma’lumotnoma chiqmaydi. Shundan so‘ng tuman hokimiyati xodimi unga hujjatlarida kamchiligi borligini aytib, agarda, u tegishli hujjatlarni ikki kun ichida olib kelmasa unga farzand asrab olishga ruxsat berilmasligini aytadi. Ayrim mutaxassislar sudga bu masalada murojaat etishni bildirdilar. Fuqaro A ushbu holat yuzasidan O‘zbekiston Respublikasi Konstitutsiyaviy sudiga murojaat qiladi va o‘zining konstitutsiyaviy huquqlari buzilganligidan e’tiroz bildiradi. O‘zbekiston Respublikasi Konstitutsiyaviy sudi ushbu murojaatda ko‘tarilgan masalalar fuqarolik ishlari bo‘yicha tumanlararo sud vakolatiga tegishli bo‘lganligi sababli, mazkur shikoyat Konstitutsiyaviy sud vakolat doirasiga kirmasligini bildirdi. 
", Comment = @"Ushbu vaziyatga huquqiy baho bering. 
Ushbu vaziyatda Konstitutsiyaviy sudning Fuqaro A.ga yo‘llagan javobi qonuniymi? Tegishli huquqiy hujjatlar asosida muhokama qiling." });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 50, Question = @"O‘zbekiston Respublikasi Oliy Majlisi Qonunchilik palatasiga bo‘lib saylov natijalariga ko‘ra, hech bir nomzod qonunda nazarda tutilgan yetarli ovozlarni to‘play olmaganligi tufayli 35 ta saylov okrugida takroriy ovoz berish hamda 5 ta saylov okrugidan saylovlar jarayonida qonun buzilishlariga yo‘l qo‘yilganligi tufayli takroriy saylov o‘tkazish zarurligi ma’lum bo‘ldi. 
Boshqa saylov okruglardan saylangan ayrim deputatlar esa ushbu saylov okruglarida takroriy ovoz berish va takroriy saylov natijalari ma’lum bo‘lmasdan turib ham Oliy Majlis Qonunchilik palatasini saylangan va o‘z faoliyatini boshlashi mumkin deb hisoblab, Markaziy saylov komissiyasi raisiga Qonunchilik palatasining birinchi majlisini chaqirish, palata rahbar organlari va qo‘mitalari tarkibini shakllantirish   to‘g‘risida ariza bilan murojaat qilishdi. Markaziy saylov komissiyasi raisi mazkur arizaga nisbatan rad javobini berdi. 
", Comment = @"Ushbu holatni O‘zbekiston Respublikasi qonunchiligi doirasida muhokama qilib, vaziyatga huquqiy baho bering.
 Saylangan deputatlarning talablari asoslimi? Mazkur holat qanday hal qilinishi lozim?" });*/
            /*this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 38,
                Question = @"После 3-х кратного отклонения предложенной кандидатуры на должность Премьер-министра Президент не распустил палаты Олий Мажлиса, а начал вести переговоры с лидерами партийных фракций и в результате предложил новую кандидатуру, которая и была утверждена. 
Вправе ли Президент трижды предлагать для утверждения в палаты Олий Мажлиса одну и ту же кандидатуру? Приведите правовые аргументы со ссылками на действующие правовые акты в обоснование своей позиции. Вправе ли палаты Олий Мажлиса утвердить четвертую по счету кандидатуру на должность премьер-министра, или она должна потребовать роспуска?
",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 39,
                Question = @"Депутат Законодательной палаты Олий Мажлиса во время заседания Законодательной палаты допустил высказывания, носившие националистический характер, направленные на возбуждение национальной вражды. Эти высказывания были воспроизведены им в интервью газете “Д”. В связи с указанными фактами Генеральным прокурором было возбуждено уголовное дело по части второй статьи 156 Уголовного кодекса и материалы дела вместе с подготовленным обвинительным заключением были представлены в Законодательную палату Олий Мажлиса. Для получения согласия на передачу дела в суд. 
Что такое депутатский индемнитет и иммунитет, какова цель их юридического закрепления и правовое содержание? Может ли депутат быть привлечен к уголовной ответственности по части второй статьи 
156 Уголовного кодекса?
",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 40,
                Question = @"Гражданин Республики Туркменистан К.Авезов обратился к руководителю УВД района Хонка Хорезмской области Очилбекову А., с заявлением о принятии его в гражданство Республики Узбекистан. В своем обращении, в качестве обоснования, Авезов К. указал, что родился в Республике Узбекистан, а его родители и родственники являются гражданами Республики Узбекистан и проживают на территории Узбекистана. Также, было отмечено, что второй абзац 2-пункта второй части 17 статьи закона 
«О гражданстве Республики Узбекистан» к нему не относится. Но, руководитель УВД района Хонка Хорезмской области Очилбеков А. отклонил данное обращение. 
Дайте правовую оценку ситуации. Проанализируйте порядок приема в гражданство Республики Узбекистан.  
",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 41,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 42,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 43,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 44,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 45,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 46,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 47,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 48,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 49,
                Question = @"",
                Comment = @""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 50,
                Question = @"",
                Comment = @""
            });*/

        }


        private void Generator_MockData_Uz_H()
        {
            #region OLD QUIZ
            /*this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Huquqbuzarliklar profilaktikasi fanining predmeti haqida ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Huquqbuzarliklar profilaktikasi fanining maqsadi nimalardan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Huquqbuzarliklar profilaktikasi fanining vazifalarini sanab o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Huquqbuzarliklar profilaktikasi deganda nima nazarda tutiladi? " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "Huquqbuzarliklar profilaktikasini tashkil etishda turli xil xarakterdagi chora-tadbirlar ishlab chiqiladi. Ular qanday chora-tadbirlar?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Huquqbuzarliklar profilaktikasi faoliyatini tartibga soluvchi qonunlarni tahlil qiling. Bevosita va bilvosita qonunlarni sharhlang." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Huquqbuzarliklar profilaktikasi nima? Huquqbuzarliklar profilaktikasining mohiyati, xususiyati va qonuniyatlarini batafsil yoriting. " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Huquqbuzarliklar profilaktikasining asosiy prinsiplari haqida batafsil ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Huquqbuzarliklar profilaktikasi fanining predmeti sifatida g‘ayriijtimoiy xulq-atvor tushunchasini xususiyatlarini yoriting. " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Huquqbuzarliklar profilaktikasining maqsadlari nimalardan iborat? O‘zbekistonda ushbu sohaga katta e’tibor berilishiga sabab nimadan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Huquqbuzarliklar profilaktikasi sohasini takomillashtirish bo‘yicha O‘zbekiston Respublikasida amalga oshirilayotgan islohotlarni yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Huquqbuzarlik jabrlanuvchisi kim? Moddiy, ma’naviy va jismoniy zarar tushunchalariga oydinlik kiriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Huquqbuzarliklar profilaktikasining turlari bo‘yicha ma’lumot bering. Ularning turlarga ajratishdan maqsad nima?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Huquqbuzarliklar profilaktikasini amalga oshiruvchi va unda ishtirok etuvchi organlar hamda muassasalarning huquqbuzarliklarning oldini olish, huquqbuzarliklarning sodir etilishi sabablarini va unga imkon berayotgan shart-sharoitlarni aniqlash, bartaraf etish bo‘yicha faoliyati huquqbuzarliklarning qaysi turiga xos xususiyat hisoblanadi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Huquqbuzarliklarning umumiy profilaktikasi ob’ektlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Huquqbuzarliklarning umumiy profilaktikasining usullarini tahlil qiling va o‘zaro farqli jihatlarini yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Huquqbuzarliklarning sabab va sharoitlarini mazmuni bo‘yicha tasniflashda qaysi turlarga ajratiladi? Ular haqida batafsil ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Huquqbuzarliklarning sabab va sharoitlarini mazmuni bo‘yicha tasniflashda siyosiy sabab va sharoitlari alohida ahamiyatga ega. Korrupsiya jinoyatining boshqa siyosiy sabab va sharoitlardan farqi nimada?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Terrorizm va diniy ekstremizm xavfi kuchayganda qanday maxsus profilaktik tadbirlar o‘tkaziladi. " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Ma’muriy hududdagi kriminogen vaziyatni keltirib chiqaruvchi omillarga batafsil to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Profilaktika inspektori tomonidan yuritiladigan ish kitoblarinni yoritib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Ma’muriy hududdagi kriminogen vaziyatni baholash nimadan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Ma’muriy hudud kitobi (pasporti) ni to‘liq yoritib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "2022 – 2025 yillarda O‘zbekiston Respublikasida jamoat xavfsizligini ta’minlash tizimini rivojlantirish Strategiyasida jamoat xavfsizligini ta’minlashning huquqiy asoslarini rivojlantirish maqsadida qanday qonun hujjatlari loyihalari ishlab chiqilishi nazarda tutildi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Profilaktika inspektorining ma’muriy hududdagi kriminogen vaziyatni o‘rganish va tahlil qilish faoliyatiga oid me’yoriy hujjatlarni tahlil qiling" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Profilaktika inspektorining jinoyatlarni fosh etish va qidiruvdagi shaxslarni aniqlash faoliyatining o‘ziga xos xususiyati nimadan iborat." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Profilaktika inspektori tomonidan qidiruvdagi shaxslarni aniqlash davomida bajariladigan chora-tadbirlarni yoritib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Oiladagi tazyiq va zo‘ravonlikdan himoya qilish sohasidagi davlat siyosatining asosiy yo‘nalishlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "Oiladagi tazyiq va zo‘ravonlikdan himoya qilish sohasidagi vakolatli davlat organlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Xotin-qizlarni tazyiq va zo‘ravonlikdan himoya qilish bo‘yicha joriy qilingan himoya orderi, uni berish tartibi va uning muddatini uzaytirish bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Himoya orderi bo‘yicha huquqiy me’yorlardagi yangiliklarni ayting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Oilalardagi tazyiq va zo‘ravonlikdan himoya qilish sohasini tartibga soluvchi huquqiy me’yorlarga batafsil to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Voyaga yetmaganlar o‘rtasida nazoratsizlik va huquqbuzarliklar profilaktikasini tashkil etish va ularning faoliyatini muvofiqlashtiruvchi organlarga to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Voyaga yetmaganlar o‘rtasida nazoratsizlik va huquqbuzarliklar profilaktikasini tartibga soluvchi huquqiy me’yorlarga batafsil to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Profilaktika inspektorining voyaga yetmaganlar o‘rtasida nazoratsizlik va huquqbuzarliklar profilaktikasi bo‘yicha faoliyatining asosiy yo‘nalishlari nimalardan iborat." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Voyaga yetmaganlarni ixtisoslashtirilgan o‘quv tarbiya muassasasiga joylashtirish tartibi." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Voyaga yetmaganlarni ijtimoiy-huquqiy yordam ko‘rsatish markaziga joylashtirish tartibi." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Profilaktika inspektori tomonidan voyaga yetmaganlarni ixtisoslashtirilgan o‘quv tarbiya muassasasiga joylashtirish bo‘yicha tayyorlanishi lozim bo‘lgan hujjatlarga to‘xtaling." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Profilaktika inspektorining uy qamog‘i tarzidagi ehtiyot chorasi qo‘llanilgan shaxslarni hisobga olish va nazoratini amalga oshirish tartibi." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Uy qamog‘i tarzidagi ehtiyot chorasini qo‘llash asoslari, tushunchasi va huquqiy asoslari." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Profilaktika inspektori uy qamog‘i tarzidagi ehtiyot chorasi qo‘llanilgan shaxs bilan suhbat o‘tkazishi va unga tushuntirishi lozim bo‘lgan holatlarga tushuncha bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Profilaktika inspektorining probatsiya xizmati bilan ishlash faoliyatini tushuntirib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Profilaktika inspektorining probatsiya xizmati nazoratidagi shaxslar bilan ishlash faoliyatini tushuntirib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Profilaktika inspektorining profilaktik hisobda turuvchi shaxslar bilan ishlash faoliyatini tushuntirib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Ma’muriy nazorat tushunchasiga ta’rif bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Profilakitika inspektorining jazoni ijro etish mussasalaridan ozod qilingan ayrim toifadagi shaxslar ustidan ma’muriy nazoratni ta’minlash bo‘yicha faoliyatini tushuntirib bering" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Jazoni ijro etish mussasalaridan ozod qilingan ayrim toifadagi shaxslar ustidan ma’muriy nazorat sohasini tartibga soluvchi qonun hujjatlarini yoritib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Profilakitika inspektorining jazoni ijro etish mussasalaridan ozod qilingan ayrim toifadagi shaxslar ustidan ma’muriy nazoratni o‘rnatish bo‘yicha bajarishi lozim bo‘lgan hujjatlar loyihalarini tayyorlang." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Ma’muriy nazorat qoidalarini batafsil yoritib bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Ma’muriy nazoratdan bo‘yin tovlanganda kelib chiqadigan yuridik oqibatlar haqida to‘xtaling." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Profilaktika inspektorining muayyan yashash joyiga ega bo‘lmagan shaxslar bilan ishlash faoliyatini tushuntiring." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Reabilitatsiya markazlarining asosiy vazifalari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Muayyan yashash joyiga ega bo‘lmagan shaxsga ta’rif bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Reabilitatsiya markazlari kimlar uchun tashkil etilgan." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Narkologik yordam sohasini tartibga solish sohasidagi vakolatli davlat organlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Aholiga narkologik yordam ko‘rsatishning ijtimoiy va huquqiy tomonlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Narkologik kasalliklarga chalingan shaxslarni majburiy davolash bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Narkologik kasallikka chalingan shaxsni majburiy davolashga yuborish tartibi bo‘yicha qonun hujjatlarini yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Narkologik kasalliklarga chalingan, majburiy davolanayotgan shaxslarning huquq va majburiyatlari bo‘yicha ma’lumot bering " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Profilaktika inspektorining surunkali alkogolizm, giyohvandlik va zaharvandlikka mubtalo bo‘lgan shaxslar bilan ishlash faoliyatini tartibga soluvchi huquqiy me’yoylarni yoritib bering" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Huquqbuzarlikning yakka tartibdagi profilaktikasi obyektlarini sanab o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Oilada zo‘rlik ishlatib sodir etiladigan jinoyatlarga aniqlik kiriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Oilani qo‘llab-quvvatlash choralari bo‘yicha O‘zbekistonda o‘tkazilayotgan islohotlar xususida ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Voyaga etmaganlar tomonidan jinoyat sodir etilishiga imkoniyat yaratuvchi sabablar va omillar jumlasiga qaysilarni kiritish mumkin." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Viktimlik darajasi yuqori bo‘lgan shaxslar – kasbi, ijtimoiy maqomi, biofiziologik xususiyati, moddiy ahvoli, ma’naviy-ruhiy belgilariga ko‘ra aniqlanadi. Viktimlik darajasi yuqori bo‘lgan shaxslarga kimlar kiradi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "Huquqbuzarliklar profilaktikasi faoliyatida kamchilik va muammolar nimalardan iborat? Ularni bartaraf etish bo‘yicha fikr va mulohazalaringiz." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Voyaga yetmaganlarga ijtimoiy-huquqiy yordam ko‘rsatish markazi faoliyati nimalardan iboratligi bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Bolalar masalalari bo‘yicha milliy komissiyaning tarkibini shakllantirilishi va ish faoliyatini tashkil etilishi bo‘yicha ma’lumot bering" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Huquqbuzarliklarning sabab va sharoitlarini mazmuni bo‘yicha tasniflashda g‘oyaviy sabab va sharoitning oqibatlari xususida to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Kimlar huquqbuzarlik sodir etishga moyil shaxslar sifatida e’tirof etilishi mumkin? Ular haqida batafsil ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Oiladagi jinoyatlar va huquqbuzarliklarning sabablari va sodir etilishiga imkon bergan sharoitlar bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Oiladagi jinoyatlarning oldini olish choralari to‘g‘risida ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Shaxslarda viktimlikning uch darajasi bo‘yicha ma’lumot bering. Ular orasidagi farqlarni yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Oiladagi jinoyatchiliklarning ijtimoiy-ruhiy sabab va sharoitlari va ularning oqibatlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Ta’limni davlat tomonidan boshqarish organlarining va ta’lim muassasalarining huquqbuzarliklar profilaktikasi sohasidagi vakolatlari bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Fuqarolarning o‘zini o‘zi boshqarish organlarining huquqbuzarliklar profilaktikasidagi ishtiroki nimalardan iborat." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Huquqbuzarliklar profilaktikasining maqsadlari nimalardan iborat? " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "O‘zbekiston Respublikasining “Huquqbuzarliklar profilaktikasi to‘g‘risida”gi qonuni mazmun-mohiyatini yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "Ichki ishlar organlari qo‘riqlash xizmatlari huquqbuzarliklar profilaktikasida qanday vazifalarni amalga oshiradi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "Huquqbuzarliklar sabablari va ularni keltirib chiqaruvchi sharoitlar haqida ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Huquqbuzliklar profilaktikasida ishtirok etuvchi organlar hamda muassasalarni ayting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Ichki ishlar organlarining huquqbuzarliklar profilaktikasi bo‘yicha vazifalari nimalardan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Prokuratura organlarining huquqbuzarliklar profilaktikasi bo‘yicha vazifalari nimalardan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "Davlat xavfsizlik xizmati organlarining huquqbuzarliklar profilaktikasi bo‘yicha vazifalari nimalardan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Davlat soliq xizmati organlarining huquqbuzarliklar profilaktikasi bo‘yicha vazifalari nimalardan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "Profilaktika inspektori qaysi yo‘nalishda viktimologik profilaktikani tashkil etishi kerak?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Profilaktik hisob qaysi toifadagi shaxslarga nisbatan yuritiladi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Profilaktika inspektorining yakka tartibdagi profilaktikasi qaysi toifadagi shaxslarga nisbatan amalga oshiriladi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Profilaktika inspektorining huquqbuzarliklarning maxsus profilaktikasida sohaviy xizmatlar bilan hamkorligining ahamiyati nimadan iborat?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Profilaktika inspektori huquqbuzarliklarning umumiy profilaktikasida qanday usul va shakllardan foydalanadi?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Giyohvandlik vositalari va psixotrop moddalarning qonunga xilof muomalasi bilan bog‘liq huquqbuzarliklar ko‘payganda yoki muayyan mavsum davomida «Qoradori» operatsiyasini o‘tkazishdan maqsad nima?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Huquqbuzarliklarning maxsus profilaktikasi respublikada, mintaqada yoki shahar-tuman miqyosida yoxud alohida kichik hudud va ob`yektda ayrim turdagi huquqbuzarliklarning profilaktikasi o‘tkazilishidan maqsad nima?" });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Huquqbuzarliklarning sabab va sharoitlari mazmuni bo‘yicha tasniflanganda iqtisodiy-moddiy turga ajratiladi. Iqtisodiy-moddiy sabab va sharoitning oqibatlari xususida to‘xtalib o‘ting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Huquqiy targ‘ibotning og‘zaki shakli ijtimoiy-huquqiy munosabatlar, ularning belgilangan shartlari, tartibi, qonun va qonunosti hujjatlarning mazmun-mohiyatiga bag‘ishlab aholi o‘rtasida o‘tkaziladi. Bu qanday shakllarda amalga oshirilishi bo‘yicha ma’lumot bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Huquqiy targ‘ibot va uning og‘zaki, yozma va  ko‘rgazmali shakllari xususida tushuntirish bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Ijtimoiy reabilitatsiya qilish va ijtimoiy moslashtirish chora-tadbirlari, xususan “Mehr” 1, 2, 3, va 4 operatsiyalari haqida tushuncha bering." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Huquqbuzarliklar profilaktikasining insonparvarlik prinsipini yoriting. " });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Profilaktika inspektori faoliyatining asosiy vazifalarini yoriting." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Huquqbuzarliklar profilaktikasi bo‘linmalarining yoshlarga oid davlat siyosati sohasidagi vakolatlari." });
              this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Voyaga yetmaganlar o‘rtasida nazoratsizlik va huquqbuzarliklarning profilaktikasini amalga oshirishning asosiy usullarini ayting." });

              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 1, Question = @"Yangiyo‘l tumanida yashovchi fuqaro D.L. g‘ayriijtimoiy xulq-atvorga xos bo‘lgan barcha xislatlarni o‘zida jam qilgan, jumladan u fuqaro O.R. bilan qonuniy nikohsiz er-xotin bo‘lib, ko‘p qavatli uylarda yashab, baland ovozda musiqa ohanglarini eshitib, qo‘shnilarning tinchini buzib kelashdi. Bundan tashqari ular oilada nizoli va janjalli vaziyatlarni yuzaga keltirib, spirtli ichimlikka ruju qo‘yishgan. Ichki ishlar organlari tomonidan bir necha bora jamoat joylarida spirtli ichimlik iste’mol qilganligi uchun ogohlantirilishiga qaramay, bunday odatlarini tashlamagan. 
  G‘ayriijtimoiy xulq-atvor borasida muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 2, Question = @"Lavozimiga yangi tayinlangan profilaktika inspektori Q.V. o‘ziga biriktirilgan mahallada g‘ayriijtimoiy xulq-atvori xavfliligi tufayli kelgusida huquqbuzarlik sodir etish ehtimoli yuqori bo‘lgan, manaviy va axloqiy qadriyatlarni mensimaydigan, huquqiy negilistik kayfiyatga ega bo‘lib shaxslarni aniqlash borasida mahalla raisi bilan hamkorlikda ish boshladi.
  Profilaktika inspektori Q.V. bu toifa kishilarni aniqlashda nimalarga e’tibor qaratishi kerak? Huquqbuzarlik sodir etishga moyil bo‘lgan shaxslar toifasiga kimlar kiradi?" });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 3, Question = @"Profilaktika inspektori Q.V. huquqbuzarlikdan jabrlanuvchiga aylanishi xavfini kamaytirish maqsadida ma’naviy va jismoniy jihatdan ojizlar, ayollar, qariyalar, yosh bolalar, nogironlar bilan doimiy viktimologik profilaktika o‘tkazib keladi.
  Mazkur xavf yoki viktimlik uchta, ya’ni viktimlik past, o‘rtacha va yuqori bo‘lgan darajalarga ta’rif bering. Yuqorida sanab o‘tilgan toifa vakillari qaysi darajaga mansub." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 4, Question = @"O‘z uyida bosqinchilik jinoyatidan jabr ko‘rgan fuqaroligi bo‘lmagan shaxs G.N va uning turmush o‘rtog‘i chet el fuqarosi bo‘lgan Z.A. sud jarayonida bosqinchilardan o‘zlariga yetkazilgan zararlarini qoplanishini talab qilishdi. 
  Huquqbuzarlikdan jabrlanuvchi tushunchasiga borasida muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 5, Question = @"Maktab rahbariyati o‘quvchilarida ma’naviy va axloqiy hamda huquqiy qadriyatlarga ishonch uyg‘otish maqsadida madaniyat sohasi vakillari bilan uchrashuv tashkil etdi.
  Ishontirish usulining ustuvorligi deyilganda nima nazarda tutiladi? Ishontirish usuliga ta’rif bering." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 6, Question = @"2019- yil 14- yanvar kuni Bektemir tumani X.Bayqaro ko‘chasi 34- uyda yashovchi fuqaro Sh.B. jamoat joyida spirtli ichimlik ichgani uchun profilaktika inspektori unga nisbatan MJtKning 187- moddasi 1- qismi bilan ma’muriy bayonnoma rasmiylashtirib jarimaga tortdi hamda yakka tartibda suhbat o‘tkazib, uni profilaktik hisobga oldi. Lekin fuqaro Sh.B. spirtli ichimliklarni yashash joyida ichishni davom ettirib, o‘ziga tegishli xulosa chiqarmadi. 2019- yil 25- mart kuni fuqaro Sh.B. yana jamoat joyida spirtli ichimlik ichgani uchun profilaktika inspektori unga nisbatan MJtKning 187 -moddasi 2- qismi bilan ma’muriy bayonnoma rasmiylashtirib, ko‘rib chiqish uchun tuman mamuriy sudiga yubordi. Sud tomonidan fuqaro Sh.B.ga nisbatan 10 sutka ma’muriy qamoq jazosi tayinlandi. 
  Ushbu holatda profilaktika inspektori yana qanday harakatni  amalga oshirishi kerak edi?" });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 7, Question = @"Profilaktika inspektori E.D. xizmati davomida yosh bo‘lishiga qaramay huquqbuzarlik va boshqa g‘ayriijtimoiy xatti-harakatlar sodir etgan V.I.ning o‘tmishini o‘rganar uning anchadan beri nazoratsizligi hamda qarovsizligi ekanligi, hayoti yoki sog‘lig‘i uchun xavf tug‘diradigan vaziyatga (sharoitga) tushib qolganligini aniqladi. Profilaktika inspektori E.D. voyaga yetmagan shaxs V.I.ning ijtimoiy ahvolini tuzatish bo‘yicha vakolatli organlar bilan ishlashni boshladi.
  Ijtimoiy jihatdan xavfli ahvolda bo‘lgan voyaga yetmagan shaxs deyilganda nimalar tushuniladi?" });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 8, Question = @"Chirchiq shahrida yashovchi, turmush o‘rtog‘i vafot etgan, spirtli ichimlik ichishga ruju qo‘ygan fuqaro J.K. tomonidan o‘z voyaga yetmagan farzandlari V.K va F.K moddiy ta’minlash, tarbiyalash va ularga ta’lim berish bo‘yicha o‘z majburiyatlarini bajarishdan bo‘yin tovlab kelmoqda. Vakolatli davlat organlari tomonidan bir necha bora ogohlantirilishiga qaramay J.K. o‘z majburiyatlarini bajarmasdan kelmoqda.
  Ijtimoiy jihatdan xavfli ahvolda bo‘lgan oila deyilganda nimalar tushuniladi. J.K.ga nisbatan qanday choralar ko‘rilishi mumkin." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 9, Question = @"T ismli fuqaroning jazoni ijro etish muassasidan chiqqaniga 1 hafta bo‘ldi. U diniy-ekstremistik oqimga a’zoligi isbotlanib, sud tomonidan aybli deb topilgan edi. Odatdagidek, bunday fuqarolar profilaktika inspektorining profilaktik hisobida turadi va inspektor doimiy ravishda bunday fuqorolarni nazorat qilib borishi zarur. T ismli fuqaroni uyiga inspektor tashrif buyurdi va o‘zini tanishtirdi. T ismli fuqoro bilan suhbat jarayonida inspektor tushunib yetdiki, fuqaro bilan ishlash judayam qiyin, u hali ham “tushunib etmagan”, diniy oqimga moyilligi yuqori.
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Fuqaro T. ga nisbatan qanday profilaktika turini o‘tkazish maqsadaga muvofiq?" });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 10, Question = @"Har kuni informatsion internet saytlarida yoshlar o‘rtasidagi jinoyatlar, pichoqbozlik, avtomobillarni o‘g‘irlash, bosqinchilik kabi xabarlarni ko‘rib kelyapmiz, bu yoshlarimizning ongiga salbiy ta’sir ko‘rsatishi turgan gap”, dedi “Birlik” MFY raisi. Yig‘ilishda ishtirok etganlarning barchasi “Birlik” MFY raisining fikrini qo‘llab-quvvatlashdi.
  Yuqoridagi holat huquqbuzarliklar sodir etilishining qanday sababiga kiradi? Internet saytlaridagi xabarlar yoshlar psixologiyasiga qanday ta’sir etishi mumkin?" });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 11, Question = @"O‘smir 17 yoshda. Sport bilan shug‘ullanadi. Ota-onasi otasining mas’uliyatsizligi va aroqxo‘rligi sababli doimo janjallashib turishadi, u ko‘pincha do‘stlarinikida yoki ko‘chada tunaydi. Ba’zan u uyga kelishni ham istamaydi. Yaqinda u ekstremistik oqim a’zosi bo‘lgan fuqaro R. bilan uchrashdi. Ularning faoliyati bilan qiziqa boshladi va tengdoshlaridan ba’zilarini ham ushbu faoliyatga unday boshladi.
  Ekstremistik oqimlar a’zolari o‘rtasidagi g‘oyalarning o‘smir ongiga ta’sirini tahlil qiling va keltirib chiqishi mumkin bo‘lgan oqibatlar borasida o‘z fikrlaringiz bayon eting." });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 12, Question = @"Oilada ayol ishlaydi, turmush o‘rtog‘i vaqtincha ishsiz. Ikki nafar farzandning kattasi 16, kichigi 13 yoshda, ikkalasi ham maktab o‘quvchisi. Yetishmovchilik tufayli oilada har kuni janjal. 
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Mazkur oiladagi moddiy yetishmovchilik mazmun mohiyatiga ko‘ra sababning qanday turiga kiradi?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 13, Question = @"G.ning zo‘r telefoni bor. Internetga kiradi, selfi uchun kamerasi bor, musiqa ham eshitadi, video ham ko‘rsa bo‘ladi. Shu telefon ortidan G.ning axloqida salbiy xususiyatlar paydo bo‘la boshladi. Buni maktab, mahalla, ota-ona, qo‘ni-qo‘shnilar, qarindoshlar ham sezishdi. Endi G.ga hamma qarshi, hammani unga “sen yomonsan” deb tanbeh bermoqda. Holatni qarang: birgina G.ga maktab, mahalla, ota-ona, qo‘shnilar, qarindoshlar tarbiya berishga, to‘g‘ri yo‘lga qaytishiga harakat qilmoqda. G. esa borgan sari yomonlashib bormoqda…
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. 
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 14, Question = @"Navoiyda 21 mart kuni Navoiyda 31 yoshli ayol 3 nafar qizi bilan birgalikda poezd ostiga o‘zini tashlagan edi. Bolalar yashab qoldi, ammo ona olamdan o‘tdi. Z.J.ning yaqin qarindoshlari bilan suhbatlashilganda, oilaviy sharoiti moddiy jihatdan o‘rtaholligi, biroq turmush o‘rtog‘i bilan munosabatlarida muammo bo‘lgani aniqlangan. U ruhiy jihatdan sog‘lom bo‘lgan. «So‘nggi vaqtlarda u bilan turmush o‘rtog‘i O.Ro‘ziev “Sen o‘g‘il farzand tug‘maysan“ deb janjallashib turgani sababli, uning ruhiyatida o‘zgarishlar bo‘lgan, lekin qolgan oila a’zolari yoki boshqa shaxslar bilan kelishmovchilikka bormagan», — deyiladi xabarda.
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Ayol kishining o‘zini o‘ldirishiga sabab mazmun mohiyatiga ko‘ra qanday turga kiradi? Hodisaga huquqiy baho bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 15, Question = @"Huquqbuzarliklarning profilaktikasi bo‘linmalaridan hamda voyaga yetmaganlarga ijtimoiy-huquqiy yordam ko‘rsatish markazlaridan iborat maxsus bo‘linmasi zimmasiga “Mehr-4” operatsiyasi orqali Afg‘onistondan “Katta Beltepa” mahallasiga qaytarilgan oilani ijtimoiy jihatdan xavfli ahvolga tushib qolmasligi hamda oila farzandalarini g‘ayriijtimoiy xatti-harakatlar sodir etmasligi choralarini ko‘rish vazifasi qo‘yilgan.
  Ijtimoiy reabilitatsiya va ijtimoiy moslashtirish sohasida IIOning huquqbuzarliklar profilaktikasi sohasi sub’ekti sifatidagi o‘rni va roli haqida tushuntirish bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 16, Question = @"Ichki ishlar vaziri P.R.Bobojonovning 2021 yil 12 martdagi Oliy majlis Senatiga bergan hisobotida oilalarda sodir etilgan jinoyatlar sanab o‘tildi, jumladan 143 ta qotillik, 192 ta og‘ir tan jarohati yetkazish, 18 ta nomusga tegish , 32 ta bezorilik va 14379 ta ma’uriy huquqbuzarliklar aniqlangan.
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Oilalarda sodir etiladigan huquqbuzarliklar sabablari va sharoitlariga aniqlik kiriting. 
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 17, Question = @"Tuman xokimligi kam ta’minlangan oilalar farzandlari, yetim bolalar, ota-onasining qaramog‘idan mahrum bo‘lgan bolalarni moddiy va ma’naviy jihatdan qo‘llab quvvatlash bo‘yicha keng ko‘lamli ish boshlab turgan bir paytda, to‘satdan texnogen xususiyatli favqulodda vaziyat sodir bo‘ldi. Bu turdagi muammoga duch kelmagan tuman hokimligidagilar ishni nimadan boshlashini bilmay hayron.
  Mahalliy davlat hokimiyati organlarining profilkatika sohasidagi vakolatlari va majburiyatlariga aniqlik kiriting.
  " });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 18, Question = @"G‘ayriijtimoiy hatti-harakati uchun profilaktika inspektori va mahalla raisi tomonidan bir necha bora ogohlantirilgan fuqaro Sh.Q. yana o‘zining “xurmacha qiliq”larini boshladi. Bu safar u spirtli ichimlik ta’sirida ko‘p qavatli uy hovlisida hammani ommaviy so‘kib chiqish bilan kifoyalandi. 
  Fuqaro Sh.K. ga nisbatan qanday usulda chora qo‘llash mumkin? Huquqbuzarliklarning umumiy tartibdagi profilaktikasining usullariga ta’rif bering.
  " });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 19, Question = @"Toshkent shahar Chilonzor tuman 18 daha yashovchi fuqarolar kechki payt “Tungi kapalaklar” bozori ularning dam olishiga va oiladagi farzandlarining tarbiyasiga salbiy ta’sir qilayotganligidan nolib tuman IIBga murojaat qildi. IIO ushbu hududda “Oriyat” tadbirini o‘tkazishga qaror qildi.
  Mazkur tadbirlar huquqbuzarliklar profilaktikasinig qaysi turiga mansub, bu haqida batafsil ma’lumot bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 20, Question = @"O‘zbekiston Respublikasining 2008 yil 5 yanvar kuni qabul qilingan «Bola huquqlarining kafolatlari to‘g‘risida»gi qonunning «Asosiy tushunchalar» deb nomlangan 3-moddasida «ijtimoiy himoyaga muhtoj bolalar»ga — yuzaga kelgan holatlar sababli og‘ir turmush sharoitida qolgan, davlat va jamiyat tomonidan alohida himoya qilishga hamda qo‘llab-quvvatlashga muhtoj bo‘lgan bolalar deb ta’rif berilgan. 
  Muammoli masalani muhokama qiling, yechimi yuzasidan batafsil tushunchangizni bayon qiling. Ushbu toifadagi bolalar, ya’ni «ijtimoiy himoyaga muhtoj bolalar» kimlar?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 21, Question = @"Voyaga yetmaganni ijtimoiy-huquqiy yordam ko‘rsatish markaziga joylashtirish bo‘yicha materiallarni tayyorlash ichki ishlar organlarining zimmasiga yuklatilganligini bilan qo‘shnilar voyaga yetmagan qarovsiz R.V.ni ijtimoiy-huquqiy yordam ko‘rsatish markazlariga quyidagi voyaga yetmaganlarning joylashtirilishi so‘rab murojaat qilishdi. Bundan xabar topgan R.V.ning yaqinlari qo‘shnilardan birovning ishiga aralashmasliklarini aytib janjallashishdi.
  Ijtimoiy-huquqiy yordam ko‘rsatish markaziga joylashtirish uchun nimalar asos bo‘ladi? Ijtimoiy-huquqiy yordam ko‘rsatish markazlari bo‘yicha ma’lumot bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 22, Question = @"«Axborot-kommunikatsiya texnologiyalari sohasidagi loyihalarni boshqarish tizimini yanada takomillashtirish chora-tadbirlari to‘g‘risida» Hukumat qaror qilgan. Ushbu qarorga muvofiq, «Xavfsiz shahar» apparat-dasturiy kompleksini yaratish maqsadida yagona texnologik yondashuvni ishlab chiqish va amalga oshirishning quyidagi bosqichlari belgilangan: 
  - yo‘l harakati qoidalarining buzilishlarini maxsus avtomatlashtirilgan texnik foto va videofiksatsiya vositalari yordamida qayd qilish tizimini yaratish;
  - yagona navbatchilik xizmatini ishga tushirish.
  1-savol. «Xavfsiz shahar» apparat-dasturiy kompleksini yaratishga mo‘ljallangan yagona texnologik yondashuv doirasida «Aqlli shahar» texnologiyalarini joriy etish nimalardan iborat bo‘lishi mumkin?
  2-savol. Yo‘l harakati qoidalarining buzilishlarini maxsus avtomatlashtirilgan texnik foto va videofiksatsiya vositalari yordamida qayd qilish tizimiga qanday texnologik yechimlar kiradi?
  3-savol. Ichki ishlar organlarida yagona navbatchilik xizmati qanday ishlaydi? 
  " });
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 23, Question = @"Huquqbuzarliklar profilaktikasini tasniflashda turli mualliflar har xil mezonlarga, kimdir – subyektning o‘ziga xos xususiyatlariga, kimdir – profilaktikani amalga oshirish usullarining o‘ziga xos xususiyatlariga, kimdir – profilaktika chora-tadbirlarini huquq normalari bilan tartibga solishga, yana kimdir (ular ko‘pchilikni tashkil etadi) – profilaktika chora-tadbirlarining xususiyatiga asoslanadi. 
  Shunga ko‘ra, viktimologiya tushunchasini ta’riflang va javobingizni O‘zbekiston Respublikasi qonunchiligi asosida tahlil qilib yoritib bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 24, Question = @"G‘ayriijtimoiy hatti-harakati uchun profilaktika inspektori va mahalla raisi tomonidan bir necha bora ogohlantirilgan fuqaro T yana o‘zining “xurmacha qiliq”larini boshladi. Bu safar u spirtli ichimlik ta’sirida ko‘p qavatli uy hovlisida hammani ommaviy so‘kib chiqish bilan kifoyalandi. 
  Fuqaro T ga nisbatan qanday usulda chora qo‘llash mumkin? Huquqbuzarliklarning umumiy tartibdagi profilaktikasining usullariga ta’rif bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 25, Question = @"Oilada ayol ishlaydi, turmush o‘rtog‘i vaqtincha ishsiz. Uch nafar farzandning kattasi 17, kichigi 12 yoshda, ikkalasi ham maktab o‘quvchisi. Etishmovchilik tufayli oilada har kuni janjal. 
  Muammoli masalani muhokama qiling, echimi yuzasidan batafsil tushunchangizni bayon qiling. Mazkur oiladagi moddiy etishmovchilik mazmun mohiyatiga ko‘ra sababning qanday turiga kiradi?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 26, Question = @"Kitob tumanida yashovchi fuqaro N. g‘ayriijtimoiy xulq-atvorga xos bo‘lgan barcha xislatlarni o‘zida jam qilgan, jumladan u fuqaro A. bilan qonuniy nikohsiz er-xotin bo‘lib, ko‘p qavatli uylarda yashab, baland ovozda musiqa eshitib, qo‘shnilarning tinchini buzib kelashdi. Shuningdek, ular oilada nizoli va janjalli vaziyatlarni yuzaga keltirib, spirtli ichimlikka ruju qo‘yishgan. Ichki ishlar organlari tomonidan bir necha bora jamoat joylarida spirtli ichimlik iste’mol qilganligi uchun ogohlantirilishiga qaramay, bunday odatlarini tashlamagan. 
  G‘ayriijtimoiy xulq-atvor borasida muammoli masalani muhokama qiling, echimi yuzasidan batafsil tushunchangizni bayon qiling.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 27, Question = @"K ismli fuqaroning qamoqdan chiqqaniga 2 hafta bo‘ldi. 
  U ekstremistik oqimga a’zoligi isbotlanib, sud tomonidan aybli deb topilgan edi. Odatdagidek, bunday fuqarolar profilaktika inspektorining profilaktik hisobida turadi va inspektor doimiy ravishda bunday fuqorolarni nazorat qilib borishi zarur. K ismli fuqaroni uyiga inspektor tashrif buyurdi va o‘zini tanishtirdi. K ismli fuqoro bilan suhbat jarayonida inspektor tushunib etdiki, fuqaro bilan ishlash judayam qiyin, u hali ham “tushunib yetmagan”, ekstremistik oqimga moyilligi yuqori.
  Muammoli masalani muhokama qiling, echimi yuzasidan batafsil tushunchangizni bayon qiling. Fuqaro K. ga nisbatan qanday profilaktika turini o‘tkazish maqsadaga muvofiq? 
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 28, Question = @"Urgut tuman hokimligi kam ta’minlangan oilalar farzandlari, etim bolalar, ota-onasining qaramog‘idan mahrum bo‘lgan bolalarni moddiy va ma’naviy jihatdan qo‘llab quvvatlash bo‘yicha keng ko‘lamli ish boshlab turgan bir paytda, to‘satdan 2021-yil oktabr oyida texnogen xususiyatli favqulodda vaziyat, ya’ni Urgut tumanida tog‘dan tosh tushishi sodir bo‘ldi. Bu turdagi muammoga duch kelmagan tuman hokimligidagilar ishni nimadan boshlashini bilmay hayron. 
  Mahalliy davlat hokimiyati organlarining profilkatika sohasidagi vakolatlari va majburiyatlariga aniqlik kiriting.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 29, Question = @"Profilaktika inspektori D huquqbuzarlikdan jabrlanuvchiga aylanishi xavfini kamaytirish maqsadida ma’naviy va jismoniy jihatdan ojizlar, ayollar, qariyalar, yosh bolalar, nogironlar bilan doimiy viktimologik profilaktika o‘tkazib keladi.
  Mazkur xavf yoki viktimlik uchta, ya’ni viktimlik past, o‘rtacha va yuqori bo‘lgan darajalarga ta’rif bering. Yuqorida sanab o‘tilgan toifa vakillari qaysi darajaga mansub.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 30, Question = @"Huquqbuzarliklarning profilaktikasi bo‘linmalaridan hamda voyaga etmaganlarga ijtimoiy-huquqiy yordam ko‘rsatish markazlaridan iborat maxsus bo‘linmasi zimmasiga “Mehr-4” operasiyasi orqali Suriyadan “Xirmontepa” mahallasiga qaytarilgan oilani ijtimoiy jihatdan xavfli ahvolga tushib qolmasligi hamda oila farzandalarini g‘ayriijtimoiy xatti-harakatlar sodir etmasligi choralarini ko‘rish vazifasi qo‘yilgan.
  Ijtimoiy reabilitasiya va ijtimoiy moslashtirish sohasida IIOning huquqbuzarliklar profilaktikasi sohasi subyekti sifatidagi o‘rni va roli haqida tushuntirish bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 31, Question = @"Toshkent shahrida “Do‘stlik” MFYda istiqomat qiluvchi bir guruh fuqarolar mahalla hududidan o‘tgan “Bog‘” ko‘chasining 1 va 25 xonadonigicha bo‘lgan hududini to‘sib, MFYda joylashgan  xonadonlarning qish mavsumi kelganligiga qaramasdan  isitish tizimi ishga tushmaganidan norozi bo‘lib ko‘cha harakatlarini amalga oshirishdi.
  Mazkur vaziyatda vakolatli organlar tomonidan jamoat xavfsizligi va tartibini saqlash qanday tartibda amalga oshiriladi? 
  Shuningdek mazkur holatda ko‘cha harakatlarini amalga oshirgan MFY fuqarolarining harakatlari  yuzasidan o‘z fikringizni bildiring.
  Yig‘ilishlar, mitinglar, ko‘cha yurishlari va namoyishlar o‘tkazish tartibbuzarlariga nisbatan qaysi ma’muriy-huquqiy ta’sir choralari qo‘llanishi mumkin?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 32, Question = @"Jinoyat sodir qilishda gumon qilinayotgan ayblanuvchi  B.Shayvalieva vaqtincha saqlash  hibsxonasiga tungi soat 02:00da olib kelinadi. V.S.H xodimlari tomonidan B.Shayvalievadan V.S.Hga joylashtirilishiga nisbatan shikoyat va iltimosnomalari bor yo‘qligi shuningdek sog‘ligi holati haqida so‘ralganda, shikoyat va iltimosnomalari yo‘qligi hamda sog‘ligi yaxshiligi aytib o‘tdi. 
  Shaxsiy tintuv V.S.H xodimi A.Shodmonov tomonidan bir nechta holislar ishtirokida o‘tkazilib ayblanuvchi yonidagi bir dona oshxona pichog‘i, gugurt hamda bir pochka sigaret olinib uning barmoq izlaridan ko‘chirmalar olinib, boshqa bir homilador ayblanuvchi bilan bitta kameraga joylashtirildi.
  Vaziyatga huquqiy baho bering. Ayblanuvchi yoki gumonlanuvchini vaqtincha saqlash hibsxonalariga joylashtirish tartibi, ushlab turish asoslari, shaxsiy tintuv, saqlash rejimi va boshqa jihatlarini yoritib bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 33, Question = @"“Smart” universitetining bir guruh talablari o‘zlarining stipendiyasini ko‘tarish masalasini o‘zaro guruh a’zolari ishtirokida muhokama qilishdi. Talabalar muhokama jarayonida olingan videolavhani “Instagram” ijtimoiy tarmog‘ida #stipendiyanibirgalikdako‘taramiz xeshtegi  orqali joylashtirishdi. Mazkur xeshteg talabalar o‘rtasida ommalashib natijada Bunyodkor stadioniga 1500 nafarga yaqin talabalar yig‘ilishib o‘zlarining oylik stependiyalarini ko‘tarish bo‘yicha namoyish o‘tkazishishdi.
  Ichki ishlar  organlari xodimlari tomonidan talabalarga masalani bunday yo‘l bilan hal qilib bo‘lmasligi tushuntirilib darhol hamma talaba tarqalishi zarurligi ta’kidlandi. IIO xodimlarining tushuntirilari bo‘yicha talabalar tomonidan namoyishni to‘xtatish hamda tarqalish yuzasidan amaliy harakatlar bajarilmaganidan keyin, talabalar to‘plangan joyga tezkor guruh, patrul post naryadlari chaqirtilib talabalar namoyishi majburiy tartibda tarqatildi.
  Ommaviy tadbirlarni tashkil etish tartibi hamda ushbu jarayonda ichki ishlar organlari xodimlari tomonidan jamoat tartibi va xavfsizligini ta’minlash faoliyati hamda ruxsat etilmagan ommaviy tadbirlar tashkil etilganda ichki ishlar organlari tomonidan qanday chora-tadbirlar amalga oshiririlishi yuzasidan batafsil tushuntirish bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 34, Question = @"Mirobod tumanida joylashgan  “Tong” restoraniga kechki soat 21:00da  Patrul xizmati xodimlari kelib, bayram arafasida jamoat tartibini saqlash va yong‘in xavfsizligini ta’minlash hamda favqulodda vaziyatlarni bartaraf etish bo‘yicha turli muassasalar xodimlari tegishli tashkiliy-profilaktik ishlarni amalga oshirayotganini ta’kidlab  restoranni ish faoliyatini ertaroq yakunlash talabini qo‘yishdi. Restoran rahbariyati tomonidan hali ish vaqti tugamaganligi vaj qilinib ish vaqti tungi soat 01:00 gacha ekanligi, belgilangan vaqtda o‘zlari restoranni yopishlarini ta’kidlashdi.
  Patrul-post xizmati xodimlarini jamoat tartibi va xavfsizligini ta’minlash faoliyatini batafsil yoriting.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 35, Question = @"	Yakkasaroy tumani “Mustaqillik” ko‘chasida o‘z xizmat vazifalarini o‘tayotgan PPX va milliy gvardiya xodimlari tomonidan, shu yaqin o‘rtada joylashgan kollej talabalari to‘xtatilib karantin talablariga rioya etmayotganligi ya’ni maskasiz yurganliklari uchun ogohlantirishdi. Talabalar esa PPX xodimlari va Miiliy gvardiya xodimlarida fuarolarning karantin talablariga rioya etishlarini talab qilishga haqli emasliklari takidlashdi.
  Ichki ishlar organlari hamda Milliy gvardiya xodimlarining huquq va majburiyatlari, shuningdek, ularning jamoat xavfsizligini ta’minlash borasidagi vazifa va funksiyalarini tahlil qiling. 
  Ommaviy tadbirlar o‘tkazilishi mobaynida xavfsizlikni va jamoat tartibini saqlash uchun xizmatga jalb etilgan ichki ishlar naryadlari turlarini yoriting. Mazkur jarayonni yoritishda xorijiy tajribadan foydalaning.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 36, Question = @"Mustaqillik bayrami arafasida jamoat tartibi va xavfsizligini ta’minlashga qaratilgan turli muassasalar xodimlaridan iborat tegishli tashkiliy-profilaktik ishlar doirasida, 2021-yil 29-avgust sanasida Toshkent shahridagi “Nukus” va “Oybek” ko‘chalari kesishmasida kechki soat 22:00da Lasetti rusumli avtotransport vositasi to‘xtatilib, xaydovchidan avtotransport vositasini boshqarish huquqini beruvchi xujjatlarni taqdim etish so‘ralganda avtomobil xaydovchisi va uning  yonidagi ikki nafar fuqarolar tomonidan xujjatlarni taqdim etish o‘rniga, ichki ishlar organlari xodimlariga nisbatan faol qarshilik xarakatlari sodir etilgan.  Tuman ma’muriy sudi qarori bilan Avtotransport vositasi xaydovchisi hamda ikki nafar fuqaroga nisbatan 10 sutkalik ma’muriy qamoq jazosi tayinlangan.
  Ma’muriy qamoqqa olingan shaxslarni qabul qilish va saqlash tartibini tushuntirib bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 37, Question = @"“Gulzor” MFY profilaktika inspektoriga MFY hududida joylashgan “Sher” kafesi yonida noma’lum shaxs yerga yuztuban holatda yotgani to‘g‘risida xabar berildi. Kafe yonida yotgan fuqaroni shaxsini aniqlashtirish imkoni bo‘lmaganidan keyin, Reabilitatsiya markaziga olib borib topshirildi.
  Muayyan yashash joyiga ega bo‘lmagan fuqarolarni reabilitatsiya qilish tartibini tushuntirib bering. Shuningdek, mazkur masalani yoritishda xorijiy tajribadan foydalaning.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 38, Question = @"Ichki ishlar vazirligi ishonch telefoni orqali joriy yilning 15 noyabrida Toshkent shahri markazida joylashgan “Turkiston” san’at saroyida bir guruh shaxslar tomonidan qo‘poruvchilik harakati sodir etilishi to‘g‘risidagi ma’lumotlar aks ettirilgan anonim xabar kelib tushdi. 
  Mazkur vaziyatda Ichki ishlar organlari tomonidan qanday chora-tadbirlar amalga oshiriladi.
  Favqulotda vaziyatlarda ichki ishlar organlari tomonidan jamoat tartibi va xavfsizligini ta’minlash faoliyatini amaliy misollar orqali yoriting.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 39, Question = @"JK 97-moddasida nazarda tutilgan jinoyatni sodir etilishda ayblanayotgan fuqaro S.Baxromov vaqtincha saqlash hibsxonasidan sud majlisiga olib borilayotganda, avtotransportdan qochishga urinadi, konvoy xizmati xodimlarining ogohlantirishiga qaramasdan harakatlanishda davom etadi. Konvoy xizmati xodimi serjant G.Nurmonov ayblanuvchigi qarata bir marotaba o‘q uzadi. O‘q ayblanuvchining o‘ng ko‘krak sohasiga tegadi va ayblanuvchi olgan tan jaroxati natijasida voqea joyida vafot etadi.
  Vaziyatga huquqiy baho bering.
  Ichki ishlar organlari tomonidan konvoy xizmatini tashkil etish faoliyatini batafsil tushuntiring.
  v" }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 40, Question = @"Toshkent davlat yuridik universiteti “Xalqaro xususiy huquq” kafedrasi  o‘qituvchisi M.Turdaliev  “Xalqaro xususiy huquqda Gaaga konferensiyasining o‘rni” mavzusidagi xalqaro ilmiy amaliy konferensiya o‘tkazishni rejalashtirdi. Mazkur konferensiyaga bir nechta xorijiy davlatdan mexmonlar shuningdek  Gaaga konferensiyasi Bosh kotibi Kristof Bernaskoni taklif etildi konferensiya o‘tkazilish joyi sifatida Toshkent shahri markazidagi Mustaqillik maydoni tanlanib tegishli ruxsat olish uchun Toshkent shahar hokimiyatiga ariza bilan murojaat qilindi hamda tashkilotchi tomonidan tadbirga qatnashish uchun chiqarilgan taklifnomalar   ishtirokchilarga tarqatildi.
  Vaziyatga huquqiy baho bering;
  Yuqoridagi vaziyatdan kelib chiqib ommaviy tadbirlarni tashkillashtirish uchun tegishli ruxsatnoma olish tartibini tushuntiring.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 41, Question = @"	Chirchiq shahar IIOFMB huzuridagi Tergov bo‘limi tomonidan A.Temur  ko‘chasida joylashgan hiyobon qarshisida bir guruh shaxslar tomonidan ommaviy tadbir tashkillashtirilib, aholining turli ijtimoiy qatlamidan iborat jami 156 nafar fuqaro ushbu tadbirga jalb etilganligi aniqlangan. Ushbu ommaviy tadbirda shaxsi noma’lum fuqarolar o‘zlarining kayfiyatlarini amaldagi siyosiy vaziyatga qarshi yunaltirib, konstitutsiyaviy tuzumga qarshiliklarini ochiq oydin bayon qilishdi.
  Vaziyatga huquqiy baho bering;
  Ommaviy tadbirlarni o‘tkazish tartibi hamda shartlarini batafsil bayon qiling;
  Bu turdagi tadbirlarni ommaviy tadbir deb hisoblash mumkinmi?
  Mazkur vaziyatda jamoat tartibi va xavfsizligini ta’minlash maqsadida ichki ishlar organlari hamda boshqa hamkor tashkilotlar tomonidan qanday chora-tadbirlar amalga oshirilishini amaliy misollar yordamida tushuntiring.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 42, Question = @"Tungi soat 23:45da “Bo‘ston” MFY hududida “Jazira”  kafesi oldida to‘rt nafar tashqi ko‘rinishidan yoshi 15-16 yoshlar orasidagi qizlar hamda ikki nafar yigit tomonidan baland ovozda qo‘shiq qo‘yib raqsga tushayotganligi o‘sha xududda yashovchi fuqarolorning g‘ashini keltiradi. Fuqarolar A.Sanaev va B.Xamraevlarning tanbexiga javoban ular do‘stini tug‘ilgan kunini nishonlashayotganligini aytib o‘yin-kulguni davom ettirishdi. Natijada fuqarolar 102 qisqa raqami orqali vaziyat to‘g‘risida ichki ishlar organlariga xabar berishdi.
  Vaziyatga huquqiy baho bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 43, Question = @"Universitet tomonidan “Jamoat tartibi va xavfsizligini ta’minlash shuningdek huquqbuzarliklar profilaktikasida davlat idoralarining ishtiroki” mavzusidagi davra suhbati tashkillashtirilib keng jamoatchilik, OAV vakillari hamda soha mutaxassislari taklif etildi. Davra suhbatida professor Ketmonov Jamoat tartibi hamda huquqbuzarliklar profilaktikasi faqatgina ichki ishlar organlarining asosiy vazifalari ekanligini aytdi. Boshqa bir amaliyotchi mutaxassis Shodmonov  esa mazkur vazifalar ichki ishlar organlari hamda Milliy gvardiyaning birgalikdagi vazifasi ekanligini takidladi. Yuridik fanlar doktori Vaxobov esa jamoat tartibi va xavfsizligini ta’minlash faoliyati Ichki ishlar organlari, Milliy gvardiya  hamda boshqa HMQO organlarining asosiy vazifalari ekanligini aytadi.
  Yuqoridagi vaziyatdagi har bir davra suhbati qatnashchilari tomonidan aytilgan fiklarga o‘z munosabatingizni hamda alohida shaxsiy pozitsiyangizni bildiring.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 44, Question = @"Yunusobod tuman “Mustaqillik” MFY hududida o‘z xizmat vazifasini patrullik naryadi shaklida olib borayotgan  Yunusobod tumani Milliy gvardiya bo‘limi xodimi katta leytenanti S.Mamatov, kichik serjant M.Toirov hamda safdor G.Tojievlarni bir guruh fuqarolar to‘xtatib, ularning ust boshlari kirligi kiyimlarini rangi o‘chib ketganligi hamda ximoya niqobini taqmaganligi uchun koyishdi. Bu gapdan jahli chiqqan Milliy gvardiya xodimlari ushbu fuqarolarni  majburlab xizmat mashinasiga tiqib Milliy gvardiya binosiga olib borishdi.
  Vaziyatga huquqiy baho bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 45, Question = @"	Buxoro viloyati Jondor tumani  fuqarolari tomonidan Navruz saylgohida tabiiy gaz tanqisligi bo‘yicha tegishli ruxsat olinib miting tashkillashtirildi. Miting ishtirokchilaridan biri  fuqaro T.Samadov o‘zining “Kichkintoy Boggi” laqabli iti bilan sayilgoh hududiga kirmoqchi bo‘ldi. Ichki ishlar organlari xodimlari tomonidan sayilgoh hududiga jonivorlar bilan kirish mumkin emasligi aytadi. Fuqaro T.Samadov IIO xodimlariga e’tiroz bildirib  ruxsatnoma reeytrining elektron variantida xayvonlar bilan ommaviy tadbirga kirish mumkin ekanligi qayd etilganligini takidlaydi. IIO xodimlari miting tashkilotchisini chaqirib kelishadi. Tadbir tashkilotchisi ruxsatnoma reeystirining qog‘oz variantini ko‘rsatib unda tadbirga xayvonlar bilan kirish taqiqlanganligini aytadi. Natijada ikki o‘rtada tushunmovchilik yuzaga keladi. 
  Vaziyatga huquqiy baho bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 46, Question = @"Milliy gvardiya xodimi L.Tojievni o‘zining to‘g‘ridan to‘g‘ri rahbari hisoblangan polkovnik I.Asadov xonasiga chaqirib qo‘liga pul tutqazdi hamda do‘konga borib to‘rt kilogram go‘sht hamda ichimliklar sotib olib uyiga olib borib berishini shuningdek uyiga tashrif buyurishi kerak bo‘lgan  mexmonlarni keldi ketdisiga qarab turishini buyurdi. Mazkur topshiriqdan jahli chiqqan L.Tojiev labini tishlagancha rahbari aytgan topshiriqni bajarishga kirishib ketdi.
  Mazkur holatda siz o‘zingiz Milliy gvardiya xodimi L.Tojievni o‘rnida bo‘lganingizda qanday harakatlarni amalga oshirgan bo‘lar edingiz?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 47, Question = @"Yashnobod tumani IIOFMB huzuridagi tergov bo‘limi tergovchisi katta leytenant S.Aliyev “Instagram” ijtimoiy tarmog‘i orqali jonli efir qiladi. Efir vaqtida bir nechta kuzatuvchilar tomonidan Aliyevning shaxsiyatiga tegadigan gaplar aytiladi. Aliyev ko‘zatuvchilarga turli xildagi haqoratomuz so‘zlar bilan javob qaytaradi. Kuzatuvchilar ushbu jonli efirdan Aliyev tomonidan aytilgan haqoratlarni mavjud lavhani ijtioiy tarmoqlar orqali tarqatadi. Shuningdek, yana bitta nusxani Yashnobod tumani IIOFMBga taqdim etadi.
  Vaziyatga nisbatan o‘z shaxsiy munosabatingizni tegishli normativ xujjatlardan foydalangan holda  bildiring.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 48, Question = @"Milliy gvardiyaning to‘rt nafar xodimi o‘z naryad joyini tashlab kafeda alkogol mahsulotini iste’mol qilayotgani xizmat o‘tash joyidagi o‘z xavfsizligi bo‘linmasi xodimlari tomonidan aniqlanib ularning hammasiga egallab turgan lavozimidan ozod etish to‘g‘risida intizomiy jazo chorasi bitta buyruq bilan rasmiylashtiriladi. Ikki nafar milliy gvardiya xodimi alkogol iste’mol qilmaganini aytib intizomiy jazo chorasi qo‘llash haqidagi buyruqdan norozi bo‘lib prokuraturaga shikoyat qiladi.
  Vaziyatga huquqiy baho bering.
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 49, Question = @"Toshkent viloyati Olmaliq shahridagi Olmaliq kon metallurgiya kombinati ishchilari sentabr oyi uchun va`da qilingan qo‘shimcha pul mukofotlarini olishmadi. Shuning uchun zavodning to‘qson nafar atrofidagi ishchilari 3-sentabrda OKMK boshqarmasi oldidagi mashina yo‘lini to‘sib, tirbandlik hosil qilishdi.
  Vaziyatga huquqiy baho bering;
  Ishchilarning ko‘cha harakatlari asosli yoki asossiz ekanligini muhokama qiling.
  Mas’ul idoralar tomonidan ko‘cha harakatlari sodir etilganda qanday chora-tadbilar amalga oshiriladi?
  " }); 
              this.Logical_Cases_1.Add(new Quiz_Item() { Id = 50, Question = @"2021-yil 7-may kuni Toshkent shahar Yunusobod tumani 42-sonli umumiy o‘rta ta’lim maktabida 9-may “Xotira va qadrlash kuni” ga atab tuman maktablari órtasida sport musobaqalari ótkazildi. Sport musobaqalariga tuman maktab o‘quvchilari hamda sport o‘qituvchilari tashrif buyurishdi. Tadbirni o‘tkazish jarayonida 7-sonli umumiy o‘rta ta’lim maktabi 11-sinf o‘quvchilari A.D, D.T, U.I, ismli shaxslar 23-sonli umumiy o‘rta ta’lim maktab 9-sinf o‘quvchilari S.A va F.A ismli shaxslar bilan asosiz ravishda ularning yoniga borib tazyiq o‘tkazmoqchi bo‘lishadi. Bu holatni ko‘rgan 23-sonli maktab 9-,10-sinf o‘quvchilari kelib A.D, D.T, U.I bilan janjallashib ketishadi. Natijada ommaviy mushtlashishga sodir bo‘ladi. Bu holatni ko‘rib mushtlashishni to‘xtatishga kelgan  A.R ismli shaxmat treniri jarohat oladi. Maktab direktori tuman ichki ishlar bólimiga xabar beradi.
  Vaziyatga huquiy baho bering.
  Taraflarning harakatlarini tahlil qiling." });*/
            #endregion


            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Ҳуқуқбузарликлар профилактикаси фанининг предмети ҳақида маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Ҳуқуқбузарликлар профилактикаси фанининг мақсади нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Ҳуқуқбузарликлар профилактикаси фанининг вазифаларини санаб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Ҳуқуқбузарликлар профилактикаси тушунчаси моҳиятини таърифлаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "Ҳуқуқбузарликлар профилактикасини ташкил этишда турли хил характердаги чора-тадбирлар ишлаб чиқилади. Улар қандай чора - тадбирлар." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Ҳуқуқбузарликлар профилактикаси фаолиятини тартибга солувчи қонунларни таҳлил қилинг. Бевосита ва билвосита қонунларни шарҳланг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Ҳуқуқбузарликлар профилактикасининг ўзига хос хусусияти ва қонуниятларини батафсил ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Ҳуқуқбузарликлар профилактикасининг асосий принциплари ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Ҳуқуқбузарликлар профилактикаси фанининг предмети сифатида ғайриижтимоий хулқ - атвор тушунчаси ва унинг ўзига хос хусусиятларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Ўзбекистон Республикасида ҳуқуқбузарликлар профилактикаси соҳасидаги сўнгги ислоҳотлар ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Ҳуқуқбузарликлар профилактикаси соҳасини такомиллаштириш бўйича Ўзбекистон Республикасида амалга оширилаётган ислоҳотларни ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Ҳуқуқбузарлик жабрланувчиси ким.Моддий, маънавий ва жисмоний зарар тушунчаларига ойдинлик киритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Ҳуқуқбузарликлар профилактикасининг турлари бўйича маълумот беринг. Уларнинг турларга ажратишдан мақсад нима." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Ҳуқуқбузарликлар профилактикасини амалга оширувчи ва унда иштирок этувчи органлар ҳамда муассасаларнинг ҳуқуқбузарликларнинг олдини олиш, ҳуқуқбузарликларнинг содир этилиши сабабларини ва унга имкон бераётган шарт-шароитларни аниқлаш, бартараф этиш бўйича фаолияти ҳуқуқбузарликларнинг қайси турига хос хусусият ҳисобланади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Ҳуқуқбузарликларнинг умумий профилактикаси объектлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Ҳуқуқбузарликларнинг умумий профилактикасининг усулларини таҳлил қилинг ва ўзаро фарқли жиҳатларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Ҳуқуқбузарликларнинг сабаб ва шароитларини мазмуни бўйича таснифлашда қайси турларга ажратилади. Улар ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Ҳуқуқбузарликларнинг сабаб ва шароитларини мазмуни бўйича таснифлашини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Терроризм ва диний экстремизм хавфи кучайганда қандай махсус профилактик тадбирлар ўтказилади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Маъмурий ҳудуддаги криминоген вазият даражасига таъсир қилувчи иқтисодий ва ижтимоий омилларга батафсил тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Профилактика инспектори томонидан юритиладиган иш китобларинни ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Маъмурий ҳудуддаги криминоген вазиятни баҳолаш мезонлари таркибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Маъмурий ҳудуд китоби(паспорти) ни тўлиқ ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "2022 – 2025 йилларда Ўзбекистон Республикасида жамоат хавфсизлигини таъминлаш тизимини ривожлантириш Стратегиясида жамоат хавфсизлигини таъминлашнинг ҳуқуқий асосларини ривожлантириш мақсадида қандай қонун ҳужжатлари лойиҳалари ишлаб чиқилиши назарда тутилди." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Профилактика инспекторининг маъмурий ҳудуддаги криминоген вазиятни ўрганиш ва таҳлил қилиш фаолиятига оид норматив - ҳуқуқий ҳужжатларни таҳлил қилинг" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Профилактика инспекторининг жиноятларни фош этиш ва қидирувдаги шахсларни аниқлаш фаолиятининг ўзига хос хусусияти нимадан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Профилактика инспектори томонидан қидирувдаги шахсларни аниқлаш давомида бажариладиган чора - тадбирларни ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Оиладаги тазйиқ ва зўравонликдан ҳимоя қилиш соҳасидаги давлат сиёсатининг асосий йўналишлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "Оиладаги тазйиқ ва зўравонликдан ҳимоя қилиш соҳасидаги ваколатли давлат органлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Хотин - қизларни тазйиқ ва зўравонликдан ҳимоя қилиш бўйича жорий қилинган ҳимоя ордери, уни бериш тартиби ва унинг муддатини узайтириш бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Ҳимоя ордери бўйича норматив-ҳуқуқий ҳужжатлардаги янгиликларни айтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Оилалардаги тазйиқ ва зўравонликдан ҳимоя қилиш соҳасини тартибга солувчи норматив-ҳуқуқий ҳужжатларга батафсил тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Вояга етмаганлар ўртасида назоратсизлик ва ҳуқуқбузарликлар профилактикасини ташкил этиш ҳамда ушбу йўналишдаги фаолиятни мувофиқлаштирувчи органларга тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Вояга етмаганлар ўртасида назоратсизлик ва ҳуқуқбузарликлар профилактикасини тартибга солувчи норматив-ҳуқуқий ҳужжатларга батафсил тўхталиб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Профилактика инспекторининг вояга етмаганлар ўртасида назоратсизлик ва ҳуқуқбузарликлар профилактикаси бўйича фаолиятининг асосий йўналишлари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Вояга етмаганларни ихтисослаштирилган ўқув тарбия муассасасига жойлаштириш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Вояга етмаганларни ижтимоий - ҳуқуқий ёрдам кўрсатиш марказига жойлаштириш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Профилактика инспектори томонидан вояга етмаганларни ихтисослаштирилган ўқув тарбия муассасасига жойлаштириш бўйича тайёрланиши лозим бўлган ҳужжатларга тўхталинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Профилактика инспекторининг уй қамоғи тарзидаги эҳтиёт чораси қўлланилган шахсларни ҳисобга олиш ва назоратини амалга ошириш тартиби." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Уй қамоғи тарзидаги эҳтиёт чорасини қўллаш асослари, тушунчаси ва ҳуқуқий асослари." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Профилактика инспектори уй қамоғи тарзидаги эҳтиёт чораси қўлланилган шахс билан суҳбат ўтказиши ва унга тушунтириши лозим бўлган ҳолатлар нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Профилактика инспекторининг пробация хизмати билан ишлаш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Профилактика инспекторининг пробация хизмати назоратидаги шахслар билан ишлаш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Профилактика инспекторининг профилактик ҳисобда турувчи шахслар билан ишлаш тартибини тушунтириб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Маъмурий назорат тушунчасини таърифлаб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Профилактика инспекторининг жазони ижро этиш муассасаларидан озод қилинган айрим тоифадаги шахслар устидан маъмурий назоратни таъминлаш бўйича фаолиятини тушунтириб беринг" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Жазони ижро этиш муассасаларидан озод қилинган айрим тоифадаги шахслар устидан маъмурий назорат соҳасини тартибга солувчи қонун ҳужжатларини ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Профилактика инспекторининг жазони ижро этиш муассасаларидан озод қилинган айрим тоифадаги шахслар устидан маъмурий назоратни ўрнатиш бўйича бажариши лозим бўлган ҳаракатлар кетма - кетлигини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Маъмурий назорат қоидаларини батафсил ёритиб беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "Маъмурий назоратдан бўйин товланганда келиб чиқадиган юридик оқибатлар ҳақида тўхталинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Профилактика инспекторининг муайян яшаш жойига эга бўлмаган шахслар билан ишлаш фаолиятини тушунтиринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Реабилитация марказларининг асосий вазифалари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Муайян яшаш жойига эга бўлмаган шахсга таъриф беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Реабилитация марказлари кимлар учун ташкил этилган." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Наркологик ёрдам соҳасини тартибга солиш соҳасидаги ваколатли давлат органлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Аҳолига наркологик ёрдам кўрсатишнинг ижтимоий ва ҳуқуқий томонлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Наркологик касалликларга чалинган шахсларни мажбурий даволаш бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Наркологик касалликка чалинган шахсни мажбурий даволашга юбориш тартиби бўйича қонун ҳужжатларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Наркологик касалликларга чалинган, мажбурий даволанаётган шахсларнинг ҳуқуқ ва мажбуриятлари бўйича маълумот беринг" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Профилактика инспекторининг сурункали алкоголизм, гиёҳвандлик ва заҳарвандликка мубтало бўлган шахслар билан ишлаш фаолиятини тартибга солувчи норматив-ҳуқуқий ҳужжатларни ёритиб беринг" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Ҳуқуқбузарликнинг якка тартибдаги профилактикаси объектларини санаб ўтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Оилада зўрлик ишлатиб содир этиладиган жиноятларга аниқлик киритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Оилани қўллаб-қувватлаш чоралари бўйича Ўзбекистонда ўтказилаётган ислоҳотлар хусусида маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Вояга этмаганлар томонидан жиноят содир этилишига имконият яратувчи сабаблар ва омиллар жумласига қайсиларни киритиш мумкин." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Виктимлик даражаси юқори бўлган шахслар – касби, ижтимоий мақоми, биофизиологик хусусияти, моддий аҳволи, маънавий-руҳий белгиларига кўра аниқланади.Виктимлик даражаси юқори бўлган шахсларга кимлар киради." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "Ҳуқуқбузарликлар профилактикаси фаолиятида камчилик ва муаммолар нималардан иборат. Уларни бартараф этиш бўйича фикр ва мулоҳазаларингиз." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Вояга етмаганларга ижтимоий - ҳуқуқий ёрдам кўрсатиш марказининг фаолияти ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Болалар масалалари бўйича миллий комиссиянинг таркибини шакллантирилиши ва иш фаолиятини ташкил этиш тартиби ҳақида батафсил маълумот беринг" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Ҳуқуқбузарликларнинг сабаб ва шароитларини мазмуни бўйича таснифланиши ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Кимлар ҳуқуқбузарлик содир этишга мойил шахслар сифатида эътироф этилиши мумкин. Улар ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Оиладаги жиноятлар ва ҳуқуқбузарликларнинг сабаблари ва содир этилишига имкон бериши мумкин бўлган шароитлар ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Оиладаги жиноятларнинг олдини олиш чоралари тўғрисида маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Шахсларда виктимликнинг уч даражаси бўйича маълумот беринг.Улар орасидаги фарқларни ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Оиладаги жиноятчиликларнинг ижтимоий - руҳий сабаб ва шароитлари ва уларнинг оқибатлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Таълимни давлат томонидан бошқариш органларининг ва таълим муассасаларининг ҳуқуқбузарликлар профилактикаси соҳасидаги ваколатлари бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Фуқароларнинг ўзини ўзи бошқариш органларининг ҳуқуқбузарликлар профилактикасидаги иштироки нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Ҳуқуқбузарликлар профилактикасининг мақсадлари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "Ўзбекистон Республикасининг “Ҳуқуқбузарликлар профилактикаси тўғрисида”ги қонуни мазмун - моҳиятини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "Ички ишлар органлари қўриқлаш хизматлари ҳуқуқбузарликлар профилактикасида қандай вазифаларни амалга оширади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "Ҳуқуқбузарликлар сабаблари ва уларни келтириб чиқарувчи шароитлар ҳақида маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Ҳуқуқбузарликлар профилактикасида иштирок этувчи органлар ҳамда муассасаларни айтинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Ички ишлар органларининг ҳуқуқбузарликлар профилактикаси бўйича вазифалари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Прокуратура органларининг ҳуқуқбузарликлар профилактикаси бўйича вазифалари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "Давлат хавфсизлик хизмати органларининг ҳуқуқбузарликлар профилактикаси бўйича вазифалари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Давлат солиқ хизмати органларининг ҳуқуқбузарликлар профилактикаси бўйича вазифалари нималардан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "Профилактика инспектори қайси йўналишда виктимологик профилактикани ташкил этиши керак." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Профилактик ҳисоб қайси тоифадаги шахсларга нисбатан юритилади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Профилактика инспекторининг якка тартибдаги профилактикаси қайси тоифадаги шахсларга нисбатан амалга оширилади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Профилактика инспекторининг ҳуқуқбузарликларнинг махсус профилактикасида соҳавий хизматлар билан ҳамкорлигининг аҳамияти нимадан иборат." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Профилактика инспектори ҳуқуқбузарликларнинг умумий профилактикасини амалга оширишда қандай усул ва воситалардан фойдаланади." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "“Фуқаробай” ишлаш тизимининг ижтимоий - профилактик аҳамияти ҳақида батафсил маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Республикада, минтақада ёки шаҳар - туман миқёсида ёхуд алоҳида кичик ҳудуд ва объектда айрим турдаги ҳуқуқбузарликларнинг махсус профилактикаси ўтказилишидан мақсад нима." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Ҳуқуқбузарликларнинг сабаб ва шароитлари мазмуни бўйича таснифланганда иқтисодий-моддий турга ажратилади. Иқтисодий - моддий сабаб ва шароитнинг ҳамда ҳуқуқбузарликларнинг ўзаро боғлиқлигини батафсил ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Профилактика инспекторининг “фуқаробай” ишлаш қандай тартибда амалга ошириши бўйича маълумот беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Ҳуқуқий тарғибот ва унинг оғзаки, ёзма ва кўргазмали шакллари хусусида тушунтириш беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Ижтимоий реабилитация қилиш ва ижтимоий мослаштириш чора - тадбирлари, хусусан “Меҳр” 1, 2, 3, ва 4 операциялари ҳақида тушунча беринг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Ҳуқуқбузарликлар профилактикасининг инсонпарварлик принципини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Профилактика инспектори фаолиятининг асосий вазифаларини ёритинг." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Ҳуқуқбузарликлар профилактикаси бўлинмаларининг ёшларга оид давлат сиёсати соҳасидаги ваколатлари." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "Вояга етмаганлар ўртасида назоратсизлик ва ҳуқуқбузарликларнинг профилактикасини амалга оширишнинг асосий усулларини айтинг." });

            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 1,
                Question = "Янгийўл туманида яшовчи фуқаро Д.Л. ғайриижтимоий хулқ-атворга хос бўлган барча хислатларни ўзида жам қилган, жумладан у фуқаро О.Р. билан қонуний никоҳсиз эр-хотин бўлиб, кўп қаватли уйларда яшаб, баланд овозда мусиқа оҳангларини эшитиб, қўшниларнинг тинчини бузиб келмоқда. Бундан ташқари улар оилада низоли ва жанжалли вазиятларни юзага келтириб, спиртли ичимликка ружу қўйишган. Ички ишлар органлари томонидан бир неча бора жамоат жойларида спиртли ичимлик истеъмол қилганлиги учун огоҳлантирилишига қарамай, бундай одатларини ташламаган. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Д.Л. ва О.Р.ларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 2,
                Question = "Навбатдаги оилавий низо натижасида фуқаро К.Иванов турмуш ўртоғи С.Иванова билан жанжаллашиб, унга тан жароҳати етказди. Жойига чиқиб вазиятни ўрганган профилактика инспектори оилавий низоларнинг негизида оилавий-маиший муаммолар бўлиб, К.Ивановнинг ҳам, С.Ивановнинг ҳам муттасил спиртли ичимлик ичиши оилавий жанжалнинг асосий қўзғатувчи омил бўлган деб хулосага келган.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро К.Ивановнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 3,
                Question = "Вояга етмаган А.Рахмонов сўнги вақтлардаги мактабдаги дарсларини қолдириб, тарбияси қийин ўсмир сифатида назоратга олинган. Яшаш ҳудудидаги бир тўда болалар ҳамда мактабдаги болалар билан доимо жанжал ва низолар қуршовида бўлиб, унинг сўнгги хатти-ҳаракати, синфдоши фуқаро С.Ғафуровни ҳақорат қилиб унга тан жароҳати етказиш бўлган.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\n",
                Comment = "Вояга етмаган А.Рахмоновнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n"
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 4,
                Question = "Фуқаро С.Халилов маҳаллада энг жанжалкаш фуқаролардан биридир, мунтазам равишда қўшнилар билан жанжал қилиб, ўзининг ғайриижтимоий хулқ-атвори билан доимо профилактика инспекторининг назоратида туради. С.Халилов ёшлигидан спиртли ичимликларни меъёридан ортиқ истеъмол қилиб, ўзини ҳеч бир ишда ҳанузгача топа олмаган.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро С.Халиловнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 5,
                Question = "Мактаб раҳбарияти ўқувчиларида маънавий ва ахлоқий ҳамда ҳуқуқий қадриятларга ишонч уйғотиш мақсадида маданият соҳаси вакиллари билан учрашув ташкил этади. Ушбу тадбир жараёнида ўқувчи С.Амилов шовқин-сурон кўтариб, тадбирни бузишга ҳаракат қилади. Мактаб директори С.Юнусова унга келиб танбеҳ беради, ўқувчи эса жавобан директор юзига тарсаки тушуради. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро ўқувчи С.Амиловнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 6,
                Question = "2019 йил 14 январ куни Бектемир тумани Х.Байқаро кўчаси 34 уйда яшовчи фуқаро Ш.Б. жамоат жойида спиртли ичимлик ичгани учун профилактика инспектори унга нисбатан МЖтКнинг 187- моддаси 1- қисми билан маъмурий баённома расмийлаштириб жаримага тортди ҳамда якка тартибда суҳбат ўтказиб, уни профилактик ҳисобга олди. Лекин фуқаро Ш.Б. спиртли ичимликларни яшаш жойида ичишни давом эттириб, ўзига тегишли хулоса чиқармади. 2019 йил 25 март куни фуқаро Ш.Б. яна жамоат жойида спиртли ичимлик ичгани учун профилактика инспектори унга нисбатан МЖтКнинг 187-моддаси 2- қисми билан маъмурий баённома расмийлаштириб, кўриб чиқиш учун туман маъмурий судига юборди. Суд томонидан фуқаро Ш.Б.га нисбатан 10 сутка маъмурий қамоқ жазоси тайинланди. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Ш.Б.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 7,
                Question = "Профилактика инспектори Э.Д. хизмати давомида ёш бўлишига қарамай ҳуқуқбузарлик ва бошқа ғайриижтимоий хатти-ҳаракатлар содир этган В.И.нинг ўтмишини ўрганар унинг анчадан бери назоратсизлиги ҳамда қаровсизлиги эканлиги, ҳаёти ёки соғлиғи учун хавф туғдирадиган вазиятга (шароитга) тушиб қолганлигини аниқлади. Профилактика инспектори Э.Д. вояга етмаган шахс В.И.нинг ижтимоий аҳволини тузатиш бўйича ваколатли органлар билан ишлашни бошлади.\r\nИжтимоий жиҳатдан хавфли аҳволда бўлган вояга етмаган шахс дейилганда нималар тушунилади?\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nВояга етмаган шахс В.И.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 8,
                Question = "Чирчиқ шаҳрида яшовчи, турмуш ўртоғи вафот этган, спиртли ичимлик ичишга ружу қўйган фуқаро Ж.К. томонидан ўз вояга етмаган фарзандлари В.К. ва Ф.К. моддий таъминлаш, тарбиялаш ва уларга таълим бериш бўйича ўз мажбуриятларини бажаришдан бўйин товлаб келмоқда. Ваколатли давлат органлари томонидан бир неча бора огоҳлантирилишига қарамай Ж.К. ўз мажбуриятларини бажармасдан келмоқда.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Ж.К.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 9,
                Question = "Т. исмли фуқаронинг жазони ижро этиш муассасасидан чиққанига 1 ҳафта бўлди. У экстремистик оқимга аъзолиги исботланиб, суд томонидан айбли деб топилган эди. Одатдагидек, бундай фуқаролар профилактика инспекторининг профилактик ҳисобида туради ва инспектор доимий равишда бундай фуқароларни назорат қилиб бориши зарур. Т. исмли фуқарони уйига инспектор ташриф буюради ва ўзини таништиради. Т. исмли фуқаро уйида яширин диний таълимот олаётганлиги ва таъқиқланган диний-экстремистик материаллар кўраётганлиги маълум бўлади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nТ. исмли фуқаронинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 10,
                Question = "Фуқаро Д.Бобирова йиғлаб, саросима ҳолатида профилактика инспектори хонасига арз билан кириб келди. Унинг қўллари титраб, кўзлари ёшларга тўлиб, жуда асабий ва қўзғалган эди. Унинг гапларига кўра, қайнонаси уйидан ҳайдаб юборган. Эри бу вақтда Қозоғистонда меҳнат фаолиятини олиб бормоқда. Профилактика инспектори Д.Бобирова билан уйига қайтиб олиб борганида, қайнонаси унинг худбин, болаларини уриши ва ёмон келинлигини важ келтириб, уйига киритмайди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Д.Бобирова ва унинг қайнонаси ҳаракатларини ҳуқуқий таҳлил қилинг ва уларга нисбатан содир этилган ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 11,
                Question = "Ўсмир 17 ёшда. Спорт билан шуғулланади. Мақтабди аъло баҳоларга ўқийди. Ота-онаси отасининг масъулиятсизлиги ва ароқхўрлиги сабабли доимо жанжаллашиб туришади, у кўпинча дўстлариникида ёки кўчада тунайди. Баъзан у уйга келишни ҳам истамайди. Яқинда у қамалиб чиққан фуқаро Р. билан танишади. У билан дўстлашиш оқибатида, тамаки чекиш, спирти ичимликлар ичиш каби ёмон одатларни орттиради, спорт билан шуғулланишни тўхтатиб қояди ҳамда дарсларини қолдира бошлайди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЎсмир, унинг ота-онаси ҳамда фуқаро Р.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 12,
                Question = "Оилада аёл ишлайди, турмуш ўртоғи вақтинча ишсиз. Икки нафар фарзанднинг каттаси 16, кичиги 13 ёшда, иккаласи ҳам мактаб ўқувчиси. Етишмовчилик туфайли эри ҳар куни аёли билан жанжаллашиб, уни дўппослайди. Бунга чидолмаган аёл профилактика инспектори хонаси келиб барчасини  айтиб беради, лекин ариза ёзишдан бош тортади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЭрнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 13,
                Question = "2023 йил 01 ноябрь куни соат 23:30ларда Юнусобод тумани Ўзбекистон маҳалласи ҳудудида жойлашган “Баҳор” кафесида фуқаро С.Икрамов танишлари билан спиртли ичимлик истеъмол қилиб, кафени ёптирмасдан ўтирганлиги сабабли, кафе маъмурияти томонидан ИИБ 102 га хабар берилди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nГ.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 14,
                Question = "21 март куни Навоий шаҳрида 31 ёшли аёл 3 нафар қизи билан биргаликда поезд остига ўзини ташлаган эди. Болалар яшаб қолади, аммо она оламдан ўтади. З.Ж.нинг яқин қариндошлари билан суҳбатлашилганда, оилавий шароити моддий жиҳатдан ўртаҳоллиги, бироқ турмуш ўртоғи билан муносабатларида ёмон бўлгани аниқланган. У руҳий диспансерда ҳисобда турганлиги аниқланган. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро З.Ж. ва унинг яқин қариндошлари ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 15,
                Question = "Мактаб ўқувчилари Р., П. ва В.лар кўп қаватли турар-жойнинг автотураргоҳида футбол ўйнашади. Натижада, коптокни қаттиқ тепиш натижасида, ёши катта ва ёлғиз яшайдиган фуқарога С.нинг деразасини синдиришади. Шундан кейин, ўқувчилар коптокни олмасдан воқеа жойидан қочиб кетишади. Улар қочганидан кейин, фуқаро С. профилактика инспекторига қўнғироқ қилиб хабар берилди. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nМактаб ўқувчилари Р., П. ва В.ларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 16,
                Question = "Фуқаро Э. Даминов ҳеч қаерда иш тополмаганлиги боис, яна иккита шериги билан пул топиш мақсадида тиланчилик йўлига ўтади. Улар йўл бўйида ва метро бекатидан чиқиши олдида фаолияти олиб боришади. Текин бўлган автотураргоҳни кўриб, уни ўраб, ўзбошимчалик билан пуллик хизматлар кўрсатишади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЭ. Даминов ва унинг шериклари ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 17,
                Question = "Чилонзор туман Оқтепа маҳалласида яшовчи фуқаро Б.Каримов 2023 йил 11 сентябрь куни соат 23:00ларда кўп-қаватли яшаш уйининг орқа томонида, болалар майдончасида танишлари билан спиртли ичимлик истеъмол қилиб ўтирганлиги сабабли, қўшниси Г.Хаитова томонидан ИИБ 102 га хабар берилди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nТуман хокимлиги ходимларининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 18,
                Question = "Ғайриижтимоий ҳатти-ҳаракати учун профилактика инспектори ва маҳалла раиси томонидан бир неча бора огоҳлантирилган фуқаро Ш.Қ. яна ўзининг “хурмача қилиқ”ларини бошлади. Бу сафар у спиртли ичимлик таъсирида кўп қаватли уй ҳовлисида ҳаммани оммавий сўкиб чиқиш билан кифояланди. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Ш.Қ.нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 19,
                Question = "Тошкент шаҳар Чилонзор туман 18 даҳа яшовчи фуқаролар кечки пайт “Тунги капалаклар” бозори уларнинг дам олишига ва оиладаги фарзандларининг тарбиясига салбий таъсир қилаётганлигидан нолиб туман ИИБга мурожаат қилади. ИИО ушбу ҳудудда “Орият” тадбирини ўтказишни режалаштиради.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\n“Тунги капалаклар”нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 20,
                Question = "Фуқаро Салимова, ёлғиз она бўлиб, 5 нафар вояга етмаган фарзанднинг онаси, улар учун давлат томонидан ижтимоий ёрдам ва нафақа пули олиб келмоқда. Ижтимоий ҳимоя миллий агентлиги ходимлари унинг уйига бориб хабар олишганида, она ўз фарзандларини уриб, бақириб, тарбиялаётганига гувоҳи бўлишади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Салимованинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 21,
                Question = "Ракат МФЙ ходимлари вояга етмаган, кўчада ёлғиз, бир ўзи яшаб келаётган, қаровсиз Р.В.ни ижтимоий-ҳуқуқий ёрдам кўрсатиш марказларига жойлаштирилишни сўраб мурожаат қилишади. Бундан хабар топган Р.В.нинг ота-онаси Ракат МФЙ ходимларидан бировнинг ишига аралашмасликларини айтиб жанжаллашишди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nР.В. ота-онасининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 22,
                Question = "Яккасарой тумани Ш.Руставелли кўчасида жойлашган жанубий вокзал ҳудудида хизмат олиб бораётган профилактика инспектори фуқаро Т.Хамидова томонидан поезд рельслари йўлига кўп ахлат ташлаётганлигини аниқлайди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nТ.Хамидованинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 23,
                Question = "Транспорт ва туризм объектларида жамоат хавфсизлигини таъминлаш инспекторлари томонидан поезд вагонларининг текшириб туриш ваколатлари мавжуд бўлиб, поезд ичида бир гуруҳ шахслар томонидан пиротехника воситалари сотилаётганлигини аниқлашади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nБир гуруҳ шахсларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда транспорт ва туризм объектлари инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 24,
                Question = "Фуқаро Д.Одилов пробация ҳисобда туради, пробация инспекторига алоқада бўлиши учун телефон рақамини беради. Орадан вақт ўтгач, пробация инспектори унга телефон қилади, аммо лекин телефон рақами ўчирилганлиги маълум бўлади. Шундан сўнг, пробация инспектори Д.Одиловнинг ўйига бориб текширганида, у уйда бўлиб, телефонини сотиб юборганлигини айтади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Д.Одиловнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда пробация инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 25,
                Question = "Ота-онаси вафот этиб, амакисининг оиласида яшаб келаётган 15 ёшли З.Хакимов ота-онасидан катта миқдорда пул маблағи мерос қолган бўлсада амакиси уни яхши таъминламаётганлигини, унга таълим бериш бўйича ўз мажбуриятларини бажаришдан бўйин товлаётганлигини ҳамда у билан шафқатсиз муомалада бўлаётганлигини айтиб қилган мурожаати ўз исботини топди. Шу билан бирга, амакиси ва унинг турмуш ўртоғи ўз фарзандлари билан ҳам қўпол муомалада бўлаётганлиги аён бўлди. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЗ.Хакимовнинг амакиси ва унинг турмуш ўртоғи ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 26,
                Question = "Отаси Россия Федерациясида, онаси Туркия Республикасида меҳнат мигранти бўлган 14 ёшли В.Ахадовга тарбия бериш ва таълим олишига қараш 75 ёшли касалманд бувиси М.Акбарова зиммасида. В.Аҳадов муттасил дарс қолдираётганлиги ва тарбияси салбий ҳолатлар кузатилаётганлиги маълум бўлди. Мактаб маъмурияти васий томонидан вояга етмаганни таъминлаш, тарбиялаш ва унга таълим бериш бўйича ўз мажбуриятларини бажаришдан бўйин товлаганлик ёки лозим даражада бажармаганлиги учун чора кўришини сўраб болалар ишлари бўйича идоралараро комиссияга мурожаат қилган.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nВ.Ахадовнинг ота-онаси ва бусиви ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 27,
                Question = "Фарғона вилояти Соҳ тумани қўшни Қирғизистон Республикаси билан чегарадош бўлганлиги сабабли, “Узген” МФЙ фуқаролар томонидан ушбу Республикаси ҳудудига ноқонуний равишда, чегара қоидаларини бузиб ўтиш ҳолатлари учраган. Шу сабабли чегара қишлоқларга хизмат кўрсатувчи профилактика инспектори мустақил равишда аҳоли ўртасида тарғибот, ташвиқот ишлари олиб борган.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\n“Узген” МФЙ фуқароларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 28,
                Question = "2020 йил 22 февраль куни Миробод туманида жойлашган 100-сонли умумтаълим мактаби 9-синфининг 2 нафар ўқувчиси танаффус вақтида мактабнинг ошхонасида ўзаро низолашиб, бири иккинчисини уриб,\r\nтан-жароҳати етказди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЎқувчиларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 29,
                Question = "Сурхондарё вилояти Термиз тумани “Солиобод” маҳалласида “Обод қурилиш сервис” МЧЖ томонидан 60 та янги намунавий лойиҳалар асосида уйлар қурилиб, фуқароларга топширилди. Лекин, айрим фуқаролар уйларнинг таъмирлаш ва қурилиш сифатидан норози бўлиб “Обод қурилиш сервис” МЧЖ мурожат қилишади. Масала ижобий ҳал бўлмаганлиги боис, ИИВнинг 102 телефон рақамига хабар беришади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\n“Обод қурилиш сервис” МЧЖнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 30,
                Question = "Ижтимоий жиҳатдан хавфли аҳволда бўлган Тошкент шаҳар Учтепа туманида яшовчи фуқаро “О” оиласига етарли даражада эътибор бермаётганлиги, вояга етмаган фарзанди “Ш” назоратсиз аҳволда кечалари интернет клубда юрганлиги аниқланган. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nфуқаро “О” ва унинг фарзанди “Ш”ларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 31,
                Question = "Тошкент шаҳрида “Дўстлик” МФЙда истиқомат қилувчи бир гуруҳ фуқаролар маҳалла ҳудудидан ўтган “Боғ” кўчасининг 1 ва 25 хонадонигача бўлган ҳудудини тўсиб, МФЙда жойлашган хонадонларнинг қиш мавсуми келганлигига қарамасдан иситиш тизими ишга тушмаганидан норози бўлиб кўча ҳаракатларини амалга оширишди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nБир гуруҳ фуқаролар нинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            });
            this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 32,
                Question = "Жиноят содир қилишда гумон қилинаётган айбланувчи Б.Шайвалиева вақтинча сақлаш ҳибсхонасига тунги соат 02:00да олиб келинади. В.С.Ҳ ходимлари томонидан Б.Шайвалиевадан В.С.Ҳга жойлаштирилишига нисбатан шикоят ва илтимосномалари бор йўқлиги шунингдек соғлиги ҳолати ҳақида сўралганда, шикоят ва илтимосномалари йўқлиги ҳамда соғлиги яхшилиги айтиб ўтди. \r\nШахсий тинтув В.С.Ҳ ходими А.Шодмонов томонидан бир нечта ҳолислар иштирокида ўтказилиб айбланувчи ёнидаги бир дона ошхона пичоғи, гугурт ҳамда бир пачка сигарет олиниб унинг бармоқ изларидан кўчирмалар олиниб, бошқа бир ҳомиладор айбланувчи билан битта камерага жойлаштирилди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nБ.Шайвалиева ҳамда В.С.Ҳ ходимиларининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 33,
                Question = "“Смарт” университетининг бир гуруҳ талаблари ўзларининг стипендиясини кўтариш масаласини ўзаро гуруҳ аъзолари иштирокида муҳокама қилишди. Талабалар муҳокама жараёнида олинган видеолавҳани “Инстаграм” ижтимоий тармоғида #стипендиянибиргаликдакўтарамиз хештеги орқали жойлаштиришди. Мазкур хештег талабалар ўртасида оммалашиб натижада Бунёдкор стадионига 1500 нафарга яқин талабалар йиғилишиб ўзларининг ойлик стипендияларини кўтариш бўйича намойиш ўткизишишди.\r\nИчки ишлар органлари ходимлари томонидан талабаларга масалани бундай йўл билан ҳал қилиб бўлмаслиги тушунтирилиб дарҳол ҳамма талаба тарқалиши зарурлиги таъкидланди. ИИО ходимларининг тушунтиришлари бўйича талабалар томонидан намойишни тўхтатиш ҳамда тарқалиш юзасидан амалий ҳаракатлар бажарилмаганидан кейин, талабалар тўпланган жойга тезкор гуруҳ, патрул пост нарядлари чақиртирилиб талабалар намойиши мажбурий тартибда тарқатилди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nТалабаларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 34,
                Question = "Миробод туманида жойлашган “Тонг” ресторанига кечки соат 21:00да Патрул-пост хизмати ходимлари келиб, байрам арафасида жамоат тартибини сақлаш ва ёнғин хавфсизлигини таъминлаш ҳамда фавқулодда вазиятларни бартараф этиш бўйича турли муассасалар ходимлари тегишли ташкилий-профилактик ишларни амалга ошираётганини таъкидлаб ресторанни иш фаолиятини эртароқ якунлаш талабини қўйишди. Ресторан маъмурияти томонидан ҳали иш вақти тугамаганлиги важ қилиниб иш вақти тунги соат 01:00 гача эканлиги, белгиланган вақтда ўзлари ресторанни ёпишларини таъкидлашди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nППХ ҳамда ресторан маъмуриятининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 35,
                Question = "Яккасарой тумани “Мустақиллик” кўчасида ўз хизмат вазифаларини ўтаётган ППХ ва миллий гвардия ходимлари томонидан, шу яқин ўртада жойлашган коллеж талабалари тўхтатилиб карантин талабларига риоя этмаётганлиги яъни маскасиз юрганликлари учун огоҳлантиришди. Талабалар эса ППХ ходимлари ва Миллий гвардия ходимларида фуқароларнинг карантин талабларига риоя этишларини талаб қилишга ҳақли эмасликлари таъкидлашди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nППХ ва Миллий гвардия ходимлари ҳамда талабаларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 36,
                Question = "Мустақиллик байрами арафасида жамоат тартиби ва хавфсизлигини таъминлашга қаратилган турли муассасалар ходимларидан иборат тегишли ташкилий-профилактик ишлар доирасида, 2021 йил 29 август санасида Тошкент шаҳридаги “Нукус” ва “Ойбек” кўчалари кесишмасида кечки соат 22:00да Ласетти русумли автотранспорт воситаси тўхтатилиб, ҳайдовчидан автотранспорт воситасини бошқариш ҳуқуқини берувчи хужжатларни тақдим этиш сўралганда автомобил ҳайдовчиси ва унинг ёнидаги икки нафар фуқаролар томонидан ҳужжатларни тақдим этиш ўрнига, ички ишлар органлари ходимларига нисбатан фаол қаршилик ҳаракатлари содир этилган. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nҲайдовчиси ва унинг ёнидаги фуқароларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 37,
                Question = "“Гулзор” МФЙ профилактика инспекторига МФЙ ҳудудида жойлашган “Шер” кафеси ёнида номаълум шахс ерга юзтубан ҳолатда ётгани ҳамда у яланғоч тўғрисида ИИВнинг 102 телефон рақамига хабар келиб тушди. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nНомаълум шахснинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 38,
                Question = "Транспорт ва туризм объектларида жамоат хавфсизлигини таъминлаш инспекторлари томонидан поезд вагонларининг ҳар бир купесини текшириб туриш ваколатлари мавжуд бўлиб, 7-сонли вагоннинг купеларига келганида бир гуруҳ фуқаролар купеда спиртли ичимликлар ичиб, қимор ўйинлари ўйнаётганлиги аниқланади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nБир гуруҳ шахсларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда транспорт ва туризм объектлари инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 39,
                Question = "Фуқаро С.Бахромов пробация ҳисобда туради, пробация инспектори бир неча бор унга қўнғироқ қилиб хизмат хонасига чақиради. Фуқаро С.Бахромов ходимнинг талабларига бўйсунмасликни давом этади, ва хизмат хонасига бормайди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро С.Бахромовнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда пробация инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 40,
                Question = "Тошкент давлат юридик университети “Халқаро гуманитар ҳуқуқ” кафедраси ўқитувчиси М.Турдалиев “Фаластин халқига ёрдам” шиори остида оммавий тадбир ташкиллаштиришни режалаштирди. Мазкур тадбир ўтказилиш жойи сифатида Тошкент шаҳри марказидаги Мустақиллик майдони танланиб тегишли рухсат олиш учун Тошкент шаҳар ҳокимиятига ариза билан мурожаат қилинади ҳамда ташкилотчи томонидан тадбирга қатнашиш учун чиқарилган таклифномалар иштирокчиларга тарқатилди. Бироқ, белгиланган муддатда рухсатнома тўлиқ олинмаган бўлсада, тадбир режалаштирилган куни амалга оширилиб, тинч ўтади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nМ.Турдалиевнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 41,
                Question = "Чирчиқ шаҳар ИИОФМБ ҳузуридаги Тергов бўлими томонидан А.Темур кўчасида жойлашган хиёбон қаршисида бир гуруҳ шахслар томонидан оммавий тадбир ташкиллаштирилиб, аҳолининг турли ижтимоий қатламидан иборат жами 156 нафар фуқаро ушбу тадбирга жалб этилганлиги аниқланган. Ушбу оммавий тадбирда шахси номаълум фуқаролар ўзларининг кайфиятларини амалдаги сиёсий вазиятга қарши йўналтириб, конституциявий тузумга қаршиликларини очиқ ойдин баён қилишди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nШахси номаълум фуқароларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 42,
                Question = "Тунги соат 23:45да “Бўстон” МФЙ ҳудудида “Жазира” кафеси олдида тўрт нафар ташқи кўринишидан ёши 15-16 ёшлар орасидаги қизлар ҳамда икки нафар йигит томонидан баланд овозда қўшиқ қўйиб рақсга тушаётганлиги ўша ҳудудда яшовчи фуқароларнинг ғашини келтиради. Фуқаролар А.Санаев ва Б.Хамраевларнинг танбеҳига жавобан улар дўстини туғилган кунини нишонлашаётганлигини айтиб ўйин-кулгини давом эттиришди. Натижада фуқаролар 102 қисқа рақами орқали вазият тўғрисида ички ишлар органларига хабар беришди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЁшларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 43,
                Question = "Университет томонидан “Жамоат тартиби ва хавфсизлигини таъминлаш шунингдек ҳуқуқбузарликлар профилактикасида давлат идораларининг иштироки” мавзусидаги давра суҳбати ташкиллаштирилиб кенг жамоатчилик, ОАВ вакиллари ҳамда соҳа мутахассислари таклиф этилди. Давра суҳбати жараёнида бир иштирокчи бошқа иштирокчининг фикрига қарши фикр билдириб, унинг шахсиятига тегадан гап-сўз айтади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nИштирокчининг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 44,
                Question = "Юнусобод туман “Мустақиллик” МФЙ ҳудудида ўз хизмат вазифасини патруллик наряди шаклида олиб бораётган Юнусобод тумани Миллий гвардия бўлими ходими катта лейтенанти С.Маматов, кичик сержант М.Тоиров ҳамда сафдор Г.Тожиевларни бир гуруҳ фуқаролар тўхтатиб, уларнинг уст бошлари кирлиги кийимларини ранги ўчиб кетганлиги ҳамда ҳимоя ниқобини тақмаганлиги учун койишди. Бу гапдан жаҳли чиққан Миллий гвардия ходимлари ушбу фуқароларни мажбурлаб хизмат машинасига тиқиб Миллий гвардия биносига олиб боришди.\r\nВазиятга ҳуқуқий баҳо беринг.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nМиллий гвардия ходимларининг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 45,
                Question = "Бухоро вилояти Жондор тумани фуқаролари томонидан Наврўз сайлгоҳида табиий газ танқислиги бўйича тегишли рухсат олиниб митинг ташкиллаштирилди. Митинг иштирокчиларидан бири фуқаро Т.Самадов ўзининг “Кичкинтой Богги” лақабли ити билан сайилгоҳ ҳудудига кирмоқчи бўлди. Ички ишлар органлари ходимлари томонидан сайилгоҳ ҳудудига жониворлар билан кириш мумкин эмаслиги айтади. Фуқаро Т.Самадов ИИО ходимларига эътироз билдириб рухсатнома реестрининг электрон вариантида ҳайвонлар билан оммавий тадбирга кириш мумкин эканлиги қайд этилганлигини такидлайди. ИИО ходимлари митинг ташкилотчисини чақириб келишади. Тадбир ташкилотчиси рухсатнома реестирининг қоғоз вариантини кўрсатиб унда тадбирга ҳайвонлар билан кириш тақиқланганлигини айтади. Натижада икки ўртада тушунмовчилик юзага келади. \r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nФуқаро Т.Самадовнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва унинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 46,
                Question = "Миллий гвардия ходими Л.Тожиевни ўзининг тўғридан тўғри раҳбари ҳисобланган полковник И.Асадов хонасига чақириб қўлига пул тутқазди ҳамда дўконга бориб тўрт килограм гўшт ҳамда ичимликлар сотиб олиб уйига олиб бориб беришини, шунингдек уйига ташриф буюриши керак бўлган меҳмонларни келди кетдисига қараб туришини буюрди. Мазкур топшириқдан жаҳли чиққан Л.Тожиев лабини тишлагунча раҳбари айтган топшириқни бажаришга киришиб кетди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nИ.Асадов ҳамда Л.Тожиевнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 47,
                Question = "Яшнобод тумани ИИОФМБ ҳузуридаги тергов бўлими терговчиси катта лейтенант С.Алиев “Инстаграм” ижтимоий тармоғи орқали жонли эфир қилади. Эфир вақтида бир нечта кузатувчилар томонидан Алиевнинг шахсиятига тегадиган гаплар айтилади. Алиев кузатувчиларга турли хилдаги ҳақоратомуз сўзлар билан жавоб қайтаради. Кузатувчилар ушбу жонли эфирдан Алиев томонидан айтилган ҳақоратларни мавжуд лавҳани ижтимоий тармоқлар орқали тарқатади. Шунингдек, яна битта нусхани Яшнобод тумани ИИОФМБга тақдим этади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nС.Алиев ҳамда кузатувчиларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 48,
                Question = "Миллий гвардиянинг тўрт нафар ходими ўз наряд жойини ташлаб кафеда алкогол маҳсулотини истеъмол қилаётгани хизмат ўташ жойидаги ўз хавфсизлиги бўлинмаси ходимлари томонидан аниқланиб уларнинг ҳаммасига эгаллаб турган лавозимидан озод этиш тўғрисида интизомий жазо чораси битта буйруқ билан расмийлаштирилади. Икки нафар миллий гвардия ходими алкогол истеъмол қилмаганини айтиб интизомий жазо чораси қўллаш ҳақидаги буйруқдан норози бўлиб прокуратурага шикоят қилади.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nМиллий гвардия ходимларининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 49,
                Question = "Тошкент вилояти Олмалиқ шаҳридаги Олмалиқ кон металлургия комбинати ишчилари сентябрь ойи учун ваъда қилинган қўшимча пул мукофотларини олишмади. Шунинг учун заводнинг тўқсон нафар атрофидаги ишчилари 3 сентябрьда ОКМК бошқармаси олдидаги машина йўлини тўсиб, тирбандлик ҳосил қилишди.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nОКМК ишчиларининг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); this.Logical_Cases_1.Add(new Quiz_Item()
            {
                Id = 50,
                Question = "2021 йил 7 май куни Тошкент шаҳар Юнусобод тумани 42-сонли умумий ўрта таълим мактабида 9-май “Хотира ва қадрлаш куни”га атаб туман мактаблари ўртасида спорт мусобақалари ўтказилди. Спорт мусобақаларига туман мактаб ўқувчилари ҳамда спорт ўқитувчилари ташриф буюришди. Тадбирни ўтказиш жараёнида 7-сонли умумий ўрта таълим мактаби 11-синф ўқувчилари А.Д, Д.Т, У.И, исмли шахслар 23-сонли умумий ўрта таълим мактаб 9-синф ўқувчилари С.А ва Ф.А исмли шахслар билан асоссиз равишда уларнинг ёнига бориб тазйиқ ўтказмоқчи бўлишади. Бу ҳолатни кўрган 23-сонли мактаб 9-,10-синф ўқувчилари келиб А.Д, Д.Т, У.И билан жанжаллашиб кетишади. Натижада оммавий муштлашишга содир бўлади. Бу ҳолатни кўриб муштлашишни тўхтатишга келган А.Р исмли шахмат тренери жароҳат олади. Мактаб директори туман ички ишлар бўлимига хабар беради.\r\nМазкур ҳолатга амалдаги қонунчиликка асосланиб ҳуқуқий баҳо беринг.\r\nЎқувчиларнинг ҳаракатларини ҳуқуқий таҳлил қилинг ва уларнинг ҳаракатларида ҳуқуқбузарлик аломатлари мавжуд бўлса юридик таркибини аниқланг (ЎзР МЖтК асосида).\r\nУшбу маъмурий ишни кўриб чиқишда профилактика инспекторини маъмурий процессуал ҳаракатларини батафсил ёритинг.\r\n",
                Comment = ""
            }); 
        }

        private void Generator_MockData_Ru_H()
        {
            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Предоставьте информацию о предмете дисциплины деятельности по профилактике правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 2, Question = "Что представляет собой деятельность по профилактике правонарушений?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 3, Question = "Охарактеризуйте задачи и цели предмета профилактики правонарушений?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 4, Question = "Раскройте функции и методы предмета профилактики правонарушений" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 5, Question = "Назовите стадии планирования профилактики правонарушений. Раскройте кратко каждую стадию." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 6, Question = "Назовите общие и специальные принципы планирования профилактики правонарушений. Раскройте кратко каждый принцип." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 7, Question = "Что такое деятельность по профилактике правонарушений? Подробно объясните суть, сущность и нормативно-правовые акты в сфере профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 8, Question = "Предоставьте подробную информацию об основных принципах профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 9, Question = "Каковы цели профилактики правонарушений? В чем причина большого внимания, которое уделяется данной отрасли в Узбекистане?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 10, Question = "Разъясните особенности концепции антиобщественного поведения как предмета профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 11, Question = "Предоставьте информацию о преимуществах профилактики правонарушений перед другими средствами предупреждения преступности." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 12, Question = "Кто является жертвой преступления? Уточнить понятия материального, морального и физического ущерба." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 13, Question = "Предоставьте информацию о видах профилактики правонарушений. Какова цель их классификации?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 14, Question = "Перечислите систему органов и учреждений, непосредственно занимающихся профилактикой правонарушений с указанием основных и общих задач в данной сфере." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 15, Question = "Дайте определение субъектам профилактики правонарушений и укажите их классификацию." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 16, Question = "Расскажите о деятельности субъектов координирующих профилактику правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 17, Question = "Расскажите о классификациях причин и условий совершения правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 18, Question = "Каким образом осуществляется выявление причин и условий совершения правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 19, Question = "Назовите цели определения причин и условий правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 20, Question = "Понятие и сущность общей профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 21, Question = "Одними из видов при классификации причин и условий нарушений по содержанию они делятся на экономические и материальные причины и условия. Расскажите о них подробнее." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 22, Question = "Охарактеризуйте понятие и сущность специальной профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 23, Question = "Понятие и сущность индивидуальной профилактики правонарушений. " });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 24, Question = "Понятие и сущность виктимологической профилактики правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 25, Question = "Понятие и сущность взаимодействия в профилактике правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 26, Question = "Расскажите о взаимодействии органов внутренних дел с органами и ведомствами, участвующими в профилактике правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 27, Question = "Укажите об особенностях организации и координации контроля и профилактики правонарушений среди несовершеннолетних." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 28, Question = "Поясните об организации и координации профилактики правонарушений, связанных с торговлей людьми." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 29, Question = "Какие особые профилактические меры принимаются при нарастании угрозы терроризма и экстремизма." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 30, Question = "Что такое административный надзор и порядок его ведения." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 31, Question = "Укажите особенности организация и координация профилактики правонарушений, связанных с коррупцией." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 32, Question = "Лица с высоким уровнем виктимизации определяются их профессией, социальным статусом, биофизиологическими характеристиками, финансовым статусом, духовными и психологическими характеристиками. Кто такие люди с высоким уровнем виктимизации?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 33, Question = "Расскажите о перспективах развития общественного контроля и его правовых основ." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 34, Question = "Предоставьте информацию о системе органов и учреждений, непосредственно занимающихся профилактикой преступности, и о роли ОВД в ней." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 35, Question = "Рассмотрении обращений физических и юридических лиц инспекторами профилактики." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 36, Question = "Предоставить информацию о составе и организации комиссии по вопросам детей." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 37, Question = "Какая категория лиц подлежит профилактическому учёту и основания постановки лица на профилактический учет?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 38, Question = "Охарактеризуйте общесоциальные, групповые и индивидуальные уровни причин и условий, способствующих совершению правонарушений." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 39, Question = "Расскажите об организации и координации «Дня профилактики правонарушений»." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 40, Question = "Какая отчетность есть у субъектов профилактики правонарушений перед общественностью?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 41, Question = "Расскажите о деятельности инспектора профилактики по анализу и изучению криминогенной обстановки." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 42, Question = "Расскажите о порядке дачи защитного ордера женщинам пострадавщим от притеснения и насилия." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 43, Question = "Расскажите о порядке обеспечения исполнения защитного ордера." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 44, Question = "Порядок проведения профилактических работ среди лиц, злоупотребляющих алкоголем или употребляющих наркотические средства, психотропные и другие вещества, влияющие на интеллектуально-волевую деятельность ведения дел." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 45, Question = "Расскажите об основных методах профилактики правонарушений среди несовершеннолетних." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 46, Question = "Что вам известно о результатах и перспективах реформ в системе профилактики правонарушений?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 47, Question = "Порядок постановки лица на профилактический учет и основания снятия лица с профилактического учета." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 48, Question = "Список какой категории лиц должен составить инспектор профилактики в организации виктимологической профилактики правонарушений?" });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 49, Question = "Расскажите о группах факторов противоправного поведения подростков и взрослых." });
            this.Logical_question_1.Add(new Quiz_Item() { Id = 50, Question = "На что необходимо обращать внимание при определении причин совершения правонарушений и условий, способствующих их совершению?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 51, Question = "Предоставьте информацию о предмете дисциплины деятельности по профилактике правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 52, Question = "Что представляет собой деятельность по профилактике правонарушений?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 53, Question = "Охарактеризуйте задачи и цели предмета профилактики правонарушений?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 54, Question = "Раскройте функции и методы предмета профилактики правонарушений" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 55, Question = "Назовите стадии планирования профилактики правонарушений. Раскройте кратко каждую стадию." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 56, Question = "Назовите общие и специальные принципы планирования профилактики правонарушений. Раскройте кратко каждый принцип." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 57, Question = "Что такое деятельность по профилактике правонарушений? Подробно объясните суть, сущность и нормативно-правовые акты в сфере профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 58, Question = "Предоставьте подробную информацию об основных принципах профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 59, Question = "Каковы цели профилактики правонарушений? В чем причина большого внимания, которое уделяется данной отрасли в Узбекистане?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 60, Question = "Разъясните особенности концепции антиобщественного поведения как предмета профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 61, Question = "Предоставьте информацию о преимуществах профилактики правонарушений перед другими средствами предупреждения преступности." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 62, Question = "Кто является жертвой преступления? Уточнить понятия материального, морального и физического ущерба." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 63, Question = "Предоставьте информацию о видах профилактики правонарушений. Какова цель их классификации?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 64, Question = "Перечислите систему органов и учреждений, непосредственно занимающихся профилактикой правонарушений с указанием основных и общих задач в данной сфере." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 65, Question = "Дайте определение субъектам профилактики правонарушений и укажите их классификацию." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 66, Question = "Расскажите о деятельности субъектов координирующих профилактику правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 67, Question = "Расскажите о классификациях причин и условий совершения правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 68, Question = "Каким образом осуществляется выявление причин и условий совершения правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 69, Question = "Назовите цели определения причин и условий правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 70, Question = "Понятие и сущность общей профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 71, Question = "Одними из видов при классификации причин и условий нарушений по содержанию они делятся на экономические и материальные причины и условия. Расскажите о них подробнее." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 72, Question = "Охарактеризуйте понятие и сущность специальной профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 73, Question = "Понятие и сущность индивидуальной профилактики правонарушений. " });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 74, Question = "Понятие и сущность виктимологической профилактики правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 75, Question = "Понятие и сущность взаимодействия в профилактике правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 76, Question = "Расскажите о взаимодействии органов внутренних дел с органами и ведомствами, участвующими в профилактике правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 77, Question = "Укажите об особенностях организации и координации контроля и профилактики правонарушений среди несовершеннолетних." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 78, Question = "Поясните об организации и координации профилактики правонарушений, связанных с торговлей людьми." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 79, Question = "Какие особые профилактические меры принимаются при нарастании угрозы терроризма и экстремизма." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 80, Question = "Что такое административный надзор и порядок его ведения." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 81, Question = "Укажите особенности организация и координация профилактики правонарушений, связанных с коррупцией." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 82, Question = "Лица с высоким уровнем виктимизации определяются их профессией, социальным статусом, биофизиологическими характеристиками, финансовым статусом, духовными и психологическими характеристиками. Кто такие люди с высоким уровнем виктимизации?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 83, Question = "Расскажите о перспективах развития общественного контроля и его правовых основ." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 84, Question = "Предоставьте информацию о системе органов и учреждений, непосредственно занимающихся профилактикой преступности, и о роли ОВД в ней." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 85, Question = "Рассмотрении обращений физических и юридических лиц инспекторами профилактики." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 86, Question = "Предоставить информацию о составе и организации комиссии по вопросам детей." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 87, Question = "Какая категория лиц подлежит профилактическому учёту и основания постановки лица на профилактический учет?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 88, Question = "Охарактеризуйте общесоциальные, групповые и индивидуальные уровни причин и условий, способствующих совершению правонарушений." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 89, Question = "Расскажите об организации и координации «Дня профилактики правонарушений»." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 90, Question = "Какая отчетность есть у субъектов профилактики правонарушений перед общественностью?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 91, Question = "Расскажите о деятельности инспектора профилактики по анализу и изучению криминогенной обстановки." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 92, Question = "Расскажите о порядке дачи защитного ордера женщинам пострадавщим от притеснения и насилия." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 93, Question = "Расскажите о порядке обеспечения исполнения защитного ордера." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 94, Question = "Порядок проведения профилактических работ среди лиц, злоупотребляющих алкоголем или употребляющих наркотические средства, психотропные и другие вещества, влияющие на интеллектуально-волевую деятельность ведения дел." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 95, Question = "Расскажите об основных методах профилактики правонарушений среди несовершеннолетних." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 96, Question = "Что вам известно о результатах и перспективах реформ в системе профилактики правонарушений?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 97, Question = "Порядок постановки лица на профилактический учет и основания снятия лица с профилактического учета." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 98, Question = "Список какой категории лиц должен составить инспектор профилактики в организации виктимологической профилактики правонарушений?" });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 99, Question = "Расскажите о группах факторов противоправного поведения подростков и взрослых." });
            //this.Logical_question_1.Add(new Quiz_Item() { Id = 100, Question = "На что необходимо обращать внимание при определении причин совершения правонарушений и условий, способствующих их совершению?" });

            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 1, Question = @"В ходе разъяснительной беседы в махалле “Уч тут” инспектор профилактики выступил с докладом в котором указал, что деятельность по профилактики зависит от каждого жителя махалли и необходимости своевременного реагирования на антиобщественные явления. Однако, для достижения такого уровня работы по профилактике правонарушений в Республике был осуществлен ряд реформ. 
Какие итоги и перспективы развития деятельности по профилактике можете назвать? Обоснуйте свой ответ?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 2, Question = @"22 марта 2021 года около 22.50 часов в махалле “Чимбой” гражданин А.Р., злоупотреблял спиртными напитками, не занимался воспитанием 2-х детей, нигде не работал. К инспектору профилактики обратилась супруга гражданина А.Р. с просьбой оказать на него воздействие и заставить его работать и помогать по хозяйству, участвовать в воспитании детей. В ответ инспектор профилактики отказался вмешивать в ситуацию, указав её как семейная перепалка. 
Скажите что понимается под деятельностью по профилактике правонарушений и правильно ли поступил инспектор профилактики?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 3, Question = @"Инспектор профилактики махалли “Шер” Ж.Шарипов вместе с председателем махалли начал изучать население указанной махалли и наличие потерпевших от правонарушений, а также лиц склонных к совершению правонарушения, совершивших правонарушение, в том числе ранее осужденных и отбывших наказание для осуществления их социализации и социальной реабилитации. В ходе изучения, ранее дважды привлеченная к административной ответственности А.Абдулова указала, что участковый не имеет полномочий по осуществлению изучения ранее совершенных лицами деяний, что за содеянное они уже понесли наказание.
Укажите на основании каких нормативных документов осуществляется деятельность по профилактике правонарушений. Назовите правовые основы деятельности по профилактике правонарушений?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 4, Question = @"Председатель схода граждан “Нурли” попросил инспектора профилактики сходить на собрание вместо него в хокимият района по вопросам состояния задолженности за коммунальные услуги махалли. Инспектор профилактики, возмутившись ответил, что это не входит в его компетенцию и он не уполномочен вмешиваться в вопросы оплаты за коммунальные услуги.
Определите понятие и перечислите основные задачи деятельности по профилактике правонарушений." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 5, Question = @"Приступая к своей деятельности, старший инспектор профилактики махалли “Иттифок”, в ходе беседы с председателем махалли пообещал ему установить порядок. В этих целях он будет решительно бороться против любого антисоциального поведения, путем применения коллективных мер воздействия. В частности, опираясь исключительно на принуждение и будет подвергать воспитательно-профилактическому воздействию соседей и знакомых правонарушителей для оказания через них на правонарушителей, а также коллективно применять в отношении всех них меры ограничения. 
Дайте определение “антисоциальному поведению” и принципам осуществления профилактической деятельности. Правильно ли рассуждает инспектор профилактики." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 6, Question = @"Председатель махалли “Эзгу” сообщил вновь назначенному инспектору профилактики что в махалле множество лиц, склонных к совершению правонарушения и потребовал в течении 1 недели выселить за пределы всех нарушителей, так как своими действиями они снижают статистику и показатели махалли. Инспектор профилактики предложил наоборот методом изолирования добиться их правомерного поведения и пояснил, что у всех правонарушителей возмет расписку о непокидании жилища. Помощник инспектора профилактики возразил, сообщив, что согласно законодательства необходимо осуществлять свою деятельность опираясь на иные методы. 
Дайте определение “лицу, склонному совершению преступления” и методам осуществления профилактической деятельности. Правильно ли рассуждает председатель махалли." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 7, Question = @"В связи с выездом в качестве трудовых мигрантов за пределы республики родителей несовершеннолетнего В.Ахадова, его воспитанием занималась тетя, которая страдала рядом хронических заболеваний. Наблюдался систематический пропуск занятий В.Ахадовым и его склонность к антиобщественным действиям. Директор школы, жалуясь на действия ученика письменно попросила инспектора профилактики принять надлежащие меры. В ответ инспектор профилактики ответил, что хоть В.Ахадов проживает в той махалле, где он работает вопросы детской беспризорности относятся другим сотрудникам. 
Скажите какая деятельность осуществляется и кем для недопущения детской беспризорности и правонарушений среди несовершеннолетних. Обоснуйте свой ответ правовыми нормами и разъяснением ситуации в казусе." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 8, Question = @"В махалле “Киличбек” участились случаи обмана граждан с целью их трудоустройства за пределами республики. Более 20 человек обратились с заявлением о принятии мер в отношении лиц мошшеническим образом завладевшими их средствами. Однако, их личности не были установлены и вероятность появления новых обманутых лиц оставалась, в связи с чем инспектор профилактики решил предупредить правонарушения и думал о возможных формах осуществления данной деятельности.
Перечислите формы осуществления профилактической деятельности. Какие формы профилактической деятельности применимы в данной ситуации?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 9, Question = @"На собрании у председателя схода граждан было намечено выступление инспектора профилактики по разъяснению деятельности по профилактике правонарушений. Останавливаясь на его определении инспектор указал, что в качестве субъекта необходимо понимать деятельностии правоохранительных органов наделенных соответствующими правомочиями по применению принудительных мер. Тогда как один из присутствующих на собрании ответил, что работает в ННО и оказывает помощь жертвам правонарушений и тоже является субъектом деятельности по профилактике правонарушений.
Дайте определение субъектам профилактики правонарушений, приведите классификацию и перечислите органы непосредственно занимающиеся профилактикой правонарушений." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 10, Question = @"На совещании по вопросам профилактики правонарушений хоким района указал, что вся ответственность за состояние данной деятельности возлагается на органы внутренних дел, хокимият должен занимать исключительно вопросами возделывания сельскохозяйственных культур, организации различных спортивно-массовых мероприятий к праздникам, а по остальным вопросам просил его не беспокоить. Когда журналист задал вопрос о том, что в профилактике правонарушений должно быть участие и представителя власти, хоким прервал его вопрос и попросил удалиться его из зала заседаний, указав, что данная тема не имеет отношения к деятельности СМИ. 
Расскажите об участии органов государственной власти на местах и СМИ в деятельности по профилактике правонарушений. Согласно имеющейся классификации к какой группе органов они относятся?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 11, Question = @"В ходе рассмотрения дела об административном правонарушении гражданином Сабуровым по факту совершени им мелкого хищения было установлено, что причиной его совершения являлся низкий уровень доходов, не покрывающих основных его нужд. Когда судья поинтересовался у органа внутренних дел, какие меры были приняты по устранению причин и условий совершения правонарушения, сотрудник ответил, что впервые рассматривает такие дела и не знал что нужно их выявлять и устранять.
Дайте определение причин и условий способствующих совершению правонарушений для чего служит выявление причин и условий совершения правонарушений." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 12, Question = @"При рассмотрении материалов об административном правонарушении сотрудник ОВД при анализа причин и условий способствующих совершению правонарушения, ограничился личностью правонарушителя. Прокурор указал о необходимости изучения быта и других обстоятельств по месту жительства правонарушителя, на что сотрудник ОВД возразил, что нельзя подвергать исследованию обстоятельства и лица прямо не связанные с правонарушением.
Скажите, кто из вышеуказанных лиц выражает верную позицию? На что необходимо обращать внимание при определении причин совершения правонарушений и условий, способствующих их совершению?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 13, Question = @"21 марта в Навоийской области, женщина в возрасте 31 года, вместе со своими тремя дочерями бросилась под проезжающий поезд. Дети остались живы, однако сама женщина умерла. По месту жительства уровень быта женщины оценивался как средний, сама характеризовалась как психически здоровый человек с ясным сознанием. Однако, имелись проблемы во взаимоотношении с супругом из-за того, что супруг предъявлял ей претензии «Ты не рожаешь сына!» в следствии чего, в её духовном состоянии наблюдались изменения, однако она не вступала в конфликт с другими членами своей семьи.
Причина совершения суицида по своему содержанию к какому виду относится? Какие профилактические меры необходимо организовать для предупреждения такого рода происшествий?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 14, Question = @"На подразделения профилактики правонарушений и центры социально правовой реабилитации несовершеннолетних возложена задача по недопущению совершения антисоциальных поступков, постановки в социально-опасное положение детей привезенных в рамках операции                “Мехр-4” из Афганистана в махаллю “Катта Белтепа” с принятием соответствующих мер профилактической направленности.
В каком порядке и последовательности должны быть осуществлены меры по общественной реабилитация и социализации? Расскажите об организации деятельности по профилактике ОВД." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 15, Question = @"Человек по имени “А” в состоянии алкогольного опьянения нанес родственнику по имени “Б” телесные повреждения средней тяжести. Эта ситуация повторялась 3 раза подряд. Из-за родственных отношений между жертвой и преступником, человек по имени Б. долгое время не сообщал об этом в полицию. Несмотря на последующую апелляцию, ОВД ему не помогли, и против человека “А” не было принято никаких мер. 
Укажите случаи первичной виктимизации и повторной виктимизации в этом случае. Может ли лицо по имени “B” быть юридически признано потерпевшим, если оно не подает жалобу в полицию и не признает действия лица “A” преступным посягательством на его или ее здоровье и жизнь?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 16, Question = @"Сельский врач СВП указал, что на территории его обслуживания проживает             12 лиц, склонных к совершению правонарушения в следствии чрезмерного употребления спиртных напитков. На что инспектор профилактики ответил, что люди, употребляющие спиртные напитки являются более надежными и для применения мер индивидуальной профилактики необходимы более веские основания. Врач сказал, что за последние 3 месяца эти 12 лиц трижды были приведены в СВП родственниками для детоксикации и ходе беседы родственники отметили, что правонарушители начали кидаться на прохожих, обзывать соседей, разбивать домашнюю посуду.
Скажите что необходимо предпринять инспектору профилактики? Расскажите о понятии, сущности и основаниях индивидуальной профилактики правонарушений." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 17, Question = @"Министр внутренних дел в отчете представленном 12 марта 2021 года в Сенат Олий Мажлиса перечислены статданные по преступлениям совершенным в семье. В частности, всего совершено 143 убийства, 192 нанесения тяжких телесных повреждений, 18 изнасилований, 32 хулиганства и 14379 административных правонарушений.
Перечислите причины и условия совершения правонарушений в семье. Расскажите об организации деятельности по профилактике в семье." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 18, Question = @"ГУВД г.Ташкента за 2020 год были осуществлены различные мероприятия по пресечению и предупреждению антиобщественной деятельности преступных группировок, вовлекавших в свои ряды молодых учащихся школ и техникумов. Приводы молодых участников в органы внутренних дел стали причиной недовольства со сторон родителей, полагавших что их дети исправно учатся и не имеют отношение к преступлениям. В связи с чем руководителем следственной группы было принято решение о доведении до общественности результатов проделанной работы.
Расскажите о перспективах развития общественного контроля и его правовых основ. Какая отчетность субъектов профилактики правонарушений перед общественностью имеется?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 19, Question = @"В райотделе полиции выяснилось, что количество краж скота в микрорайоне  А в 2019 году увеличилось на 50 процентов по сравнению с 2018 годом. Чтобы уменьшить количество краж в этом районе, в начале 2020 года на всех улицах района были установлены камеры наблюдения, и в течение года в этом районе не происходило краж скота.
В районе Б воровство скота в 2019 году снизилось на 20 процентов по сравнению с 2018 годом. Однако в 2020 году в этом районе было на 10 процентов больше краж, чем в 2018 году. Камеры видеонаблюдения на улицах микрорайона Б вообще не устанавливаются.
В обоих районах есть основания полагать, что кража могла быть совершена определенной группой лиц, но эти данные не получили полного подтверждения. Оба квартала расположены рядом.
Вопрос 1. Согласно казусу, можно ли назвать установку камер наблюдения на улицах микрорайона А мерой ситуационной профилактики преступности? Кем и какие еще меры могут быть приняты для ситуативного предотвращения краж?
Вопрос 2. Могла ли установка камер наблюдения на улицах микрорайона А в 2020 году привести к увеличению краж скота в микрорайоне Б? Оцените эту ситуацию на основе теории миграционной преступности, исходя из конкретного случая. Если вы знаете, что корреляция между изменениями количества краж скота в обоих микрорайонах не может быть полностью доказана, обоснуйте свое мнение." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 20, Question = @"По завершении расследования уголовного дела по факту кражи, совершенное гражданином Рихсиевым в состоянии алкогольного опьянения на спор со своим соседом, следователь Шарипов не нашел обстоятельств, которые способствовали совершению правонарушения и направил дело прокурору. Прокурор возразил и потребовал внести представление. 
Скажите какого характера преставление следует внести следователю Шарипову. 
Расскажите, что вы понимаете под представлениями об устранении причин правонарушений и условий, способствующих их совершению?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 21, Question = @"Абдуллаев Эркин Шухратович, 1980 года рождения, житель Юнусабадского района, махалли Бободехкан, ул. Гульшан, квартира 10, был осужден Юнусабадским районным судом по уголовным делам 10 января 2007 года за совершение преступления, предусмотренного частью первой статьи 156 УК Республики Узбекистан и приговорен к 3 годам лишения свободы. 20 января 2010 года гр. Э.Абдуллаев вернулся, отбыв полный срок назначенного ему наказания. В этот же день он встретился с районным инспектором профилактики майором Н.Кадыровым со справкой из учреждения по исполнению наказаний и сообщил, что он вернулся оттуда в своё прежнее место жительства: Юнусабадский район, ул. Гульшан, квартира 10.
Каковы дальнейшие действия инспектора по профилактике? 
Раскройте подробнее меру индивидуальной профилактики правонарушений в виде административного надзора." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 22, Question = @"От физического лица по имени Б. поступило обращение государственному органу, которое было рассмотрено в установленном порядке и сроки, в результате чего направлено ответное письмо через почту. После отправления ответного письма, от этого физического лица пришло повторно обращение с теми же доводами, которые были приведены в первом письме
В связи с тем, что ранее было направлено ответное письмо государственный орган не направил ответ на повторное обращение физического лица Б.
Дайте правовую оценку." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 23, Question = @"В государственный орган поступило обращение физических лиц А. и С. Государственным органом данное обращение было зарегистрировано и направлено соответствующиму подразделению для исполнения. При рассмотрении соответсвующим подразделением обращение физических лиц А. и С. было выяснено, что доводы которые приводятся в обращении были решены положительно, в связи с чем А. и С. обратились заявлением о прекращении рассмотрении их ранее направленное обращение. В результате чего исполнитель соответствующего подразделение прекратил рассматривать обращение А. и С.
Дайте правовую оценку действиям исполнителя соответсвующего подразделения." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 24, Question = @"Директор фирмы “Альфа” обратился в областную прокуратуру с заявлением. Через 17 дней он обратился повторно жалобой указав, что не получил ответ на ранее направленное обращение, на что сотрудник областной прокуратуры в устном порядке разъяснил директору, что его письмо было перенаправлено соответсвующему органу для рассмотрения.
Дайте правовую оценку." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 25, Question = @"Инспектором профилактики правонарушений майором Бабуровым Д был установлен административный надзор над его зятем. Инспектор утверждал о том, что его положение в обществе и его должность позволяет устанавливать административный надзор над любым человеком в Республики Узбекистан. 
Имеет ли право инспектор по профилактике правонарушений устанавливать административный надзор и по отношению к каким лицам устанавливается административный надзор?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 26, Question = @"Работник завода ТТЗ гражданин О.Буриев 1965 года рождения, 2 сентября  2020 года после рабочего дня примерно в 18:00 вечера начал распивать водку, присев на траву у реки Анхор. В это же время инспектор профилактики Б.Муродов и его помощник М.Расулов, нёсшие службу на этой территории, увидев такую картину, сообщили гражданину О.Буриеву, что здесь нельзя пить алкоголь и доставили его в махаллинский пункт правопорядка.
Каковы дальнейшие действия инспектора профилактики?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 27, Question = @"16 ноября 2020 г. примерно в 10:00 утра инспектор профилактики 111-го М.Улугбекского отдела внутренних дел капитан Б.Муродов и его помощник М.Рахимов во время несения службы обнаружили неизвестного гражданина в возрасте 20-22 лет возле супермаркета “Дунё”, который был в состоянии алкогольного опьянения и высказываясь неприличными словами и выражениями нарушал покой мимо проходящих людей. Инспектор профилактики потребовал остановить подобные действия и доставил неизвестного молодого человека в территориальный махаллинский пункт правопорядка. Во время беседы и установления личности выяснилось, что этот гражданин является Саттаровым Рустамом, 2000 г.р., временно безработный, проживающий по адресу Карасу-2, дом 20, квартира 34.
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 28, Question = @"    В дежурную часть районного ОВД поступило заявление от гражданина Г.Каримова 1948 года рождения, проживающего по адресу Мирзо-Улугбекский район, ул. Фарход, дом 16, и его заявление было зарегистрировано в книге Форма 1. По ходатайству начальника районного ОВД рассмотрение и разрешение данного заявления было возложено на инспектора по профилактике махаллинского пункта правопорядка № 106 капитана А. Солиева. Согласно заявлению, сосед Г.Каримова Толипов Носир Раимович, 1970 г.р., проживающий по адресу улица Фархода, дом 18, пришел к нему в пьяном состоянии и перед его домом надавил на него и потребовал, чтобы тот принес ему водки, а когда Г.Каримов сказал, что у него нет с собой денег, Н.Толипов ударил его по лицу и нанёс телесное повреждение. В заявлении отмечается, что в это время подоспели соседи: Б.Тошев и Р.Латиповы, которые разняли их.
    Согласно заключению проведённой судебно-медицинской экспертизы было выяснено, что потерпевший гражданин Г.Каримов получил «легкие телесные повреждения», из-за которых он не потерял здоровья на долгое время.
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 29, Question = @"Во время несения службы инспектором профилактики 106-го махаллинского пункт правопорядка М.Улугбекского района капитаном Б. Муродовым 15 февраля 2020 года примерно в 16:00 часов, и обеспечения им соблюдения правил паспортного режима на ул. Буюк ипак йўли, было выяснено следующее обстоятельство: в 50-ой квартире, принадлежавшей гр. Ф.Р. Маликову 1956 г.р. – главе ЧП “Қурувчи”, был обнаружен осуществлявший ремонт данной квартиры гражданин Холиков Жамол Носирович 1980 г.р., приехавший из Наманганской области около месяца назад, который не прошёл соответсвующей регистрации.
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 30, Question = @"Несовершеннолетний Ахмедов Носир Самадович 2006 г.р., ученик 8-класса школы № 18, проживающий по адресу: Мирзо Улугбекский район, Карасув-2, дом 15, квартира 25, 10 мая 2019 года был привлечён к ответственности за правонарушение, предусмотренное ст.183 КоАО РУз и был взят на профилактический учёт органами внутренних дел в качестве “административного правонарушителя”. Несмотря на все усилия инспектора профилактики и руководства школы и проводимых ими профилактических и надзорных мер в течение года несовершеннолетний Н.Ахмедов не менялся в положительную сторону, а именно продолжал совершать антисоциальные действия: часто пропускал занятия в школе, сбегал не раз из дома. В результате в 2020 году мать несовершеннолетнего Н.Ахмедова Ахмедова Лола Хамидовна обратилась с заявлением и просила помощи у иснспектора профилактики С.Солиева о направлении и размещении её сына в специализированное учебное заведение. 
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 31, Question = @"Несовершеннолетний С.Алиев, проживающий по адресу: Мирзо-Улугбекский район, ул. Лолазор, дом 26,. помог своему соседу, проживавшему в этом же доме Г.Солиеву, перетащить древесину, которую он использовал для ремонтных работ его квартиры, за что Г.Солиев предложил несовершеннолетнему С.Алиеву пообедать и угостил его не только едой, но и алкоголью, после обеда С.Алиев пришёл домой в пьяном состоянии. Мать С.Алиева, увидев сына в таком состоянии обратилась к инспектору по профилактике Б. Толипову с просьбой принять соответствующие меры в отношении Г.А. Солиева.
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 32, Question = @"Гражданин Ганиев Рахмат Мамарасулович 1970 года рождения, проживающий по адресу: Мирзо-Улугбекский район, ул. Гулсанам, квартира 8 и находящийся под административным надзором, 15 мая 2009 года был приговорен районным Мирзо-Улугбекским уголовным судом к 3 годам лишения свободы за преступление, предусмотренное частью первой статьи 105 УК РУз, и вернулся к месту своего жительства, отбыв полностью своё наказание 5 июня 2012 года. После чего он обратился к инспектору профилактики 302-пункта правопорядка Мирзо-Улугбекского района майору Т.Толипову и сообщил, что он имеет супругу с инвалидностью 2 группы и 2 несовершеннолетних детей, в настоящее время не работает, других кормильцев в семье не имеется, поэтому просит помощи в его трудоустройстве.
Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 33, Question = @"Вохидов Азим Толипович, 1977 года рождения, житель Юнусабадского района, улица Увайсий, квартира 20, был осужден районным уголовным судом 15 ноября 2006 года к 3 годам лишения свободы по ч. 1 ст. 169 УК РУз. После отбытия наказания в полном объеме А.Т. Вохидов прибыл к месту своего жительства и в тот же день предоставил инспектору по профилактике капитану Р.Толипову справка из учреждения по исполнению наказания.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 34, Question = @"Инспектору по профилактике 108-го отдела РОВД капитану Р.Толипову поступила информация о том, что гражданка Халикова Гулчехра Алиевна           1961 года рождения, проживающая по адресу: Юнусабадский район, квартал 19, дом 35, квартира 20, создавала условия для того, чтобы незнакомые лица могли видеться наедине в её квартире, иными словами, гр. Г. Халикова устроила публичный дом у себя в квартире.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 35, Question = @"Несмотря не неоднократные предупреждения испектора профилактики отдела РОВД Чиланзарского района майора А.Шарипова гражданке Х.Н.Ахмадовой 1980 г.р., проживающая в этом районе на ул. Катартал, дом 45, о том, что ей следует прекратить своё легкомысленное поведение, она не собиралась этого делать. После этого 10 декабря 2020 года примерно в 21:00 часов во время специальной операции в рамках специальной профилактики правонарушений гр. А.Шарипова была задержана инспектором профилактики во время того, как брала 50.000 сум у Р.Ганиева 1980 г.р., приехавшего в г. Ташкент из Сырдарьинской области.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 36, Question = @"18 июля 2021 года Саттарова Гульмира Рустамовна, гражданка Учтепинского района, 1974 года рождения, проживающая по адресу: Учтепинский район, квартал 21, дом 12, позвонила по номеру «102» с заявлением о том, что её знакомая Ботирова Алиса распространила в сети, а именно в Telegram и Facebook её фотографии и фотографии её дочери с неприличными комментариями, и попросила предпринять меры по отношению к её знакомой. Заявление было зарегистрировано в дежурном отделе в журнал Формы-2 под номером №544, а рассмотрение и разрешение данного обращения было поручено инспектору профилактики района майору Ш.Райимову.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 37, Question = @"15 июля 2021 года Абдуллаев Фаррух Музафарович, 1966 года рождения, проживающий по адресу: Мирабадский район, улица А.Термизий, дом 12, обратился к инспектору профилактики майору М.Алиеву с просьбой о том, чтобы его знакомого Шарипова Фархода 1988 года рождения, проживающего по адресу: Мирабадский район, улица Сайлгох, дом 118 привлекли к ответственности за то, что он оскорбил его всякими неприличными высказывааниями и словами на Мирабадском дехканском базаре.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 38, Question = @"10 марта 2022 года во время проведения общегородской акции «Арсенал» в Ташкентском УВД, инспектор профилактики отдела внутренних дел №7 Мирзо-Улугбекского района капитан С.Х.Юлдашев получил специальное задание проверить условия хранения охотничьего ружья, владельцем которого был Ахмадбеков Мирза Миралиевич, проживающий по адресу: массив Карасув 1, 3-й дом, квартира 5. В ходе осмотра было выявлено огнестрельное оружие модели ТОЗ-34, 12 калибра, двуствольное, заводской номер 90-55533, хранившееся в металлическом ящике с запирающейся дверью, вдали от посторонних лиц, отдельно от боеприпасов, на которое было выдано разрешение М-20, однако срок действия разрешения истек 10 дней назад.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 39, Question = @"6 мая 2021 года во время проверки паспортно-визового режима инспектором профилактики капитаном С.Мелиевым было выявлено, что гражданин Обидов Обид 1980 г.р., проживающий по адресу: Мирзо-Улугбекский район, массив Карасу-2, 20 дом, 5-квартира, работающий художником в фирме «Уста», уехал работать в Москву на 3 года на основе договора, заключённого между фирмами «Уста» и «Икс».
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 40, Question = @"Соседи несовершеннолетнего Р.О.Хайитова 2007 г.р. были недовольны его поведением и обратились с просьбой поместить его в Центр социальной и правовой помощи несовершеннолетним. Инспектор профилактики начал готовить документы для размещения несовершеннолетнего в Центр. Когда об этом узнали близкие Хайитова они устроили скандал и призвали соседей не вмешиваться в чужую жизнь.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 41, Question = @"Инспектором профилактики было выявлено, что несмотря на свой юный возраст В.И.Ильясов, у которого наблюдалось антисоциальное поведение и который не раз совершал правонарушения, долгое время находился без надзора, то есть в ситуации, опасном для его жизни и здоровья. Инспектор профилактики начал работу вместе с уполномоченными органами по улучшению состояния и исправлению поведения В.И. Ильясова.
    Каковы дальнейшие действия инспектора по профилактике?
    Каковы особенности профилактики правонарушений и безнадзорности среди несовершеннолетних в отличие от взрослых граждан?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 42, Question = @"Инспектору профилактики МСГ “Гулзор” пришло сообщение о том, что возле кафе “Шер” на земле лежит неизвестный гражданин лицом вниз. Так как опознать этого человека не получилось, его направили в Реабилитационный центр.
    Разъясните порядок отправления лиц, содержащихся в Реабилитационном центре в места их постоянного местажительства." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 43, Question = @"Гражданин С.Т.Мансуров 1972 г.р., проживающий по адресу: г. Ташкент, М.Улугбекский район, ул. Гулзор, дом 26, 5 декабря 2021 года был приговорён судом по уголовным делам к исправительным работам на 2 года по ст. 167 Уголовного Кодекса Республики Узбекистан. Было определено прохождение им наказания по месту его работы, то есть в заводе ТТЗ, находящимся в М.Улугбекском районе.
    Каковы действия сотрудника службы пробации в этом случае?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 44, Question = @"20 января 2012 года патрулирующей группой “Фидокор ёшлар” в махаллинский пункт правопорядка Юнусабадского района № 104 был доставлен безнадзорный 8-9 летний неизвестный несовершеннолетний. Во время беседы с ним, инспектору профилактики капитану В.Муродову не удалось установить личность несовершеннолетнего.
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 45, Question = @"Инспектором профилактики правонарушений Тораевой М. проводились профилактические беседы по отношению к 16-летнему Д., который систематически пропускает по неуважительным причинам занятия в образовательных учреждениях. Свое положение Д. объяснил тем, что у него нет отца, есть только мать, которая злоупотребляет спиртными напитками, также, у него есть два младших брата, в возрасте 7 и 9 лет. Инспектору по профилактике он пообещал по мере возможности посещать занятия в школе, но он продолжит работать, чтобы накормить своих братьев. 
    Какие меры должны быть предприняты инспектором профилактики?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 46, Question = @"5 августа 2021 г. в 9.00 инспектор профилактики 106-го отдела М.Улугбекского отдела внутренних дел капитан Б.Муродов во время несения службы обнаружил гражданина жителя Карасу-2, 20-дома, 34-квартиры Х.Валиева 1988 г.р., являющегося временным безработным, который слушал музыку через магнитофон на очень высокой громкости, чем нарушал покой ожидавших автобус на остановке людей, а также проходящих мимо граждан в том числе. Когда инспектор профилактики потребовал снизить звук магнитофона, X.Валиев не выполнил законную просьбу инспектора профилактики, заявив, что он будет слушать громко музыку, когда захочет. 
    Каковы дальнейшие действия инспектора по профилактике?" });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 47, Question = @"В Отдел внутренних дел Мирзо-Улугбекского района поступило анонимное сообщение о том, что в 9 часов вечера на улице Зиелилар группой лиц было совершенно правонарушение. В записке на бумаге, оставленной возле двери отдела, было сказано о том, что группой лиц были нанесены телесные повреждения одному лица, после чего, данное лицо в бесчувственном положении погрузили в машину и уехали в неизвестном направлении. 
Будет ли рассматриваться анонимное обращение? Расскажите про действия сотрудников органов внутренних дел." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 48, Question = @"В районный суд по гражданским делам Сергелийского района поступило обращение от несовершеннолетнего лица о том, что он попросил обеспечить ему законные права на наследство. В обращении было сказано о том, что несовершеннолетний является сыном от первого брака, но наследство после смерти отца получила только представители второго брака его отца.
    Будет ли рассматриваться обращение несовершеннолетнего лица? Расскажите про сроки рассмотрения обращений." });
            /*this.Logical_Cases_1.Add(new Quiz_Item() { Id = 49, Question = @"В Отдел внутренних дел Мирзо-Улугбекского района поступило анонимное сообщение о том, что в 9 часов вечера на улице Зиелилар группой лиц было совершенно правонарушение. В записке на бумаге, оставленной возле двери отдела, было сказано о том, что группой лиц были нанесены телесные повреждения одному лица, после чего, данное лицо в бесчувственном положении погрузили в машину и уехали в неизвестном направлении. 
Будет ли рассматриваться анонимное обращение? Расскажите про действия сотрудников органов внутренних дел." });
            this.Logical_Cases_1.Add(new Quiz_Item() { Id = 50, Question = @"В районный суд по гражданским делам Сергелийского района поступило обращение от несовершеннолетнего лица о том, что он попросил обеспечить ему законные права на наследство. В обращении было сказано о том, что несовершеннолетний является сыном от первого брака, но наследство после смерти отца получила только представители второго брака его отца.
    Будет ли рассматриваться обращение несовершеннолетнего лица? Расскажите про сроки рассмотрения обращений." });*/

        }

    }
}

