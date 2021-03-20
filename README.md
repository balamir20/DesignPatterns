# Design Patterns - Tasarım Kalıpları

Öğrenmenin en iyi yolu başkalarına öğretebilmektir felsefesiyle dilimin döndüğü kadarıyla bir şeyler karalamak istedim. **Tasarım kalıpları**, yazılım tasarımında yaygın olarak ortaya çıkan sorunlara karşı getirilen tipik çözümlerdir.  Belki de farkında olmadan bi çoğunu kullanıyoruz veya yeri geldiğinde kullan(a)mıyoruz. 

## Tasarım Kalıpları

3 farklı kategoride toplamda 23 kalıp mevcut.

### Creational (Oluşturucu)

Oluşturulan nesneler nasıl verimli ve en uygun bir şekilde yaratılır sorusuna cevap verir. Nesne yaratma sorumluluklarını, farklı sınıf düzenlerinde soyutlayarak yaparlar. 

* [Singleton](#singleton)
* [Builder](#builder)
* [Factory](#factory)
*  Abstract Factory
* Prototype


<h4 id="singleton"> Singleton </h4>

> Bir sınıfın yalnızca bir örneğine (instance) sahip olmasını sağlarken, bu örneğe genel bir erişim noktası sağlamanıza olanak tanıyan yaratıcı bir tasarım modelidir. Kullanıcı bu örneği talep ettiğinde her seferinde somutlaştırmaya gerek kalmaksızın doğrudan erişip bellekte var olan örneği verir (static sağolsun).


<h4 id="builder"> Builder </h4>

> Karmaşık nesneleri adım adım oluşturmanıza izin veren bir modeldir. Kullanacağımız nesneler çok fazla fieldlara sahipse ve bunları farklı şekillerde kullanmak gerekirse bu kalıbı kullanıyoruz. Constructorda bu parametleri geçebiliriz ancak bu sefer gereğinden fazla kurucu metodumuz olur ve kafa karışıklığına yol açabilir kodumuz anlaşılmayabilir. 


- Builder:  Product nesnesinin oluşturulması için gerekli soyut arayüzü sunar.
- ConcreteBuilder:  Product nesnesini oluşturur. Product ile ilişkili temel özellikleri de uygular.
- Product:  İnşa sonucu ortaya çıkan nesneye denir. ConcreteBuilder tarafından üretilir.
- Director:  Builder arayüzünü kullanarak nesne örneklemesini yapar.

<h4 id="factory">Factory</h4>

> Bu desen bir nesne yaratmak için arayüz sağlar ve kalıtım yoluyla hangi sınıflardan nesne yaratılacağının seçimini alt sınıflara bırakır.
