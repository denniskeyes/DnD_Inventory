import { Component, Input, OnInit } from '@angular/core';
import { IGear } from '../interfaces/IGear';
import { DataHandlerService } from '../services/data-handler.service';

@Component({
  selector: 'app-armor',
  templateUrl: './armor.component.html',
  styleUrls: ['./armor.component.scss']
})
export class ArmorComponent implements OnInit {

  constructor(private dataHandlerService: DataHandlerService) { }

  @Input() character: string;
  armorList: Array<IGear>;

  ngOnInit(): void {
    this.populateArmorList(this.character);
  }

  populateArmorList(char: string) {
    this.dataHandlerService.getArmor(char).subscribe((response: Array<IGear>) => {
      this.armorList = response;
    });
  }

}
