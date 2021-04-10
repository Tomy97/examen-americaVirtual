import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ContainerComponent } from './components/container/container.component';
import { HeaderComponent } from './components/header/header.component';
import { ServicioComponent } from './components/servicio/servicio.component';
import { FooterComponent } from './components/footer/footer.component';
import { DiasComponent } from './components/dias/dias.component';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [AppComponent, ContainerComponent, HeaderComponent, ServicioComponent, FooterComponent, DiasComponent],
  imports: [BrowserModule, NgbDropdownModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
