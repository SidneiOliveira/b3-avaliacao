import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CalculoCDBResponse } from './models/calculo-cdb';
import { CalculoCDBService } from './services/calculo-cdb.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'calculo-cdb-web-ui';
  calculo?: CalculoCDBResponse;
  valorInicial: number = 0;
  qtdMeses: number = 0;
  constructor(private calculoCDBService: CalculoCDBService) { }

  getCalculoCDB() {
    this.calculoCDBService.getCalculoCDB(this.valorInicial, this.qtdMeses).subscribe((calculo: CalculoCDBResponse) => {
      this.calculo = calculo;
    });
  }
}
