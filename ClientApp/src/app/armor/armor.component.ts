import { Component, Input, OnInit } from '@angular/core';
import { DataHandlerService } from '../services/data-handler.service';

@Component({
  selector: 'app-armor',
  templateUrl: './armor.component.html',
  styleUrls: ['./armor.component.scss']
})
export class ArmorComponent implements OnInit {

  constructor(private dataHandlerService: DataHandlerService) { }

  @Input() character: string;
  armorList: any;

  ngOnInit(): void {
    this.populateArmorList(this.character);
  }

  populateArmorList(char: string) {
    this.dataHandlerService.getArmor(char).subscribe((response: any) => {
      this.armorList = response;
    });
  }

}
