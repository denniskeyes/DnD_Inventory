import { Component, Input, OnInit } from '@angular/core';
import { IGear } from '../interfaces/IGear';
import { DataHandlerService } from '../services/data-handler.service';

@Component({
  selector: 'app-accessories',
  templateUrl: './accessories.component.html',
  styleUrls: ['./accessories.component.scss']
})
export class AccessoriesComponent implements OnInit {

  constructor(private dataHandlerService: DataHandlerService) { }

  @Input() character: string;
  accessoriesList: Array<IGear>;

  ngOnInit(): void {
    this.populateAccessoriesList(this.character);
  }

  populateAccessoriesList(char: string) {
    this.dataHandlerService.getAccessories(char).subscribe((response: Array<IGear>) => {
      this.accessoriesList = response;
    });
  }
}
