<p align="center"><img src="kl.png" width="300px"></p>

<h1 align="center">
    <strong>Kaubaladu</strong>
</h1>
<h3 align="center">
    <p>CRUD operatsioonidega Kaubalao rakendus</p>
</h3>

<hr>

<p align="center"><img src="/Kaubaladu/Pic/screenshot.png" width="450px"></p>

<hr>

### Sisukord
- [Andmebaas](#andmebaas)
- [Kasutajad](#kasutajad)
- [Kasutajaõigused](#kasutajaõigused)
- [Menüüriba](#menüüriba)
- [Vaated](#vaated)

<hr>

### Andmebaas
Andmebaasi 'Connectionstring' failis 'Web.config'
```
<add name="KaubaladuEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-JVV34R1\SQLEXPRESS02;initial catalog=Kaubaladu;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
```

## NB! Antud ühendusstringis tuleb asendada 'DESKTOP-JVV34R1\SQLEXPRESS02' teie poolt kasutatava SQL serveriga.

Andmebaas: Kaubaladu

Tabel: Users
| Column Name | Data Type |
|-|-|
| Username | varchar(20) |
| Password | varchar(20) |

Tabel: Goods
| Column Name | Data Type |
|-|-|
| Id | int |
| Image | varbinary(MAX) |
| Name | varchar(50) |
| Serial | varchar(20) |
| Cathegory | varchar(50) |
| Origin | varchar(30) |
| Unit | varchar(20) |
| Amount | decimal(18,3) |

<hr>

### Kasutajad

Hetkel on rakendusel 3 kasutajat:
| Kasutajanimi | Salasõna | Roll | Tegevus |
|-|-|-|-|
| admin | admin | administraator | Saab kasutajaid lisada/muuta/kustutada |
| Martin | mmm | tavakasutaja | Näeb enda poolt andmebaasi lisatud tooteid, saab neid muuta ja kustutada |
| Martin | mmm | tavakasutaja | Näeb enda poolt andmebaasi lisatud tooteid, saab neid muuta ja kustutada |

* Rakenduses saavad ka uued kasutajad end registreerida

<hr>

### Kasutajaõigused
Vastavalt sellele kas sisse on loginud tavakasutaja või administraator omatakse erinevaid õigusi
| Õigus | tavakasutaja | admin |
|-|-|-|
| Näeb oma toodete nimekirja | ✓ | - |
| Näeb kõigi kasutajate toodete nimekirja | - | ✓ |
| Saab tooteid lisada | ✓ | - |
| Saab tooteid muuta | ✓ | - |
| Näeb toodete detailvaadet | ✓ | ✓ |
| Saab tooteid kustutada | ✓ | ✓ |
| Saab otsida nimekirjas olevate toodete hulgast | - | ✓ |
| Näeb kasutajate nimekirja | - | ✓ |
| Saab kasutajaid muuta | - | ✓ |
| Saab kasutajaid kustutada | - | ✓ |
| Näeb toodete statistikat | - | ✓ |

<hr>

### Menüüriba
Menüüriba ehk nupurida on erinev vastavalt kasutajale/sisselogimisele

<p align="center"><img src="/Kaubaladu/Pic/menu.png" width="550px"></p>

Kui kasutaja pole sisse loginud, siis kuvatakse menüüribal: 
* Rakenduse nime('Kaubaladu') / Registreeri(link) / Logi sisse(link)

<p align="center"><img src="/Kaubaladu/Pic/menuUser.png" width="550px"></p>

Kui sisse on loginud tavakasutaja, siis kuvatakse menüüribal: 
* Rakenduse nime('Kaubaladu') / Tootenimekiri(link) / Lisa toode(link) / Kasutaja - {kasutajanimi} / Logi välja(link)

<p align="center"><img src="/Kaubaladu/Pic/menuAdmin.png" width="550px"></p>

Kui sisse on loginud administraator, siis kuvatakse menüüribal:
* Rakenduse nime('Kaubaladu') / Tootenimekiri(link) / Kasutajanimekiri(link) / Statistika(link) / Kasutaja - admin / Logi välja(link)

<hr>

### Vaated

<p align="center"><img src="/Kaubaladu/Pic/register.png" width="450px"></p>
<h3 align="center">
    <p>Kasutajaks registreerimise lehekülg</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/login.png" width="450px"></p>
<h3 align="center">
    <p>Kasutaja sisselogimise lehekülg</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/userList.png" width="450px"></p>
<h3 align="center">
    <p>Tavakasutaja toote nimekirjavaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/userCreate.png" width="450px"></p>
<h3 align="center">
    <p>Tavakasutaja uue toote lisamine</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/userEdit.png" width="450px"></p>
<h3 align="center">
    <p>Tavakasutaja toote muutmise vaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/userDetail.png" width="450px"></p>
<h3 align="center">
    <p>Tavakasutaja toote detailvaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/userDelete.png" width="450px"></p>
<h3 align="center">
    <p>Tavakasutaja toote kustutamine</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/adminList.png" width="450px"></p>
<h3 align="center">
    <p>Administraatori nimekirjavaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/adminSearch.png" width="450px"></p>
<h3 align="center">
    <p>Administraatori otsinguvaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/adminStat.png" width="450px"></p>
<h3 align="center">
    <p>Administraatori statistikavaade</p>
</h3>

<p align="center"><img src="/Kaubaladu/Pic/adminUserlist.png" width="450px"></p>
<h3 align="center">
    <p>Administraatori kasutajanimekirja vaade</p>
</h3>

<hr>

## HAPPY CODING !!! :)
