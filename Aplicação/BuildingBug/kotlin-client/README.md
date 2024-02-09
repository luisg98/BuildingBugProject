# io.swagger.client - Kotlin client library for BuildingBug.API

## Requires

* Kotlin 1.4.30
* Gradle 5.3

## Build

First, create the gradle wrapper script:

```
gradle wrapper
```

Then, run:

```
./gradlew check assemble
```

This runs all tests and packages the library.

## Features/Implementation Notes

* Supports JSON inputs/outputs, File inputs, and Form inputs.
* Supports collection formats for query parameters: csv, tsv, ssv, pipes.
* Some Kotlin and Java types are fully qualified to avoid conflicts with types defined in Swagger definitions.
* Implementation of ApiClient is intended to reduce method counts, specifically to benefit Android targets.

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ArtigoConstrucaoApi* | [**apiVversionArtigoConstrucaoAllGet**](docs/ArtigoConstrucaoApi.md#apivversionartigoconstrucaoallget) | **GET** /api/v{version}/ArtigoConstrucao/all | 
*ArtigoConstrucaoApi* | [**apiVversionArtigoConstrucaoDeleteIdLastUpdateDelete**](docs/ArtigoConstrucaoApi.md#apivversionartigoconstrucaodeleteidlastupdatedelete) | **DELETE** /api/v{version}/ArtigoConstrucao/delete/{id}/{lastUpdate} | 
*ArtigoConstrucaoApi* | [**apiVversionArtigoConstrucaoIdGet**](docs/ArtigoConstrucaoApi.md#apivversionartigoconstrucaoidget) | **GET** /api/v{version}/ArtigoConstrucao/{id} | 
*ArtigoConstrucaoApi* | [**apiVversionArtigoConstrucaoNewPost**](docs/ArtigoConstrucaoApi.md#apivversionartigoconstrucaonewpost) | **POST** /api/v{version}/ArtigoConstrucao/new | 
*ArtigoConstrucaoApi* | [**apiVversionArtigoConstrucaoUpdatePut**](docs/ArtigoConstrucaoApi.md#apivversionartigoconstrucaoupdateput) | **PUT** /api/v{version}/ArtigoConstrucao/update | 
*DeslocacaoApi* | [**apiVversionDeslocacaoAllGet**](docs/DeslocacaoApi.md#apivversiondeslocacaoallget) | **GET** /api/v{version}/Deslocacao/all | 
*DeslocacaoApi* | [**apiVversionDeslocacaoDeleteIdLastUpdateDelete**](docs/DeslocacaoApi.md#apivversiondeslocacaodeleteidlastupdatedelete) | **DELETE** /api/v{version}/Deslocacao/delete/{id}/{lastUpdate} | 
*DeslocacaoApi* | [**apiVversionDeslocacaoIdGet**](docs/DeslocacaoApi.md#apivversiondeslocacaoidget) | **GET** /api/v{version}/Deslocacao/{id} | 
*DeslocacaoApi* | [**apiVversionDeslocacaoNewPost**](docs/DeslocacaoApi.md#apivversiondeslocacaonewpost) | **POST** /api/v{version}/Deslocacao/new | 
*DeslocacaoApi* | [**apiVversionDeslocacaoUpdatePut**](docs/DeslocacaoApi.md#apivversiondeslocacaoupdateput) | **PUT** /api/v{version}/Deslocacao/update | 
*EstadoServicoApi* | [**apiVversionEstadoServicoAllGet**](docs/EstadoServicoApi.md#apivversionestadoservicoallget) | **GET** /api/v{version}/EstadoServico/all | 
*EstadoServicoApi* | [**apiVversionEstadoServicoDeleteIdLastUpdateDelete**](docs/EstadoServicoApi.md#apivversionestadoservicodeleteidlastupdatedelete) | **DELETE** /api/v{version}/EstadoServico/delete/{id}/{lastUpdate} | 
*EstadoServicoApi* | [**apiVversionEstadoServicoIdGet**](docs/EstadoServicoApi.md#apivversionestadoservicoidget) | **GET** /api/v{version}/EstadoServico/{id} | 
*EstadoServicoApi* | [**apiVversionEstadoServicoNewPost**](docs/EstadoServicoApi.md#apivversionestadoserviconewpost) | **POST** /api/v{version}/EstadoServico/new | 
*EstadoServicoApi* | [**apiVversionEstadoServicoUpdatePut**](docs/EstadoServicoApi.md#apivversionestadoservicoupdateput) | **PUT** /api/v{version}/EstadoServico/update | 
*ListaComprasApi* | [**apiVversionListaComprasAllGet**](docs/ListaComprasApi.md#apivversionlistacomprasallget) | **GET** /api/v{version}/ListaCompras/all | 
*ListaComprasApi* | [**apiVversionListaComprasDeleteIdLastUpdateDelete**](docs/ListaComprasApi.md#apivversionlistacomprasdeleteidlastupdatedelete) | **DELETE** /api/v{version}/ListaCompras/delete/{id}/{lastUpdate} | 
*ListaComprasApi* | [**apiVversionListaComprasIdGet**](docs/ListaComprasApi.md#apivversionlistacomprasidget) | **GET** /api/v{version}/ListaCompras/{id} | 
*ListaComprasApi* | [**apiVversionListaComprasNewPost**](docs/ListaComprasApi.md#apivversionlistacomprasnewpost) | **POST** /api/v{version}/ListaCompras/new | 
*ListaComprasApi* | [**apiVversionListaComprasUpdatePut**](docs/ListaComprasApi.md#apivversionlistacomprasupdateput) | **PUT** /api/v{version}/ListaCompras/update | 
*ListaComprasArtigosConstrucaoApi* | [**apiVversionListaComprasArtigosConstrucaoAllGet**](docs/ListaComprasArtigosConstrucaoApi.md#apivversionlistacomprasartigosconstrucaoallget) | **GET** /api/v{version}/ListaComprasArtigosConstrucao/all | 
*ListaComprasArtigosConstrucaoApi* | [**apiVversionListaComprasArtigosConstrucaoDeleteIdLastUpdateDelete**](docs/ListaComprasArtigosConstrucaoApi.md#apivversionlistacomprasartigosconstrucaodeleteidlastupdatedelete) | **DELETE** /api/v{version}/ListaComprasArtigosConstrucao/delete/{id}/{lastUpdate} | 
*ListaComprasArtigosConstrucaoApi* | [**apiVversionListaComprasArtigosConstrucaoIdGet**](docs/ListaComprasArtigosConstrucaoApi.md#apivversionlistacomprasartigosconstrucaoidget) | **GET** /api/v{version}/ListaComprasArtigosConstrucao/{id} | 
*ListaComprasArtigosConstrucaoApi* | [**apiVversionListaComprasArtigosConstrucaoNewPost**](docs/ListaComprasArtigosConstrucaoApi.md#apivversionlistacomprasartigosconstrucaonewpost) | **POST** /api/v{version}/ListaComprasArtigosConstrucao/new | 
*ListaComprasArtigosConstrucaoApi* | [**apiVversionListaComprasArtigosConstrucaoUpdatePut**](docs/ListaComprasArtigosConstrucaoApi.md#apivversionlistacomprasartigosconstrucaoupdateput) | **PUT** /api/v{version}/ListaComprasArtigosConstrucao/update | 
*LocalidadeApi* | [**apiVversionLocalidadeAllGet**](docs/LocalidadeApi.md#apivversionlocalidadeallget) | **GET** /api/v{version}/Localidade/all | 
*LocalidadeApi* | [**apiVversionLocalidadeDeleteIdLastUpdateDelete**](docs/LocalidadeApi.md#apivversionlocalidadedeleteidlastupdatedelete) | **DELETE** /api/v{version}/Localidade/delete/{id}/{lastUpdate} | 
*LocalidadeApi* | [**apiVversionLocalidadeIdGet**](docs/LocalidadeApi.md#apivversionlocalidadeidget) | **GET** /api/v{version}/Localidade/{id} | 
*LocalidadeApi* | [**apiVversionLocalidadeNewPost**](docs/LocalidadeApi.md#apivversionlocalidadenewpost) | **POST** /api/v{version}/Localidade/new | 
*LocalidadeApi* | [**apiVversionLocalidadeUpdatePut**](docs/LocalidadeApi.md#apivversionlocalidadeupdateput) | **PUT** /api/v{version}/Localidade/update | 
*PaisApi* | [**apiVversionPaisAllGet**](docs/PaisApi.md#apivversionpaisallget) | **GET** /api/v{version}/Pais/all | 
*PaisApi* | [**apiVversionPaisDeleteIdLastUpdateDelete**](docs/PaisApi.md#apivversionpaisdeleteidlastupdatedelete) | **DELETE** /api/v{version}/Pais/delete/{id}/{lastUpdate} | 
*PaisApi* | [**apiVversionPaisIdGet**](docs/PaisApi.md#apivversionpaisidget) | **GET** /api/v{version}/Pais/{id} | 
*PaisApi* | [**apiVversionPaisNewPost**](docs/PaisApi.md#apivversionpaisnewpost) | **POST** /api/v{version}/Pais/new | 
*PaisApi* | [**apiVversionPaisUpdatePut**](docs/PaisApi.md#apivversionpaisupdateput) | **PUT** /api/v{version}/Pais/update | 
*ProfissionalApi* | [**apiVversionProfissionalAllGet**](docs/ProfissionalApi.md#apivversionprofissionalallget) | **GET** /api/v{version}/Profissional/all | 
*ProfissionalApi* | [**apiVversionProfissionalDeleteIdLastUpdateDelete**](docs/ProfissionalApi.md#apivversionprofissionaldeleteidlastupdatedelete) | **DELETE** /api/v{version}/Profissional/delete/{id}/{lastUpdate} | 
*ProfissionalApi* | [**apiVversionProfissionalIdGet**](docs/ProfissionalApi.md#apivversionprofissionalidget) | **GET** /api/v{version}/Profissional/{id} | 
*ProfissionalApi* | [**apiVversionProfissionalNewPost**](docs/ProfissionalApi.md#apivversionprofissionalnewpost) | **POST** /api/v{version}/Profissional/new | 
*ProfissionalApi* | [**apiVversionProfissionalUpdatePut**](docs/ProfissionalApi.md#apivversionprofissionalupdateput) | **PUT** /api/v{version}/Profissional/update | 
*ProfissionalLocalidadeApi* | [**apiVversionProfissionalLocalidadeAllGet**](docs/ProfissionalLocalidadeApi.md#apivversionprofissionallocalidadeallget) | **GET** /api/v{version}/ProfissionalLocalidade/all | 
*ProfissionalLocalidadeApi* | [**apiVversionProfissionalLocalidadeDeleteIdLastUpdateDelete**](docs/ProfissionalLocalidadeApi.md#apivversionprofissionallocalidadedeleteidlastupdatedelete) | **DELETE** /api/v{version}/ProfissionalLocalidade/delete/{id}/{lastUpdate} | 
*ProfissionalLocalidadeApi* | [**apiVversionProfissionalLocalidadeIdGet**](docs/ProfissionalLocalidadeApi.md#apivversionprofissionallocalidadeidget) | **GET** /api/v{version}/ProfissionalLocalidade/{id} | 
*ProfissionalLocalidadeApi* | [**apiVversionProfissionalLocalidadeNewPost**](docs/ProfissionalLocalidadeApi.md#apivversionprofissionallocalidadenewpost) | **POST** /api/v{version}/ProfissionalLocalidade/new | 
*ProfissionalLocalidadeApi* | [**apiVversionProfissionalLocalidadeUpdatePut**](docs/ProfissionalLocalidadeApi.md#apivversionprofissionallocalidadeupdateput) | **PUT** /api/v{version}/ProfissionalLocalidade/update | 
*RelatorioDeslocacaoApi* | [**apiVversionRelatorioDeslocacaoAllGet**](docs/RelatorioDeslocacaoApi.md#apivversionrelatoriodeslocacaoallget) | **GET** /api/v{version}/RelatorioDeslocacao/all | 
*RelatorioDeslocacaoApi* | [**apiVversionRelatorioDeslocacaoDeleteIdLastUpdateDelete**](docs/RelatorioDeslocacaoApi.md#apivversionrelatoriodeslocacaodeleteidlastupdatedelete) | **DELETE** /api/v{version}/RelatorioDeslocacao/delete/{id}/{lastUpdate} | 
*RelatorioDeslocacaoApi* | [**apiVversionRelatorioDeslocacaoIdGet**](docs/RelatorioDeslocacaoApi.md#apivversionrelatoriodeslocacaoidget) | **GET** /api/v{version}/RelatorioDeslocacao/{id} | 
*RelatorioDeslocacaoApi* | [**apiVversionRelatorioDeslocacaoNewPost**](docs/RelatorioDeslocacaoApi.md#apivversionrelatoriodeslocacaonewpost) | **POST** /api/v{version}/RelatorioDeslocacao/new | 
*RelatorioDeslocacaoApi* | [**apiVversionRelatorioDeslocacaoUpdatePut**](docs/RelatorioDeslocacaoApi.md#apivversionrelatoriodeslocacaoupdateput) | **PUT** /api/v{version}/RelatorioDeslocacao/update | 
*ServicoApi* | [**apiVversionServicoAllGet**](docs/ServicoApi.md#apivversionservicoallget) | **GET** /api/v{version}/Servico/all | 
*ServicoApi* | [**apiVversionServicoDeleteIdLastUpdateDelete**](docs/ServicoApi.md#apivversionservicodeleteidlastupdatedelete) | **DELETE** /api/v{version}/Servico/delete/{id}/{lastUpdate} | 
*ServicoApi* | [**apiVversionServicoIdGet**](docs/ServicoApi.md#apivversionservicoidget) | **GET** /api/v{version}/Servico/{id} | 
*ServicoApi* | [**apiVversionServicoNewPost**](docs/ServicoApi.md#apivversionserviconewpost) | **POST** /api/v{version}/Servico/new | 
*ServicoApi* | [**apiVversionServicoUpdatePut**](docs/ServicoApi.md#apivversionservicoupdateput) | **PUT** /api/v{version}/Servico/update | 
*SimulacaoApi* | [**apiVversionSimulacaoAllGet**](docs/SimulacaoApi.md#apivversionsimulacaoallget) | **GET** /api/v{version}/Simulacao/all | 
*SimulacaoApi* | [**apiVversionSimulacaoDeleteIdLastUpdateDelete**](docs/SimulacaoApi.md#apivversionsimulacaodeleteidlastupdatedelete) | **DELETE** /api/v{version}/Simulacao/delete/{id}/{lastUpdate} | 
*SimulacaoApi* | [**apiVversionSimulacaoIdGet**](docs/SimulacaoApi.md#apivversionsimulacaoidget) | **GET** /api/v{version}/Simulacao/{id} | 
*SimulacaoApi* | [**apiVversionSimulacaoNewPost**](docs/SimulacaoApi.md#apivversionsimulacaonewpost) | **POST** /api/v{version}/Simulacao/new | 
*SimulacaoApi* | [**apiVversionSimulacaoUpdatePut**](docs/SimulacaoApi.md#apivversionsimulacaoupdateput) | **PUT** /api/v{version}/Simulacao/update | 
*TipoApi* | [**apiVversionTipoAllGet**](docs/TipoApi.md#apivversiontipoallget) | **GET** /api/v{version}/Tipo/all | 
*TipoApi* | [**apiVversionTipoDeleteIdLastUpdateDelete**](docs/TipoApi.md#apivversiontipodeleteidlastupdatedelete) | **DELETE** /api/v{version}/Tipo/delete/{id}/{lastUpdate} | 
*TipoApi* | [**apiVversionTipoIdGet**](docs/TipoApi.md#apivversiontipoidget) | **GET** /api/v{version}/Tipo/{id} | 
*TipoApi* | [**apiVversionTipoNewPost**](docs/TipoApi.md#apivversiontiponewpost) | **POST** /api/v{version}/Tipo/new | 
*TipoApi* | [**apiVversionTipoUpdatePut**](docs/TipoApi.md#apivversiontipoupdateput) | **PUT** /api/v{version}/Tipo/update | 
*TipoProfissionalApi* | [**apiVversionTipoProfissionalAllGet**](docs/TipoProfissionalApi.md#apivversiontipoprofissionalallget) | **GET** /api/v{version}/TipoProfissional/all | 
*TipoProfissionalApi* | [**apiVversionTipoProfissionalDeleteIdLastUpdateDelete**](docs/TipoProfissionalApi.md#apivversiontipoprofissionaldeleteidlastupdatedelete) | **DELETE** /api/v{version}/TipoProfissional/delete/{id}/{lastUpdate} | 
*TipoProfissionalApi* | [**apiVversionTipoProfissionalIdGet**](docs/TipoProfissionalApi.md#apivversiontipoprofissionalidget) | **GET** /api/v{version}/TipoProfissional/{id} | 
*TipoProfissionalApi* | [**apiVversionTipoProfissionalNewPost**](docs/TipoProfissionalApi.md#apivversiontipoprofissionalnewpost) | **POST** /api/v{version}/TipoProfissional/new | 
*TipoProfissionalApi* | [**apiVversionTipoProfissionalUpdatePut**](docs/TipoProfissionalApi.md#apivversiontipoprofissionalupdateput) | **PUT** /api/v{version}/TipoProfissional/update | 
*UtilizadorApi* | [**apiVversionUtilizadorAllGet**](docs/UtilizadorApi.md#apivversionutilizadorallget) | **GET** /api/v{version}/Utilizador/all | 
*UtilizadorApi* | [**apiVversionUtilizadorDeleteIdLastUpdateDelete**](docs/UtilizadorApi.md#apivversionutilizadordeleteidlastupdatedelete) | **DELETE** /api/v{version}/Utilizador/delete/{id}/{lastUpdate} | 
*UtilizadorApi* | [**apiVversionUtilizadorIdGet**](docs/UtilizadorApi.md#apivversionutilizadoridget) | **GET** /api/v{version}/Utilizador/{id} | 
*UtilizadorApi* | [**apiVversionUtilizadorLoginPost**](docs/UtilizadorApi.md#apivversionutilizadorloginpost) | **POST** /api/v{version}/Utilizador/login | 
*UtilizadorApi* | [**apiVversionUtilizadorNewPost**](docs/UtilizadorApi.md#apivversionutilizadornewpost) | **POST** /api/v{version}/Utilizador/new | 
*UtilizadorApi* | [**apiVversionUtilizadorUpdatePut**](docs/UtilizadorApi.md#apivversionutilizadorupdateput) | **PUT** /api/v{version}/Utilizador/update | 

<a name="documentation-for-models"></a>
## Documentation for Models

 - [io.swagger.client.models.CreateArtigoConstrucaoRequestContract](docs/CreateArtigoConstrucaoRequestContract.md)
 - [io.swagger.client.models.CreateDeslocacaoRequestContract](docs/CreateDeslocacaoRequestContract.md)
 - [io.swagger.client.models.CreateEstadoServicoRequestContract](docs/CreateEstadoServicoRequestContract.md)
 - [io.swagger.client.models.CreateListaComprasArtigosConstrucaoRequestContract](docs/CreateListaComprasArtigosConstrucaoRequestContract.md)
 - [io.swagger.client.models.CreateListaComprasRequestContract](docs/CreateListaComprasRequestContract.md)
 - [io.swagger.client.models.CreateLocalidadeRequestContract](docs/CreateLocalidadeRequestContract.md)
 - [io.swagger.client.models.CreatePaisRequestContract](docs/CreatePaisRequestContract.md)
 - [io.swagger.client.models.CreateProfissionalLocalidadeRequestContract](docs/CreateProfissionalLocalidadeRequestContract.md)
 - [io.swagger.client.models.CreateProfissionalRequestContract](docs/CreateProfissionalRequestContract.md)
 - [io.swagger.client.models.CreateRelatorioDeslocacaoRequestContract](docs/CreateRelatorioDeslocacaoRequestContract.md)
 - [io.swagger.client.models.CreateServicoRequestContract](docs/CreateServicoRequestContract.md)
 - [io.swagger.client.models.CreateSimulacaoRequestContract](docs/CreateSimulacaoRequestContract.md)
 - [io.swagger.client.models.CreateTipoProfissionalRequestContract](docs/CreateTipoProfissionalRequestContract.md)
 - [io.swagger.client.models.CreateTipoRequestContract](docs/CreateTipoRequestContract.md)
 - [io.swagger.client.models.CreateUtilizadorRequestContract](docs/CreateUtilizadorRequestContract.md)
 - [io.swagger.client.models.UpdateArtigoConstrucaoRequestContract](docs/UpdateArtigoConstrucaoRequestContract.md)
 - [io.swagger.client.models.UpdateDeslocacaoRequestContract](docs/UpdateDeslocacaoRequestContract.md)
 - [io.swagger.client.models.UpdateEstadoServicoRequestContract](docs/UpdateEstadoServicoRequestContract.md)
 - [io.swagger.client.models.UpdateListaComprasArtigosConstrucaoRequestContract](docs/UpdateListaComprasArtigosConstrucaoRequestContract.md)
 - [io.swagger.client.models.UpdateListaComprasRequestContract](docs/UpdateListaComprasRequestContract.md)
 - [io.swagger.client.models.UpdateLocalidadeRequestContract](docs/UpdateLocalidadeRequestContract.md)
 - [io.swagger.client.models.UpdatePaisRequestContract](docs/UpdatePaisRequestContract.md)
 - [io.swagger.client.models.UpdateProfissionalLocalidadeRequestContract](docs/UpdateProfissionalLocalidadeRequestContract.md)
 - [io.swagger.client.models.UpdateProfissionalRequestContract](docs/UpdateProfissionalRequestContract.md)
 - [io.swagger.client.models.UpdateRelatorioDeslocacaoRequestContract](docs/UpdateRelatorioDeslocacaoRequestContract.md)
 - [io.swagger.client.models.UpdateServicoRequestContract](docs/UpdateServicoRequestContract.md)
 - [io.swagger.client.models.UpdateSimulacaoRequestContract](docs/UpdateSimulacaoRequestContract.md)
 - [io.swagger.client.models.UpdateTipoProfissionalRequestContract](docs/UpdateTipoProfissionalRequestContract.md)
 - [io.swagger.client.models.UpdateTipoRequestContract](docs/UpdateTipoRequestContract.md)
 - [io.swagger.client.models.UpdateUtilizadorRequestContract](docs/UpdateUtilizadorRequestContract.md)
 - [io.swagger.client.models.UtilizadorLoginRequestContract](docs/UtilizadorLoginRequestContract.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer


