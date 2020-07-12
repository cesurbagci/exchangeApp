# exchangeApp

* Windows makinem olmadığı için Visual Studio code üzerinde geliştirildi.
* Test için xunit kullanıldı.
* CurrencyLib, JsonExporterExtension, XmlConvertorExtension, CurrencyTestApp, CurrencyLib.testing projeleri sırasıyla aşağıdaki komutlar çalıştırılmalı.
* JsonExporter ve Xmlconvertor extensionları istenildiği durum da projeye eklenmeli.
* Verilen currency e göre data getirmek için Xml in ilgili node undan direkt olarak data çekmek için yapı oluşturuldu.

```
dotnet clean
dotnet restore
dotnet build
```

* Test projesini çalıştırmak için

```
dotnet test
```
## Yapılacaklar;
* Abstract Factory pattern i ile sadece Merkez bankasından değil istenilen provider dan data çekilebilir.
* veya Dependecy Injection ile istenilen provider dan data çekilmesi sağlanabilir.
* Filter ve Sorting için dinamik sorting ve filtering class ları yazılabilir ama zaten bütün data çekildiği için bunu yapmaya gerek duymadım. Xpath query library içerisine entegre edilebilirdi.
* CurrencyLib içerisindeki entity ler ayrı bir paket yapılıp, CurrencyLib projesine dependecy olarak eklenebilirdi.
* Library projeleri nuget paketleri haline getirilip versiyonla nuget e atılabilir. projelere bu paketlerin dependecy leri eklenebilir. Ben proje referans ı olarak ekledim.
* Merkez bankası üzerinden gelen xml alanlar app.config gibi bir yapıda tutulabilirdi.

## Third party paketler
* Xunit
* Newton Json
