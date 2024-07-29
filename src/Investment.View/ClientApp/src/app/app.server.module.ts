import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { ServerModule } from '@angular/platform-server';
import { ModuleMapLoaderModule } from '@nguniversal/module-map-ngfactory-loader';
import { AppComponent } from './app.component';
import { AppModule } from './app.module';
import { InvestmentService } from './services/investment.service';

@NgModule({
    imports: [AppModule, ServerModule , ReactiveFormsModule ,ModuleMapLoaderModule],
    bootstrap: [AppComponent],
    providers: [
        InvestmentService,
        { provide: 'ORIGIN_URL', useValue: location.origin}
    ]
})

export class AppServerModule { }
