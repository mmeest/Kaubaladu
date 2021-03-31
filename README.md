<p align="center"><img src="kl.png" width="300px"></p>

<h1 align="center">
    <strong>Kaubaladu</strong>
</h1>
<h3 align="center">
    <p>CRUD operatsioonidega Kaubalao rakendus</p>
</h3>

<hr>

<p align="center"><img src="/Pic/screenshot.png" width="300px"></p>

<hr>

### Sisukord
- [Andmebaas](#andmebaas)
- [Kasutajad](#kasutajad)

<hr>

### Andmebaas
Andmebaasi 'Connectionstring' failis 'Web.config'
```
<add name="KaubaladuEntities" connectionString="metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-JVV34R1\SQLEXPRESS02;initial catalog=Kaubaladu;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
```

# NB! Antud ühendusstringis tuleb asendada 'DESKTOP-JVV34R1\SQLEXPRESS02' teie poolt kasutatava SQL serveriga.

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
