/*
 * read_sensor.c
 *
 *  Created on: Jan 31, 2024
 *      Author: NGHIA
 */
#include "main.h"



void read_sensor(void* param)
{
	sensor_t data;
	while(1)
	{
		  DHT11_Start();
		  Presence = DHT11_Check_Response();
		  Rh_byte1 = DHT11_Read ();
		  Rh_byte2 = DHT11_Read ();
		  Temp_byte1 = DHT11_Read ();
		  Temp_byte2 = DHT11_Read ();
		  SUM = DHT11_Read();

		  TEMP = Temp_byte1;
		  RH = Rh_byte1;

		  Temperature = (float) TEMP;
		  Humidity = (float) RH;

//		  Temperature = 60;
//		  Humidity = 60;

		  Transmit_Temp(Temperature);
		  Transmit_Rh(Humidity);

		  data.dh = Humidity;
		  data.temp = Temperature;

		  xQueueSend(q_sensor, &data, portMAX_DELAY);

		  vTaskDelay(pdMS_TO_TICKS(1000));
	}

}



void pwm_control(void* param)
{
	uint8_t mode = 'A';
	sensor_t data;
	while(1)
	{
		xQueueReceive(q_mode, &mode, pdMS_TO_TICKS(100));
		switch(mode)
		{
		case 'A':
			//Automatically control motor based on temp and dh
			xQueueReceive(q_sensor, &data, portMAX_DELAY);
			HAL_ADC_Stop_DMA(&hadc1);
			if(data.temp<=50 && data.dh<=50)
			{
				TIM2->CCR1 = 50;
			}else if(data.temp>50 && data.dh>50)
			{
				TIM2->CCR1 = 100;
			}
			break;
		case 'M':
			HAL_ADC_Start_DMA(&hadc1, (uint32_t*) &ADC_Data, 1);
			break;
		}
	}
}
