import 'zone.js/dist/zone-testing';
import { getTestBed } from '@angular/core/testing';
import { BrowserDynamicTestingModule, platformBrowserDynamicTesting } from '@angular/platform-browser-dynamic/testing';

// Primeiro, inicialize o ambiente de teste do Angular.
getTestBed().initTestEnvironment(
  BrowserDynamicTestingModule,
  platformBrowserDynamicTesting()
);

// Em seguida, encontramos todos os testes.
const context = (require as any).context('./', true, /\.spec\.ts$/);
// E carregamos os módulos.
context.keys().map(context);