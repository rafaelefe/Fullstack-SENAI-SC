import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CardapioComponent } from "./pages/cardapio/cardapio.component";
import { ComidaListagemComponent } from "./pages/comida-listagem/comida-listagem.component";
import { BebidaListagemComponent } from "./pages/bebida-listagem/bebida-listagem.component";

const routes: Routes = [
  {
    path: "",
    pathMatch: "full",
    redirectTo: "cardapio",
  },
  {
    path: "cardapio", // ''
    component: CardapioComponent,
  },
  {
    path: "comidas",
    component: ComidaListagemComponent,
  },
  {
    path: "bebidas",
    component: BebidaListagemComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
