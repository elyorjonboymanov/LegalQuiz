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

            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Suverenitet tushunchasining mohiyati nimadan iborat? Nima uchun aynan “oliy hokimiyat” degan maʼnoni anglatuvchi mazkur tushuncha davlatga nisbatan qo‘llanila boshlangan deb o‘ylaysiz?" });
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
 Saylangan deputatlarning talablari asoslimi? Mazkur holat qanday hal qilinishi lozim?" });


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
            this.Logical_question_1.Add(new Quiz_Item() { Id = 1, Question = "Huquqbuzarliklar profilaktikasi fanining predmeti haqida ma’lumot bering." });
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
Taraflarning harakatlarini tahlil qiling." });

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
