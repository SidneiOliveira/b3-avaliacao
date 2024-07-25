import { TestBed } from '@angular/core/testing';

import { CalculoCDBService } from './calculo-cdb.service';

describe('CalculoCDBService', () => {
  let service: CalculoCDBService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculoCDBService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
