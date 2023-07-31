import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { HeaderComponent } from "./shared/components/header/header.component";
import { FooterComponent } from "./shared/components/footer/footer.component";
import { CardapioComponent } from "./pages/cardapio/cardapio.component";
import { ComidaListagemComponent } from "./pages/comida-listagem/comida-listagem.component";
import { BebidaListagemComponent } from "./pages/bebida-listagem/bebida-listagem.component";
import { RouterModule } from "@angular/router";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    CardapioComponent,
    ComidaListagemComponent,
    BebidaListagemComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, RouterModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
