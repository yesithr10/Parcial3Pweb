import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { InmuebleService } from './services/inmueble.service';
import { ArriendoInmuebleService } from './services/arriendo-inmueble.service';
import { NavbarComponent } from './Arriendo/navbar/navbar.component';
import { FooterComponent } from './Arriendo/footer/footer.component';
import { InicioComponent } from './Arriendo/inicio/inicio.component';
import { AgregarInmuebleComponent } from './Arriendo/agregar-inmueble/agregar-inmueble.component';
import { AgregarArriendoInmuebleComponent } from './Arriendo/agregar-arriendo-inmueble/agregar-arriendo-inmueble.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    InicioComponent,
    AgregarInmuebleComponent,
    AgregarArriendoInmuebleComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    ]),
    AppRoutingModule
  ],
  providers: [InmuebleService, ArriendoInmuebleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
