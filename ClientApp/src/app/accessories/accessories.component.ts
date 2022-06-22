import { Component, Input, OnInit } from '@angular/core';
import { DataHandlerService } from '../services/data-handler.service';

@Component({
  selector: 'app-accessories',
  templateUrl: './accessories.component.html',
  styleUrls: ['./accessories.component.scss']
})
export class AccessoriesComponent implements OnInit {

  constructor(private dataHandlerService: DataHandlerService) { }

  @Input() character: string;
  accessoriesList: any;

  ngOnInit(): void {
    this.populateAccessoriesList(this.character);
  }

  populateAccessoriesList(char: string) {
    this.dataHandlerService.getAccessories(char).subscribe((response: any) => {
      this.accessoriesList = response;
    });
  }
}
