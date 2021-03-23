


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

> Factory pattern ile abstract factory pattern arasındaki farkı açıklayamaya çalışayım. 
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
 
<h4 id="flyweight">Flyweight</h4>

> Bir örnekle açıklamaya çalışayım. Bir oyunda kullandığımız bomba, şarapnel, füze, mermi gibi nesneleri düşünün bunları her seferinde newleyerek kullanırsak bize CPU problemi olarak geri döner. Nesneleri oluşturmak ve sonrasında Garbage Collector ile toplamak kullanmak çok maliyetli olacaktır. Yani sık kullanılan çok sayıdaki benzer nesnelerin bellek tüketimini optimize etmek için kullanılan desendir. 

<h4 id="adapter">Adapter</h4>

> Birbirleriyle uyumsuz arayüzlere sahip olan nesnelerin işbirliği yapabilmesine olanak sağlayan kalıptır. Bir sınıfın arayüzünü başka bir sınıfın beklediği arayüze çevirir. Örneğin bazı ülkelerin elektrik prizleri ülkemizdekilerden farklıdır. O prizlere elektronik cihazlarımızı bağlayamayız. Duvardaki prizi değiştiremeyeceğimize göre, duvardaki prizin beklediği şekilde bir arayüz sağlamalıyız bunun için de bir adaptöre ihtiyacımız var. Aynı durum yazdığımız kodlar için de geçerli. Uyumsuz arayüz sorununu ortadan kaldırmak için adapter kalıbını uygulamak yerine kodumuzda değişiklik yaparsak SOLID prensiplerinden Open/Closed prensibini ihlal etmiş oluruz.
 
 <h4 id="composite">Composite</h4>

> Nesneleri ağaç yapısı halinde düzenleyip, ardından bu nesneler arasında alt üst ilişkisi kurarak hiyerarşik bir yapı kurmamızı sağlar. Parça-bütün ilişkisi olan yerlerde kullabiliriz. Orduda generalden ere kadar bir çok rütbe vardır. Aslında baktığımızda temelde hepsi de birer askerdir. 

<h4 id="facade">Facade</h4>
 
> Facade karmaşık bir sistemi organize ederek istemciye basit arayüzler vermeyi amaçlar. Sistemleri parçalayarak onları alt sistemlere bölmek, alt sistemlerdeki curcunayı soyutlayarak basit bir arayüz vermeyi hedefler. Facade var olan nesneler için yeni bir arayüz ortaya koyarken [Adapter](#adapter) var olan arayüzü kullabilir hale getirmeye çalışır. Bir yeri aradığınızda görüşmek istediğiniz departmanın/kişinin dahili numarasını bilmiyor olabilirsiniz. Karşınıza çıkan operatör sizi istediğiniz yere yönlendirerek dahili numaraları bilme zorunluluğunuzu ortadan kaldırır.	

<h4 id="proxy">Proxy</h4>

> Dilimize vekil olarak geçen proxy kalıbına örnek vererek açıklamak istiyorum. Diyelim ki davalık olduk. Hukuki işlemleri tek başımıza yapmamız çok teferruatlı ve karışık olduğu için bizim adımıza bu işleri halledebilecek bir avukata vekaletimizi veririz. O bizim yerimize gereken yerlerde gerekli işleri halledip bize haber verir.
