using UnityEngine;
using System.Collections;
public class phone_Transform_localPosition : MonoBehaviour {
Vector3[] animVar;
float deltaTime;
float startTime;
void Start(){
startTime = Time.time;
deltaTime = 1f/60f;
animVar = new Vector3[560];
animVar[0] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[1] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[2] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[3] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[4] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[5] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[6] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[7] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[8] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[9] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[10] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[11] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[12] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[13] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[14] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[15] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[16] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[17] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[18] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[19] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[20] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[21] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[22] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[23] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[24] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[25] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[26] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[27] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[28] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[29] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[30] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[31] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[32] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[33] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[34] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[35] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[36] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[37] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[38] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[39] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[40] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[41] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[42] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[43] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[44] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[45] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[46] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[47] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[48] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[49] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[50] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[51] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[52] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[53] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[54] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[55] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[56] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[57] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[58] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[59] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[60] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[61] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[62] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[63] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[64] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[65] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[66] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[67] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[68] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[69] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[70] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[71] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[72] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[73] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[74] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[75] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[76] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[77] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[78] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[79] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[80] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[81] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[82] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[83] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[84] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[85] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[86] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[87] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[88] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[89] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[90] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[91] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[92] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[93] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[94] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[95] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[96] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[97] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[98] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[99] = new Vector3(0.872000f,0.000000f,0.000000f);
animVar[100] = new Vector3(0.871999f,0.000000f,0.000000f);
animVar[101] = new Vector3(0.871147f,0.000000f,0.000000f);
animVar[102] = new Vector3(0.868791f,0.000000f,0.000000f);
animVar[103] = new Vector3(0.865022f,0.000000f,0.000000f);
animVar[104] = new Vector3(0.859930f,0.000000f,0.000000f);
animVar[105] = new Vector3(0.853607f,0.000000f,0.000000f);
animVar[106] = new Vector3(0.846144f,0.000000f,0.000000f);
animVar[107] = new Vector3(0.837631f,0.000000f,0.000000f);
animVar[108] = new Vector3(0.828158f,0.000000f,0.000000f);
animVar[109] = new Vector3(0.817818f,0.000000f,0.000000f);
animVar[110] = new Vector3(0.806701f,0.000000f,0.000000f);
animVar[111] = new Vector3(0.794897f,0.000000f,0.000000f);
animVar[112] = new Vector3(0.782498f,0.000000f,0.000000f);
animVar[113] = new Vector3(0.769595f,0.000000f,0.000000f);
animVar[114] = new Vector3(0.756278f,0.000000f,0.000000f);
animVar[115] = new Vector3(0.742638f,0.000000f,0.000000f);
animVar[116] = new Vector3(0.728767f,0.000000f,0.000000f);
animVar[117] = new Vector3(0.714754f,0.000000f,0.000000f);
animVar[118] = new Vector3(0.700692f,0.000000f,0.000000f);
animVar[119] = new Vector3(0.686670f,0.000000f,0.000000f);
animVar[120] = new Vector3(0.672779f,0.000000f,0.000000f);
animVar[121] = new Vector3(0.659112f,0.000000f,0.000000f);
animVar[122] = new Vector3(0.645757f,0.000000f,0.000000f);
animVar[123] = new Vector3(0.632807f,0.000000f,0.000000f);
animVar[124] = new Vector3(0.620352f,0.000000f,0.000000f);
animVar[125] = new Vector3(0.608483f,0.000000f,0.000000f);
animVar[126] = new Vector3(0.597291f,0.000000f,0.000000f);
animVar[127] = new Vector3(0.586867f,0.000000f,0.000000f);
animVar[128] = new Vector3(0.577301f,0.000000f,0.000000f);
animVar[129] = new Vector3(0.568685f,0.000000f,0.000000f);
animVar[130] = new Vector3(0.561109f,0.000000f,0.000000f);
animVar[131] = new Vector3(0.554665f,0.000000f,0.000000f);
animVar[132] = new Vector3(0.549443f,0.000000f,0.000000f);
animVar[133] = new Vector3(0.545533f,0.000000f,0.000000f);
animVar[134] = new Vector3(0.543028f,0.000000f,0.000000f);
animVar[135] = new Vector3(0.542017f,0.000000f,0.000000f);
animVar[136] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[137] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[138] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[139] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[140] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[141] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[142] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[143] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[144] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[145] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[146] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[147] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[148] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[149] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[150] = new Vector3(0.542000f,0.000000f,0.000000f);
animVar[151] = new Vector3(0.541934f,0.000000f,0.000000f);
animVar[152] = new Vector3(0.541035f,0.000000f,0.000000f);
animVar[153] = new Vector3(0.539116f,0.000000f,0.000000f);
animVar[154] = new Vector3(0.536217f,0.000000f,0.000000f);
animVar[155] = new Vector3(0.532377f,0.000000f,0.000000f);
animVar[156] = new Vector3(0.527636f,0.000000f,0.000000f);
animVar[157] = new Vector3(0.522034f,0.000000f,0.000000f);
animVar[158] = new Vector3(0.515610f,0.000000f,0.000000f);
animVar[159] = new Vector3(0.508405f,0.000000f,0.000000f);
animVar[160] = new Vector3(0.500458f,0.000000f,0.000000f);
animVar[161] = new Vector3(0.491808f,0.000000f,0.000000f);
animVar[162] = new Vector3(0.482496f,0.000000f,0.000000f);
animVar[163] = new Vector3(0.472561f,0.000000f,0.000000f);
animVar[164] = new Vector3(0.462043f,0.000000f,0.000000f);
animVar[165] = new Vector3(0.450982f,0.000000f,0.000000f);
animVar[166] = new Vector3(0.439417f,0.000000f,0.000000f);
animVar[167] = new Vector3(0.427388f,0.000000f,0.000000f);
animVar[168] = new Vector3(0.414935f,0.000000f,0.000000f);
animVar[169] = new Vector3(0.402097f,0.000000f,0.000000f);
animVar[170] = new Vector3(0.388915f,0.000000f,0.000000f);
animVar[171] = new Vector3(0.375427f,0.000000f,0.000000f);
animVar[172] = new Vector3(0.361675f,0.000000f,0.000000f);
animVar[173] = new Vector3(0.347696f,0.000000f,0.000000f);
animVar[174] = new Vector3(0.333532f,0.000000f,0.000000f);
animVar[175] = new Vector3(0.319222f,0.000000f,0.000000f);
animVar[176] = new Vector3(0.304805f,0.000000f,0.000000f);
animVar[177] = new Vector3(0.290322f,0.000000f,0.000000f);
animVar[178] = new Vector3(0.275811f,0.000000f,0.000000f);
animVar[179] = new Vector3(0.261314f,0.000000f,0.000000f);
animVar[180] = new Vector3(0.246869f,0.000000f,0.000000f);
animVar[181] = new Vector3(0.232516f,0.000000f,0.000000f);
animVar[182] = new Vector3(0.218295f,0.000000f,0.000000f);
animVar[183] = new Vector3(0.204246f,0.000000f,0.000000f);
animVar[184] = new Vector3(0.190408f,0.000000f,0.000000f);
animVar[185] = new Vector3(0.176821f,0.000000f,0.000000f);
animVar[186] = new Vector3(0.163525f,0.000000f,0.000000f);
animVar[187] = new Vector3(0.150560f,0.000000f,0.000000f);
animVar[188] = new Vector3(0.137965f,0.000000f,0.000000f);
animVar[189] = new Vector3(0.125780f,0.000000f,0.000000f);
animVar[190] = new Vector3(0.114044f,0.000000f,0.000000f);
animVar[191] = new Vector3(0.102799f,0.000000f,0.000000f);
animVar[192] = new Vector3(0.092082f,0.000000f,0.000000f);
animVar[193] = new Vector3(0.081934f,0.000000f,0.000000f);
animVar[194] = new Vector3(0.072395f,0.000000f,0.000000f);
animVar[195] = new Vector3(0.063504f,0.000000f,0.000000f);
animVar[196] = new Vector3(0.055302f,0.000000f,0.000000f);
animVar[197] = new Vector3(0.047827f,0.000000f,0.000000f);
animVar[198] = new Vector3(0.041120f,0.000000f,0.000000f);
animVar[199] = new Vector3(0.035220f,0.000000f,0.000000f);
animVar[200] = new Vector3(0.030166f,0.000000f,0.000000f);
animVar[201] = new Vector3(0.026000f,0.000000f,0.000000f);
animVar[202] = new Vector3(0.022434f,0.000000f,0.000000f);
animVar[203] = new Vector3(0.019151f,0.000000f,0.000000f);
animVar[204] = new Vector3(0.016141f,0.000000f,0.000000f);
animVar[205] = new Vector3(0.013395f,0.000000f,0.000000f);
animVar[206] = new Vector3(0.010904f,0.000000f,0.000000f);
animVar[207] = new Vector3(0.008660f,0.000000f,0.000000f);
animVar[208] = new Vector3(0.006654f,0.000000f,0.000000f);
animVar[209] = new Vector3(0.004876f,0.000000f,0.000000f);
animVar[210] = new Vector3(0.003317f,0.000000f,0.000000f);
animVar[211] = new Vector3(0.001969f,0.000000f,0.000000f);
animVar[212] = new Vector3(0.000823f,0.000000f,0.000000f);
animVar[213] = new Vector3(-0.000130f,0.000000f,0.000000f);
animVar[214] = new Vector3(-0.000900f,0.000000f,0.000000f);
animVar[215] = new Vector3(-0.001495f,0.000000f,0.000000f);
animVar[216] = new Vector3(-0.001924f,0.000000f,0.000000f);
animVar[217] = new Vector3(-0.002196f,0.000000f,0.000000f);
animVar[218] = new Vector3(-0.002320f,0.000000f,0.000000f);
animVar[219] = new Vector3(-0.002305f,0.000000f,0.000000f);
animVar[220] = new Vector3(-0.002160f,0.000000f,0.000000f);
animVar[221] = new Vector3(-0.001894f,0.000000f,0.000000f);
animVar[222] = new Vector3(-0.001516f,0.000000f,0.000000f);
animVar[223] = new Vector3(-0.001035f,0.000000f,0.000000f);
animVar[224] = new Vector3(-0.000459f,0.000000f,0.000000f);
animVar[225] = new Vector3(0.000202f,0.000000f,0.000000f);
animVar[226] = new Vector3(0.000939f,0.000000f,0.000000f);
animVar[227] = new Vector3(0.001744f,0.000000f,0.000000f);
animVar[228] = new Vector3(0.002607f,0.000000f,0.000000f);
animVar[229] = new Vector3(0.003519f,0.000000f,0.000000f);
animVar[230] = new Vector3(0.004472f,0.000000f,0.000000f);
animVar[231] = new Vector3(0.005457f,0.000000f,0.000000f);
animVar[232] = new Vector3(0.006464f,0.000000f,0.000000f);
animVar[233] = new Vector3(0.007486f,0.000000f,0.000000f);
animVar[234] = new Vector3(0.008511f,0.000000f,0.000000f);
animVar[235] = new Vector3(0.009533f,0.000000f,0.000000f);
animVar[236] = new Vector3(0.010541f,0.000000f,0.000000f);
animVar[237] = new Vector3(0.011528f,0.000000f,0.000000f);
animVar[238] = new Vector3(0.012483f,0.000000f,0.000000f);
animVar[239] = new Vector3(0.013398f,0.000000f,0.000000f);
animVar[240] = new Vector3(0.014264f,0.000000f,0.000000f);
animVar[241] = new Vector3(0.015072f,0.000000f,0.000000f);
animVar[242] = new Vector3(0.015814f,0.000000f,0.000000f);
animVar[243] = new Vector3(0.016479f,0.000000f,0.000000f);
animVar[244] = new Vector3(0.017060f,0.000000f,0.000000f);
animVar[245] = new Vector3(0.017547f,0.000000f,0.000000f);
animVar[246] = new Vector3(0.017932f,0.000000f,0.000000f);
animVar[247] = new Vector3(0.018204f,0.000000f,0.000000f);
animVar[248] = new Vector3(0.018357f,0.000000f,0.000000f);
animVar[249] = new Vector3(0.018379f,0.000000f,0.000000f);
animVar[250] = new Vector3(0.018263f,0.000000f,0.000000f);
animVar[251] = new Vector3(0.018000f,0.000000f,0.000000f);
animVar[252] = new Vector3(0.017624f,0.000000f,0.000000f);
animVar[253] = new Vector3(0.017182f,0.000000f,0.000000f);
animVar[254] = new Vector3(0.016681f,0.000000f,0.000000f);
animVar[255] = new Vector3(0.016127f,0.000000f,0.000000f);
animVar[256] = new Vector3(0.015528f,0.000000f,0.000000f);
animVar[257] = new Vector3(0.014891f,0.000000f,0.000000f);
animVar[258] = new Vector3(0.014223f,0.000000f,0.000000f);
animVar[259] = new Vector3(0.013531f,0.000000f,0.000000f);
animVar[260] = new Vector3(0.012822f,0.000000f,0.000000f);
animVar[261] = new Vector3(0.012104f,0.000000f,0.000000f);
animVar[262] = new Vector3(0.011383f,0.000000f,0.000000f);
animVar[263] = new Vector3(0.010667f,0.000000f,0.000000f);
animVar[264] = new Vector3(0.009962f,0.000000f,0.000000f);
animVar[265] = new Vector3(0.009276f,0.000000f,0.000000f);
animVar[266] = new Vector3(0.008616f,0.000000f,0.000000f);
animVar[267] = new Vector3(0.007989f,0.000000f,0.000000f);
animVar[268] = new Vector3(0.007402f,0.000000f,0.000000f);
animVar[269] = new Vector3(0.006862f,0.000000f,0.000000f);
animVar[270] = new Vector3(0.006376f,0.000000f,0.000000f);
animVar[271] = new Vector3(0.005952f,0.000000f,0.000000f);
animVar[272] = new Vector3(0.005596f,0.000000f,0.000000f);
animVar[273] = new Vector3(0.005316f,0.000000f,0.000000f);
animVar[274] = new Vector3(0.005119f,0.000000f,0.000000f);
animVar[275] = new Vector3(0.005011f,0.000000f,0.000000f);
animVar[276] = new Vector3(0.005000f,0.000000f,0.000000f);
animVar[277] = new Vector3(0.005074f,0.000000f,0.000000f);
animVar[278] = new Vector3(0.005214f,0.000000f,0.000000f);
animVar[279] = new Vector3(0.005417f,0.000000f,0.000000f);
animVar[280] = new Vector3(0.005681f,0.000000f,0.000000f);
animVar[281] = new Vector3(0.006002f,0.000000f,0.000000f);
animVar[282] = new Vector3(0.006378f,0.000000f,0.000000f);
animVar[283] = new Vector3(0.006806f,0.000000f,0.000000f);
animVar[284] = new Vector3(0.007284f,0.000000f,0.000000f);
animVar[285] = new Vector3(0.007808f,0.000000f,0.000000f);
animVar[286] = new Vector3(0.008376f,0.000000f,0.000000f);
animVar[287] = new Vector3(0.008985f,0.000000f,0.000000f);
animVar[288] = new Vector3(0.009632f,0.000000f,0.000000f);
animVar[289] = new Vector3(0.010314f,0.000000f,0.000000f);
animVar[290] = new Vector3(0.011029f,0.000000f,0.000000f);
animVar[291] = new Vector3(0.011774f,0.000000f,0.000000f);
animVar[292] = new Vector3(0.012546f,0.000000f,0.000000f);
animVar[293] = new Vector3(0.013342f,0.000000f,0.000000f);
animVar[294] = new Vector3(0.014160f,0.000000f,0.000000f);
animVar[295] = new Vector3(0.014996f,0.000000f,0.000000f);
animVar[296] = new Vector3(0.015848f,0.000000f,0.000000f);
animVar[297] = new Vector3(0.016713f,0.000000f,0.000000f);
animVar[298] = new Vector3(0.017589f,0.000000f,0.000000f);
animVar[299] = new Vector3(0.018472f,0.000000f,0.000000f);
animVar[300] = new Vector3(0.019360f,0.000000f,0.000000f);
animVar[301] = new Vector3(0.020250f,0.000000f,0.000000f);
animVar[302] = new Vector3(0.021139f,0.000000f,0.000000f);
animVar[303] = new Vector3(0.022025f,0.000000f,0.000000f);
animVar[304] = new Vector3(0.022904f,0.000000f,0.000000f);
animVar[305] = new Vector3(0.023774f,0.000000f,0.000000f);
animVar[306] = new Vector3(0.024632f,0.000000f,0.000000f);
animVar[307] = new Vector3(0.025475f,0.000000f,0.000000f);
animVar[308] = new Vector3(0.026301f,0.000000f,0.000000f);
animVar[309] = new Vector3(0.027107f,0.000000f,0.000000f);
animVar[310] = new Vector3(0.027889f,0.000000f,0.000000f);
animVar[311] = new Vector3(0.028646f,0.000000f,0.000000f);
animVar[312] = new Vector3(0.029374f,0.000000f,0.000000f);
animVar[313] = new Vector3(0.030071f,0.000000f,0.000000f);
animVar[314] = new Vector3(0.030733f,0.000000f,0.000000f);
animVar[315] = new Vector3(0.031358f,0.000000f,0.000000f);
animVar[316] = new Vector3(0.031944f,0.000000f,0.000000f);
animVar[317] = new Vector3(0.032487f,0.000000f,0.000000f);
animVar[318] = new Vector3(0.032985f,0.000000f,0.000000f);
animVar[319] = new Vector3(0.033434f,0.000000f,0.000000f);
animVar[320] = new Vector3(0.033833f,0.000000f,0.000000f);
animVar[321] = new Vector3(0.034178f,0.000000f,0.000000f);
animVar[322] = new Vector3(0.034467f,0.000000f,0.000000f);
animVar[323] = new Vector3(0.034696f,0.000000f,0.000000f);
animVar[324] = new Vector3(0.034863f,0.000000f,0.000000f);
animVar[325] = new Vector3(0.034965f,0.000000f,0.000000f);
animVar[326] = new Vector3(0.035000f,0.000000f,0.000000f);
animVar[327] = new Vector3(0.034941f,0.000000f,0.000000f);
animVar[328] = new Vector3(0.034772f,0.000000f,0.000000f);
animVar[329] = new Vector3(0.034499f,0.000000f,0.000000f);
animVar[330] = new Vector3(0.034132f,0.000000f,0.000000f);
animVar[331] = new Vector3(0.033680f,0.000000f,0.000000f);
animVar[332] = new Vector3(0.033151f,0.000000f,0.000000f);
animVar[333] = new Vector3(0.032554f,0.000000f,0.000000f);
animVar[334] = new Vector3(0.031897f,0.000000f,0.000000f);
animVar[335] = new Vector3(0.031190f,0.000000f,0.000000f);
animVar[336] = new Vector3(0.030440f,0.000000f,0.000000f);
animVar[337] = new Vector3(0.029657f,0.000000f,0.000000f);
animVar[338] = new Vector3(0.028848f,0.000000f,0.000000f);
animVar[339] = new Vector3(0.028024f,0.000000f,0.000000f);
animVar[340] = new Vector3(0.027191f,0.000000f,0.000000f);
animVar[341] = new Vector3(0.026360f,0.000000f,0.000000f);
animVar[342] = new Vector3(0.025538f,0.000000f,0.000000f);
animVar[343] = new Vector3(0.024735f,0.000000f,0.000000f);
animVar[344] = new Vector3(0.023958f,0.000000f,0.000000f);
animVar[345] = new Vector3(0.023217f,0.000000f,0.000000f);
animVar[346] = new Vector3(0.022520f,0.000000f,0.000000f);
animVar[347] = new Vector3(0.021876f,0.000000f,0.000000f);
animVar[348] = new Vector3(0.021293f,0.000000f,0.000000f);
animVar[349] = new Vector3(0.020780f,0.000000f,0.000000f);
animVar[350] = new Vector3(0.020347f,0.000000f,0.000000f);
animVar[351] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[352] = new Vector3(0.019720f,0.000000f,0.000000f);
animVar[353] = new Vector3(0.019480f,0.000000f,0.000000f);
animVar[354] = new Vector3(0.019277f,0.000000f,0.000000f);
animVar[355] = new Vector3(0.019109f,0.000000f,0.000000f);
animVar[356] = new Vector3(0.018973f,0.000000f,0.000000f);
animVar[357] = new Vector3(0.018869f,0.000000f,0.000000f);
animVar[358] = new Vector3(0.018793f,0.000000f,0.000000f);
animVar[359] = new Vector3(0.018743f,0.000000f,0.000000f);
animVar[360] = new Vector3(0.018718f,0.000000f,0.000000f);
animVar[361] = new Vector3(0.018715f,0.000000f,0.000000f);
animVar[362] = new Vector3(0.018732f,0.000000f,0.000000f);
animVar[363] = new Vector3(0.018766f,0.000000f,0.000000f);
animVar[364] = new Vector3(0.018816f,0.000000f,0.000000f);
animVar[365] = new Vector3(0.018880f,0.000000f,0.000000f);
animVar[366] = new Vector3(0.018955f,0.000000f,0.000000f);
animVar[367] = new Vector3(0.019040f,0.000000f,0.000000f);
animVar[368] = new Vector3(0.019131f,0.000000f,0.000000f);
animVar[369] = new Vector3(0.019228f,0.000000f,0.000000f);
animVar[370] = new Vector3(0.019327f,0.000000f,0.000000f);
animVar[371] = new Vector3(0.019427f,0.000000f,0.000000f);
animVar[372] = new Vector3(0.019525f,0.000000f,0.000000f);
animVar[373] = new Vector3(0.019620f,0.000000f,0.000000f);
animVar[374] = new Vector3(0.019709f,0.000000f,0.000000f);
animVar[375] = new Vector3(0.019790f,0.000000f,0.000000f);
animVar[376] = new Vector3(0.019861f,0.000000f,0.000000f);
animVar[377] = new Vector3(0.019919f,0.000000f,0.000000f);
animVar[378] = new Vector3(0.019963f,0.000000f,0.000000f);
animVar[379] = new Vector3(0.019991f,0.000000f,0.000000f);
animVar[380] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[381] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[382] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[383] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[384] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[385] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[386] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[387] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[388] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[389] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[390] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[391] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[392] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[393] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[394] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[395] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[396] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[397] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[398] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[399] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[400] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[401] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[402] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[403] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[404] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[405] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[406] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[407] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[408] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[409] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[410] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[411] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[412] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[413] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[414] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[415] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[416] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[417] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[418] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[419] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[420] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[421] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[422] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[423] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[424] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[425] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[426] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[427] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[428] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[429] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[430] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[431] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[432] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[433] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[434] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[435] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[436] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[437] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[438] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[439] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[440] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[441] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[442] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[443] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[444] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[445] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[446] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[447] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[448] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[449] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[450] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[451] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[452] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[453] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[454] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[455] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[456] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[457] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[458] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[459] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[460] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[461] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[462] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[463] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[464] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[465] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[466] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[467] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[468] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[469] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[470] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[471] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[472] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[473] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[474] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[475] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[476] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[477] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[478] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[479] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[480] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[481] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[482] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[483] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[484] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[485] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[486] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[487] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[488] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[489] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[490] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[491] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[492] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[493] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[494] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[495] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[496] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[497] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[498] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[499] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[500] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[501] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[502] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[503] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[504] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[505] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[506] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[507] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[508] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[509] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[510] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[511] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[512] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[513] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[514] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[515] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[516] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[517] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[518] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[519] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[520] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[521] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[522] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[523] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[524] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[525] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[526] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[527] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[528] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[529] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[530] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[531] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[532] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[533] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[534] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[535] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[536] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[537] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[538] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[539] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[540] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[541] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[542] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[543] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[544] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[545] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[546] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[547] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[548] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[549] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[550] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[551] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[552] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[553] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[554] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[555] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[556] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[557] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[558] = new Vector3(0.020000f,0.000000f,0.000000f);
animVar[559] = new Vector3(0.020000f,0.000000f,0.000000f);
comp = gameObject.GetComponent<Transform>();
}
Transform comp;
public float numFrame;
void Update () {
numFrame = (Time.time-startTime)/deltaTime;
if( numFrame>=(float)animVar.Length-1 ) {numFrame=(float)animVar.Length-1.01f;}
float alpha = numFrame-Mathf.Floor(numFrame)/deltaTime;
comp.localPosition = Vector3.Lerp(animVar[Mathf.FloorToInt(numFrame)],animVar[Mathf.CeilToInt(numFrame)],alpha);
}
}
