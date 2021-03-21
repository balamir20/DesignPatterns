
# Design Patterns - Tasarım Kalıpları

"Öğrenmenin en iyi yolu, başkalarına öğretebilmektir." felsefesiyle dilimin döndüğü kadarıyla bir şeyler karalamak istedim. **Tasarım kalıpları**, yazılım tasarımında yaygın olarak ortaya çıkan sorunlara karşı getirilen tipik çözümlerdir. Belki de farkında olmadan birçoğunu kullanıyoruz veya yeri geldiğinde kullan(a)mıyoruz.
## Tasarım Kalıpları

3 farklı kategoride toplamda 23 kalıp mevcut.

### [Creational (Oluşturucu)](#creational)
* [Singleton](#singleton)
* [Builder](#builder)
* [Factory Method](#factory)
*  [Abstract Factory](#abstractFactory)
* [Prototype](#prototype)
### [Structural (Yapısal)](#structural)

* [Flyweight](#flyweight)
* [Adapter](#adapter)
* [Composite](#composite)
*  [Facade](#facade)
* [Proxy](#proxy)
* [Decorator](#decorator)
* [Bridge](#bridge)

<h2 id="creational "> Creational (Oluşturucu)</h2>

Oluşturulan nesneler, en uygun ve verimli bir şekilde nasıl yaratılır sorusuna cevap verir. Nesne yaratma sorumluluklarını, farklı sınıf düzenlerinde soyutlayarak yaparlar.
* [Singleton](#singleton)
* [Builder](#builder)
* [Factory Method](#factory)
*  [Abstract Factory](#abstractFactory)
* [Prototype](#prototype)

<h4 id="singleton"> Singleton </h4>

> Bir sınıfın yalnızca bir örneğine (instance) sahip olmasını sağlarken, bu örneğe genel bir erişim noktası sağlamanıza olanak tanıyan yaratıcı bir tasarım modelidir. Kullanıcı bu örneği talep ettiğinde her seferinde somutlaştırmaya gerek kalmaksızın doğrudan erişip bellekte var olan örneği verir (static sağolsun).


<h4 id="builder"> Builder </h4>

> Karmaşık nesneleri adım adım oluşturmanıza izin veren bir modeldir. Kullanacağımız nesneler çok fazla fieldlara sahipse ve bunları farklı şekillerde kullanmak gerekirse bu kalıbı kullanıyoruz. Constructorda bu parametreleri geçebiliriz ancak bu sefer gereğinden fazla kurucu metodumuz olur ve kafa karışıklığına yol açabilir kodumuz anlaşılmayabilir. 


- Builder:  Product nesnesinin oluşturulması için gerekli soyut arayüzü sunar.
- ConcreteBuilder:  Product nesnesini oluşturur. Product ile ilişkili temel özellikleri de uygular.
- Product:  İnşa sonucu ortaya çıkan nesneye denir. ConcreteBuilder tarafından üretilir.
- Director:  Builder arayüzünü kullanarak nesne örneklemesini yapar.

<h4 id="factory">Factory Method</h4>

> Bu desen bir nesne yaratmak için arayüz sağlar ve kalıtım yoluyla hangi sınıflardan nesne yaratılacağının seçimini alt sınıflara bırakır.

<h4 id="abstractFactory">Abstract Factory</h4>

> Factory pattern ile abstract factory pattern arasındaki farkı açıklayarak açıklayamaya çalışayım. 
> Factory tek bir nesnenin, abstract factory ise birden fazla nesnenin yaratılması için arayüz sağlar.
> Abstract factory sınıftır. Factory method ise adından da anlaşılacağı üzerine metottur.
> Birden fazla ürün ile çalışmak zorunda olduğumuz durumlarda, istemciyi soyutlamak için abstract factory kullanabiliriz. Bu demek oluyor ki abstract factory birden fazla factory methoda sahiptir.

<h4 id="prototype">Prototype</h4>

> Kodumuzu sınıflara bağlı hale getirmeden mevcut nesneleri kopyalamamıza izin veren kalıptır. Bazen bir nesnenin kopyasını oluşturmak gerekebilir. Bu durumda aynı sınıftan yeni bir nesne oluştururuz sonra değerlerini yeni nesneye aktarırız. Bu her zaman geçerli olmayabilir. Kodumuz çok karmaşık ve/veya başka nesnelerle aralarında ilişki söz konusu olabilir (ekstra bağımlılık söz konusu:worried:)  Hali hazırda var olan nesneleri kopyalayarak sıfırdan elde etme zahmetinden kurtulabiliriz. 

<h2 id="structural">Structural (Yapısal)</h2>
Nesnelerin birbirleriyle nasıl birleşecekleri, daha büyük yapılar oluşturmak için nasıl bir araya geldikleriyle ilgilenir. 

* [Flyweight](#flyweight)
* [Adapter](#adapter)
* [Composite](#composite)
*  [Facade](#facade)
* [Proxy](#proxy)
* [Decorator](#decorator)
* [Bridge](#bridge)
 
