//Maya ASCII 2019 scene
//Name: TutorialLevel.ma
//Last modified: Fri, Apr 26, 2019 05:24:45 PM
//Codeset: 1252
requires maya "2019";
requires "mtoa" "3.1.2";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2019";
fileInfo "version" "2019";
fileInfo "cutIdentifier" "201812112215-434d8d9c04";
fileInfo "osv" "Microsoft Windows 10 Technical Preview  (Build 17134)\n";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "B5200AA1-41FD-A0C6-EB5C-FCB7EBCF3CB8";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 21.990019552730999 41.59350400825388 35.676334490097233 ;
	setAttr ".r" -type "double3" -45.938352729613811 393.39999999982888 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "89FF0942-4CA4-D018-C5BB-7091C2964884";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 54.430783654295205;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
	setAttr ".ai_translator" -type "string" "perspective";
createNode transform -s -n "top";
	rename -uid "F729E36A-488D-1F0F-F2F0-DBB47A9E3400";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -0.44188771679583505 1000.1 -0.19786017169962733 ;
	setAttr ".r" -type "double3" -90 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "CEA7D3CF-4605-D573-3549-7CAAE23CE783";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 44.768725461094213;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "front";
	rename -uid "39D69C86-4ACC-A0FD-D023-85A4AF32C3F5";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "F4E0BAF4-4D15-174D-B9AD-738108623236";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -s -n "side";
	rename -uid "85EF75C4-4463-506C-309F-5194506A8D27";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 90 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "591F13D3-4F4B-E7CC-D849-488C5E5705EE";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
	setAttr ".ai_translator" -type "string" "orthographic";
createNode transform -n "pPlane1";
	rename -uid "C347FEE9-4F48-42DD-90E5-969CA5263E3A";
createNode mesh -n "pPlaneShape1" -p "pPlane1";
	rename -uid "218E132C-4184-3D04-F91E-24995026ACDE";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode transform -n "pPlane3";
	rename -uid "C9BED19F-45D7-8BED-75CA-C1A0B9FFFC68";
	setAttr ".s" -type "double3" 23.76904889364744 1 23.76904889364744 ;
createNode mesh -n "pPlaneShape3" -p "pPlane3";
	rename -uid "74D48627-4B16-1306-1900-2F84A0AD690D";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.35000002384185791 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 158 ".pt";
	setAttr ".pt[24]" -type "float3" 0 -3.7252903e-09 0 ;
	setAttr ".pt[25]" -type "float3" 0 3.7252903e-09 9.3132257e-10 ;
	setAttr ".pt[26]" -type "float3" 0 1.8626451e-08 1.1175871e-08 ;
	setAttr ".pt[27]" -type "float3" 0 1.4901161e-08 0 ;
	setAttr ".pt[28]" -type "float3" 0 0 9.3132257e-10 ;
	setAttr ".pt[35]" -type "float3" 0 -5.9604645e-08 -6.9849193e-10 ;
	setAttr ".pt[36]" -type "float3" 0 -1.0430813e-07 9.3132257e-09 ;
	setAttr ".pt[37]" -type "float3" 0 -4.4703484e-08 0 ;
	setAttr ".pt[38]" -type "float3" 0 1.8626451e-08 0 ;
	setAttr ".pt[39]" -type "float3" 0 -2.9802322e-08 -1.8626451e-09 ;
	setAttr ".pt[46]" -type "float3" 0 -5.9604645e-08 0 ;
	setAttr ".pt[47]" -type "float3" 0 -1.0430813e-07 0 ;
	setAttr ".pt[48]" -type "float3" 0 -4.4703484e-08 7.4505806e-09 ;
	setAttr ".pt[49]" -type "float3" 0 1.8626451e-08 7.4505806e-09 ;
	setAttr ".pt[50]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[57]" -type "float3" 0 5.5879354e-09 0 ;
	setAttr ".pt[58]" -type "float3" 0 3.7252903e-09 0 ;
	setAttr ".pt[59]" -type "float3" -0.0010546622 -5.2154064e-08 0.0015423994 ;
	setAttr ".pt[60]" -type "float3" -0.00063658139 -7.4505806e-08 0.00093097502 ;
	setAttr ".pt[61]" -type "float3" 3.4924597e-10 2.2351742e-08 -1.3969839e-09 ;
	setAttr ".pt[68]" -type "float3" -0.00028538017 0 0.00041735609 ;
	setAttr ".pt[69]" -type "float3" -0.0003062168 2.910383e-10 0.0055437554 ;
	setAttr ".pt[70]" -type "float3" 0.010140549 0 0.028717961 ;
	setAttr ".pt[71]" -type "float3" 0.012888574 -2.9802322e-08 0.024699103 ;
	setAttr ".pt[72]" -type "float3" 0.0014289041 -5.9604645e-08 0.0028067783 ;
	setAttr ".pt[73]" -type "float3" 2.3283064e-10 -7.4505806e-09 -2.7939677e-09 ;
	setAttr ".pt[79]" -type "float3" 0.00012044972 0 0.0017614223 ;
	setAttr ".pt[80]" -type "float3" 0.0038391193 6.9849193e-10 0.013372092 ;
	setAttr ".pt[81]" -type "float3" 0.022299794 -8.9406967e-08 0.051171936 ;
	setAttr ".pt[82]" -type "float3" 0.02743803 2.3841858e-07 0.043657485 ;
	setAttr ".pt[83]" -type "float3" 0.0066767032 -2.9802322e-08 0.0087944241 ;
	setAttr ".pt[84]" -type "float3" -2.3283064e-10 1.4901161e-08 9.3132257e-10 ;
	setAttr ".pt[91]" -type "float3" 0.0016702374 0 0.0026532754 ;
	setAttr ".pt[92]" -type "float3" 0.012858431 1.4901161e-08 0.024743177 ;
	setAttr ".pt[93]" -type "float3" 0.014847252 -8.9406967e-08 0.021834604 ;
	setAttr ".pt[94]" -type "float3" 0.0019541003 0 0.0020387077 ;
	setAttr ".pt[95]" -type "float3" 0 9.3132257e-09 2.3283064e-10 ;
	setAttr ".pt[104]" -type "float3" 3.6379788e-12 -2.3283064e-10 1.1641532e-10 ;
	setAttr ".pt[141]" -type "float3" 0 0 -1.1641532e-10 ;
	setAttr ".pt[171]" -type "float3" 0 -1.8626451e-08 -1.1641532e-10 ;
	setAttr ".pt[172]" -type "float3" 0 0 4.6566129e-10 ;
	setAttr ".pt[174]" -type "float3" 0 3.7252903e-09 1.8626451e-09 ;
	setAttr ".pt[175]" -type "float3" 0 2.3283064e-10 0 ;
	setAttr ".pt[177]" -type "float3" 0 3.1664968e-08 0 ;
	setAttr ".pt[178]" -type "float3" 0 0 -9.3132257e-10 ;
	setAttr ".pt[180]" -type "float3" 0 1.4901161e-08 1.8626451e-09 ;
	setAttr ".pt[197]" -type "float3" 0 2.0954758e-09 0 ;
	setAttr ".pt[198]" -type "float3" 0 -7.4505806e-09 -3.4924597e-10 ;
	setAttr ".pt[199]" -type "float3" 0 -9.3132257e-09 0 ;
	setAttr ".pt[200]" -type "float3" 0 -3.7252903e-08 -4.6566129e-10 ;
	setAttr ".pt[201]" -type "float3" 0 7.4505806e-09 -9.3132257e-10 ;
	setAttr ".pt[202]" -type "float3" 0 4.4703484e-08 -9.3132257e-10 ;
	setAttr ".pt[203]" -type "float3" 0 1.4901161e-08 -7.4505806e-09 ;
	setAttr ".pt[204]" -type "float3" 0 -5.2154064e-08 2.2351742e-08 ;
	setAttr ".pt[205]" -type "float3" 0 4.4703484e-08 0 ;
	setAttr ".pt[206]" -type "float3" 0 -9.6857548e-08 3.7252903e-08 ;
	setAttr ".pt[207]" -type "float3" 0 -5.7742e-08 2.2351742e-08 ;
	setAttr ".pt[208]" -type "float3" 0 -2.9057264e-07 -1.4901161e-08 ;
	setAttr ".pt[209]" -type "float3" 0 2.9802322e-08 7.4505806e-09 ;
	setAttr ".pt[210]" -type "float3" 0 0 1.8626451e-09 ;
	setAttr ".pt[211]" -type "float3" 0 -5.9750164e-08 -1.4901161e-08 ;
	setAttr ".pt[214]" -type "float3" 0 1.8626451e-09 2.3283064e-10 ;
	setAttr ".pt[228]" -type "float3" 0 -3.7252903e-09 0 ;
	setAttr ".pt[229]" -type "float3" 0 -4.4703484e-08 0 ;
	setAttr ".pt[230]" -type "float3" 0 1.3038516e-08 0 ;
	setAttr ".pt[231]" -type "float3" 0 1.6391277e-07 4.6566129e-10 ;
	setAttr ".pt[232]" -type "float3" 0 5.9604645e-08 -1.8626451e-09 ;
	setAttr ".pt[233]" -type "float3" 0 0 -1.1641532e-10 ;
	setAttr ".pt[234]" -type "float3" 0 2.9802322e-07 -3.7252903e-09 ;
	setAttr ".pt[235]" -type "float3" 0 -1.7881393e-07 0 ;
	setAttr ".pt[236]" -type "float3" 0 4.4703484e-08 -1.8626451e-09 ;
	setAttr ".pt[237]" -type "float3" 0 2.0861626e-07 0 ;
	setAttr ".pt[238]" -type "float3" 0 -2.5704503e-07 0 ;
	setAttr ".pt[239]" -type "float3" 0 -2.9057264e-07 -7.4505806e-09 ;
	setAttr ".pt[240]" -type "float3" 0 1.1990778e-07 -3.7252903e-09 ;
	setAttr ".pt[241]" -type "float3" 0 8.9406967e-08 0 ;
	setAttr ".pt[242]" -type "float3" 0 -5.9750164e-08 0 ;
	setAttr ".pt[243]" -type "float3" 0 1.8626451e-09 0 ;
	setAttr ".pt[245]" -type "float3" 0 -4.6566129e-09 0 ;
	setAttr ".pt[259]" -type "float3" 0 9.3132257e-10 0 ;
	setAttr ".pt[260]" -type "float3" 0 -1.8626451e-08 0 ;
	setAttr ".pt[262]" -type "float3" 0 -2.9802322e-08 0 ;
	setAttr ".pt[263]" -type "float3" 0 7.4505806e-09 0 ;
	setAttr ".pt[264]" -type "float3" 0 -9.3132257e-09 0 ;
	setAttr ".pt[265]" -type "float3" 0 1.0430813e-07 -9.3132257e-10 ;
	setAttr ".pt[266]" -type "float3" 0 -5.2154064e-08 0 ;
	setAttr ".pt[267]" -type "float3" -0.00040250266 -3.7252903e-09 0.00058864261 ;
	setAttr ".pt[268]" -type "float3" 0 -5.9604645e-08 0 ;
	setAttr ".pt[269]" -type "float3" 3.2741809e-11 -5.7742e-08 0 ;
	setAttr ".pt[270]" -type "float3" -0.0009370601 -6.6123903e-08 0.0019473596 ;
	setAttr ".pt[271]" -type "float3" 3.2741809e-11 2.9802322e-08 -4.6566129e-10 ;
	setAttr ".pt[272]" -type "float3" -1.8189894e-12 0 7.2759576e-12 ;
	setAttr ".pt[273]" -type "float3" -4.3304281e-05 -1.4901161e-08 6.3333173e-05 ;
	setAttr ".pt[276]" -type "float3" 1.4551915e-10 7.4505806e-09 1.1641532e-09 ;
	setAttr ".pt[293]" -type "float3" -0.00015929609 0 0.00023296365 ;
	setAttr ".pt[294]" -type "float3" -0.00074315409 -5.8207661e-11 0.0010868306 ;
	setAttr ".pt[295]" -type "float3" -0.00077569252 0 0.0020596418 ;
	setAttr ".pt[296]" -type "float3" -0.00067741028 -8.1490725e-09 0.005887182 ;
	setAttr ".pt[297]" -type "float3" 0.0015622963 1.9790605e-08 0.01169214 ;
	setAttr ".pt[298]" -type "float3" 0.0038592457 2.2351742e-08 0.018030701 ;
	setAttr ".pt[299]" -type "float3" 0.0033782765 3.7252903e-09 0.013397071 ;
	setAttr ".pt[300]" -type "float3" 0.0028352884 -8.7544322e-08 0.0098304376 ;
	setAttr ".pt[301]" -type "float3" 0.014319466 -8.9406967e-08 0.031112887 ;
	setAttr ".pt[302]" -type "float3" 0.00077295792 -8.9406967e-08 0.0036978826 ;
	setAttr ".pt[303]" -type "float3" -4.3305212e-05 0 6.3327585e-05 ;
	setAttr ".pt[304]" -type "float3" 0.0070275194 -2.9802322e-08 0.013232887 ;
	setAttr ".pt[305]" -type "float3" -2.3283064e-10 -7.4505806e-09 9.3132257e-10 ;
	setAttr ".pt[306]" -type "float3" 1.4551915e-10 7.4505806e-09 1.1641532e-09 ;
	setAttr ".pt[307]" -type "float3" 4.6566129e-10 2.9802322e-08 1.8626451e-09 ;
	setAttr ".pt[322]" -type "float3" -0.00040409103 0 0.001333699 ;
	setAttr ".pt[324]" -type "float3" 0.00012090313 0 0.0047196839 ;
	setAttr ".pt[325]" -type "float3" 0.0021118796 6.9849193e-10 0.011442648 ;
	setAttr ".pt[326]" -type "float3" 0.0015622732 0 0.0065089781 ;
	setAttr ".pt[327]" -type "float3" 0.0092919786 0 0.029906141 ;
	setAttr ".pt[328]" -type "float3" 0.018871672 -8.9406967e-08 0.044511776 ;
	setAttr ".pt[329]" -type "float3" 0.012108155 7.4505806e-09 0.034756768 ;
	setAttr ".pt[330]" -type "float3" 0.025126752 -2.9802322e-08 0.047037657 ;
	setAttr ".pt[331]" -type "float3" 0.023235211 2.3841858e-07 0.038130302 ;
	setAttr ".pt[332]" -type "float3" 0.029230032 -2.9802322e-08 0.053894188 ;
	setAttr ".pt[333]" -type "float3" 0.014473344 2.3841858e-07 0.022506775 ;
	setAttr ".pt[334]" -type "float3" 0.0048133293 -2.9802322e-08 0.0071259141 ;
	setAttr ".pt[335]" -type "float3" 0.017870294 2.3841858e-07 0.026060339 ;
	setAttr ".pt[336]" -type "float3" 0.00029641186 -1.1920929e-07 0.0003092619 ;
	setAttr ".pt[337]" -type "float3" 5.8207661e-10 1.4901161e-08 -9.3132257e-10 ;
	setAttr ".pt[338]" -type "float3" 0.000723759 -1.1920929e-07 0.00075509085 ;
	setAttr ".pt[353]" -type "float3" 8.8325483e-05 0 0.00034594903 ;
	setAttr ".pt[355]" -type "float3" 0.0012374046 0 0.0030186574 ;
	setAttr ".pt[356]" -type "float3" 0.0036236031 2.910383e-10 0.0092318179 ;
	setAttr ".pt[357]" -type "float3" 0.0002669605 0 0.00031305276 ;
	setAttr ".pt[358]" -type "float3" 0.010795544 -7.4505806e-09 0.027467258 ;
	setAttr ".pt[359]" -type "float3" 0.019419862 0 0.043710072 ;
	setAttr ".pt[360]" -type "float3" 0.0069988733 -5.5879354e-09 0.013439119 ;
	setAttr ".pt[361]" -type "float3" 0.025126744 -8.9406967e-08 0.047037642 ;
	setAttr ".pt[362]" -type "float3" 0.023610031 -2.9802322e-08 0.037582148 ;
	setAttr ".pt[363]" -type "float3" 0.016363811 0 0.02812312 ;
	setAttr ".pt[364]" -type "float3" 0.015283439 -2.9802322e-08 0.021322068 ;
	setAttr ".pt[365]" -type "float3" 0.0053751161 -5.9604645e-08 0.0063043265 ;
	setAttr ".pt[366]" -type "float3" 0.008729727 -8.9406967e-08 0.010743466 ;
	setAttr ".pt[367]" -type "float3" 0.00014413522 -2.9802322e-08 0.00015037696 ;
	setAttr ".pt[368]" -type "float3" 3.4924597e-10 2.2351742e-08 7.4505806e-09 ;
	setAttr ".pt[369]" -type "float3" 1.8626451e-09 1.4901161e-08 4.6566129e-09 ;
	setAttr ".pt[389]" -type "float3" 0.0018492293 0 0.0020755844 ;
	setAttr ".pt[390]" -type "float3" 0.0048584593 -1.8626451e-09 0.0062517603 ;
	setAttr ".pt[392]" -type "float3" 0.0063956082 3.7252903e-09 0.0080393525 ;
	setAttr ".pt[393]" -type "float3" 0.0051977802 2.2351742e-08 0.0058340989 ;
	setAttr ".pt[394]" -type "float3" 9.9603654e-05 0 0.00010391636 ;
	setAttr ".pt[395]" -type "float3" 0.0018060786 2.2351742e-08 0.0018842809 ;
	setAttr ".pt[396]" -type "float3" 0 -3.7252903e-08 -2.7939677e-09 ;
	setAttr ".pt[397]" -type "float3" 3.6379788e-12 -2.3283064e-10 1.1641532e-10 ;
	setAttr ".pt[398]" -type "float3" -2.910383e-10 7.4505806e-09 1.3969839e-09 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode mesh -n "polySurfaceShape1" -p "pPlane3";
	rename -uid "0DBF9BAE-4D79-EBF1-66DD-DF80259F379F";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 121 ".uvst[0].uvsp[0:120]" -type "float2" 0 0 0.1 0 0.2 0 0.30000001
		 0 0.40000001 0 0.5 0 0.60000002 0 0.69999999 0 0.80000001 0 0.90000004 0 1 0 0 0.1
		 0.1 0.1 0.2 0.1 0.30000001 0.1 0.40000001 0.1 0.5 0.1 0.60000002 0.1 0.69999999 0.1
		 0.80000001 0.1 0.90000004 0.1 1 0.1 0 0.2 0.1 0.2 0.2 0.2 0.30000001 0.2 0.40000001
		 0.2 0.5 0.2 0.60000002 0.2 0.69999999 0.2 0.80000001 0.2 0.90000004 0.2 1 0.2 0 0.30000001
		 0.1 0.30000001 0.2 0.30000001 0.30000001 0.30000001 0.40000001 0.30000001 0.5 0.30000001
		 0.60000002 0.30000001 0.69999999 0.30000001 0.80000001 0.30000001 0.90000004 0.30000001
		 1 0.30000001 0 0.40000001 0.1 0.40000001 0.2 0.40000001 0.30000001 0.40000001 0.40000001
		 0.40000001 0.5 0.40000001 0.60000002 0.40000001 0.69999999 0.40000001 0.80000001
		 0.40000001 0.90000004 0.40000001 1 0.40000001 0 0.5 0.1 0.5 0.2 0.5 0.30000001 0.5
		 0.40000001 0.5 0.5 0.5 0.60000002 0.5 0.69999999 0.5 0.80000001 0.5 0.90000004 0.5
		 1 0.5 0 0.60000002 0.1 0.60000002 0.2 0.60000002 0.30000001 0.60000002 0.40000001
		 0.60000002 0.5 0.60000002 0.60000002 0.60000002 0.69999999 0.60000002 0.80000001
		 0.60000002 0.90000004 0.60000002 1 0.60000002 0 0.69999999 0.1 0.69999999 0.2 0.69999999
		 0.30000001 0.69999999 0.40000001 0.69999999 0.5 0.69999999 0.60000002 0.69999999
		 0.69999999 0.69999999 0.80000001 0.69999999 0.90000004 0.69999999 1 0.69999999 0
		 0.80000001 0.1 0.80000001 0.2 0.80000001 0.30000001 0.80000001 0.40000001 0.80000001
		 0.5 0.80000001 0.60000002 0.80000001 0.69999999 0.80000001 0.80000001 0.80000001
		 0.90000004 0.80000001 1 0.80000001 0 0.90000004 0.1 0.90000004 0.2 0.90000004 0.30000001
		 0.90000004 0.40000001 0.90000004 0.5 0.90000004 0.60000002 0.90000004 0.69999999
		 0.90000004 0.80000001 0.90000004 0.90000004 0.90000004 1 0.90000004 0 1 0.1 1 0.2
		 1 0.30000001 1 0.40000001 1 0.5 1 0.60000002 1 0.69999999 1 0.80000001 1 0.90000004
		 1 1 1;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 120 ".pt";
	setAttr ".pt[0]" -type "float3" -0.038264308 2.2114611 0 ;
	setAttr ".pt[1]" -type "float3" 0.038264342 2.2731121 0 ;
	setAttr ".pt[2]" -type "float3" 0.061831295 3.0810812 0 ;
	setAttr ".pt[3]" -type "float3" 0.0011421907 2.4012151 0 ;
	setAttr ".pt[4]" -type "float3" -2.910383e-11 2.0515151 -1.1641532e-10 ;
	setAttr ".pt[5]" -type "float3" 0 2.2097032 0 ;
	setAttr ".pt[6]" -type "float3" -0.00039138432 2.0956035 0 ;
	setAttr ".pt[7]" -type "float3" -0.021751916 2.8871846 0 ;
	setAttr ".pt[8]" -type "float3" -0.018753087 4.1199136 0 ;
	setAttr ".pt[9]" -type "float3" 3.8343222e-09 3.0521283 0 ;
	setAttr ".pt[10]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr ".pt[11]" -type "float3" -0.038264379 2.205776 0 ;
	setAttr ".pt[12]" -type "float3" 0.038264345 1.2481352 0 ;
	setAttr ".pt[13]" -type "float3" 0.061831325 2.0042441 0 ;
	setAttr ".pt[14]" -type "float3" 0.0011421936 1.2931459 -9.3132257e-09 ;
	setAttr ".pt[15]" -type "float3" 2.3283064e-09 0.96115124 -1.1175871e-08 ;
	setAttr ".pt[16]" -type "float3" -3.4924597e-09 1.1538981 -9.3132257e-09 ;
	setAttr ".pt[17]" -type "float3" -0.00039138432 1.0890005 0 ;
	setAttr ".pt[18]" -type "float3" -0.021751916 3.1280074 0 ;
	setAttr ".pt[19]" -type "float3" -0.018753087 5.7003407 0 ;
	setAttr ".pt[20]" -type "float3" 3.8343222e-09 5.2772131 0 ;
	setAttr ".pt[21]" -type "float3" 0.018753102 2.9068258 0 ;
	setAttr ".pt[22]" -type "float3" -0.038264308 2.0972888 0 ;
	setAttr ".pt[23]" -type "float3" 0.038264342 0.38372552 0 ;
	setAttr ".pt[24]" -type "float3" 0.061831295 0.62196195 0 ;
	setAttr ".pt[25]" -type "float3" 0.0011421648 -0.026296921 0 ;
	setAttr ".pt[26]" -type "float3" 0 -7.1525574e-07 0 ;
	setAttr ".pt[27]" -type "float3" 0 0.0094898865 0 ;
	setAttr ".pt[28]" -type "float3" -0.00039138432 0.018935725 0 ;
	setAttr ".pt[29]" -type "float3" -0.021751916 1.8953379 0 ;
	setAttr ".pt[30]" -type "float3" -0.018753087 5.5472884 0 ;
	setAttr ".pt[31]" -type "float3" 3.8343222e-09 6.8875394 0 ;
	setAttr ".pt[32]" -type "float3" 0.018753102 3.7404239 0 ;
	setAttr ".pt[33]" -type "float3" -0.038264368 2.2211518 0 ;
	setAttr ".pt[34]" -type "float3" 0.038264345 1.2269831 0 ;
	setAttr ".pt[35]" -type "float3" 0.061831325 0.98643494 0 ;
	setAttr ".pt[36]" -type "float3" 0.001142194 0.013202623 1.1175871e-08 ;
	setAttr ".pt[37]" -type "float3" 1.3969839e-09 1.1920929e-07 3.7252903e-09 ;
	setAttr ".pt[38]" -type "float3" -3.4924597e-09 -1.7881393e-07 1.1175871e-08 ;
	setAttr ".pt[39]" -type "float3" -0.00039138432 0.015506877 0 ;
	setAttr ".pt[40]" -type "float3" -0.021751916 1.3990802 0 ;
	setAttr ".pt[41]" -type "float3" -0.018753087 4.1949816 0 ;
	setAttr ".pt[42]" -type "float3" 3.8343222e-09 6.9174752 0 ;
	setAttr ".pt[43]" -type "float3" 0.018753102 4.1640377 0 ;
	setAttr ".pt[44]" -type "float3" -0.038264368 3.5986903 0 ;
	setAttr ".pt[45]" -type "float3" 0.038264345 2.2085609 0 ;
	setAttr ".pt[46]" -type "float3" 0.061831325 1.1911659 0 ;
	setAttr ".pt[47]" -type "float3" 0.0011421907 0.013202292 0 ;
	setAttr ".pt[48]" -type "float3" -2.9103844e-11 -3.7252903e-09 -3.4924597e-10 ;
	setAttr ".pt[50]" -type "float3" -0.00039138432 0.015506877 0 ;
	setAttr ".pt[51]" -type "float3" -0.021751916 1.6423534 0 ;
	setAttr ".pt[52]" -type "float3" -0.018753087 4.7087955 0 ;
	setAttr ".pt[53]" -type "float3" 3.8343222e-09 6.3723965 0 ;
	setAttr ".pt[54]" -type "float3" 0.018753102 4.0001078 0 ;
	setAttr ".pt[55]" -type "float3" -0.038264368 4.7869239 0 ;
	setAttr ".pt[56]" -type "float3" 0.038264345 2.365205 0 ;
	setAttr ".pt[57]" -type "float3" 0.061831325 1.1911659 0 ;
	setAttr ".pt[58]" -type "float3" 0.0011421907 0.013202502 0 ;
	setAttr ".pt[59]" -type "float3" 0 1.1920929e-07 0 ;
	setAttr ".pt[60]" -type "float3" 0 5.9604645e-08 0 ;
	setAttr ".pt[61]" -type "float3" -0.00039138432 0.015506877 0 ;
	setAttr ".pt[62]" -type "float3" -0.021751916 1.9881433 0 ;
	setAttr ".pt[63]" -type "float3" -0.018753087 4.3067393 0 ;
	setAttr ".pt[64]" -type "float3" 3.8343222e-09 4.6289902 0 ;
	setAttr ".pt[65]" -type "float3" 0.018753102 3.0367467 0 ;
	setAttr ".pt[66]" -type "float3" -0.038264368 3.5986903 0 ;
	setAttr ".pt[67]" -type "float3" 0.038264345 1.5613906 0 ;
	setAttr ".pt[68]" -type "float3" 0.061831325 1.0543104 0 ;
	setAttr ".pt[69]" -type "float3" 0.0011421907 0.013202562 0 ;
	setAttr ".pt[71]" -type "float3" 0 1.1920929e-07 0 ;
	setAttr ".pt[72]" -type "float3" -0.00039138432 0.015506875 0 ;
	setAttr ".pt[73]" -type "float3" -0.021751916 1.6423534 0 ;
	setAttr ".pt[74]" -type "float3" -0.018753087 3.340488 0 ;
	setAttr ".pt[75]" -type "float3" 3.8343222e-09 2.8328147 0 ;
	setAttr ".pt[76]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr ".pt[77]" -type "float3" -0.038264368 2.1505232 0 ;
	setAttr ".pt[78]" -type "float3" 0.038264345 0.98969096 1.2732926e-09 ;
	setAttr ".pt[79]" -type "float3" 0.061831325 0.80845702 0 ;
	setAttr ".pt[80]" -type "float3" 0.0011421907 -0.022650389 0 ;
	setAttr ".pt[81]" -type "float3" 0 1.1920929e-07 0 ;
	setAttr ".pt[82]" -type "float3" 0 5.9604645e-08 0 ;
	setAttr ".pt[83]" -type "float3" -0.00039138432 0.015506877 0 ;
	setAttr ".pt[84]" -type "float3" -0.021751916 1.5984366 0 ;
	setAttr ".pt[85]" -type "float3" -0.018753087 3.2112939 0 ;
	setAttr ".pt[86]" -type "float3" 3.8343222e-09 2.777364 0 ;
	setAttr ".pt[87]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr ".pt[88]" -type "float3" -0.038264368 2.2076607 8.6147338e-08 ;
	setAttr ".pt[89]" -type "float3" 0.03826423 1.5533799 6.0535967e-08 ;
	setAttr ".pt[90]" -type "float3" 0.061831325 1.0551074 8.6147338e-08 ;
	setAttr ".pt[91]" -type "float3" 0.0011421907 0.022826869 0 ;
	setAttr ".pt[92]" -type "float3" 0 0.0096244477 0 ;
	setAttr ".pt[93]" -type "float3" 0 0.0096244495 0 ;
	setAttr ".pt[94]" -type "float3" -0.00039138432 0.025131293 0 ;
	setAttr ".pt[95]" -type "float3" -0.021751916 1.8818027 0 ;
	setAttr ".pt[96]" -type "float3" -0.018753087 3.7218685 0 ;
	setAttr ".pt[97]" -type "float3" 3.8343222e-09 3.0464728 0 ;
	setAttr ".pt[98]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr ".pt[99]" -type "float3" -0.038264383 2.2114608 6.0535967e-08 ;
	setAttr ".pt[100]" -type "float3" 0.038264405 2.1221151 -3.7811697e-07 ;
	setAttr ".pt[101]" -type "float3" 0.061831266 1.6918592 6.0535967e-08 ;
	setAttr ".pt[102]" -type "float3" 0.0011421907 0.85262787 1.2732926e-09 ;
	setAttr ".pt[103]" -type "float3" 0 0.9307273 0 ;
	setAttr ".pt[104]" -type "float3" 0 0.86835021 0 ;
	setAttr ".pt[105]" -type "float3" -0.00039138432 0.88385707 0 ;
	setAttr ".pt[106]" -type "float3" -0.021751916 2.0365498 0 ;
	setAttr ".pt[107]" -type "float3" -0.018753087 3.2031014 0 ;
	setAttr ".pt[108]" -type "float3" 3.8343222e-09 2.777364 0 ;
	setAttr ".pt[109]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr ".pt[110]" -type "float3" -0.038264379 2.2114611 8.6147338e-08 ;
	setAttr ".pt[111]" -type "float3" 0.03826417 2.068342 6.0535967e-08 ;
	setAttr ".pt[112]" -type "float3" 0.061831325 2.155664 8.6147338e-08 ;
	setAttr ".pt[113]" -type "float3" 0.0011421902 1.4541705 0 ;
	setAttr ".pt[114]" -type "float3" 0 1.6647247 0 ;
	setAttr ".pt[115]" -type "float3" 0 1.6147282 0 ;
	setAttr ".pt[116]" -type "float3" -0.00039138432 1.6276441 0 ;
	setAttr ".pt[117]" -type "float3" -0.021751916 2.2933292 0 ;
	setAttr ".pt[118]" -type "float3" -0.018753087 2.6041791 0 ;
	setAttr ".pt[119]" -type "float3" 3.8343222e-09 2.5974662 0 ;
	setAttr ".pt[120]" -type "float3" 0.018753102 2.5974662 0 ;
	setAttr -s 121 ".vt[0:120]"  -0.5 0 0.5 -0.40000001 0 0.5 -0.30000001 0 0.5
		 -0.19999999 0 0.5 -0.099999994 0 0.5 0 0 0.5 0.10000002 0 0.5 0.19999999 0 0.5 0.30000001 0 0.5
		 0.40000004 0 0.5 0.5 0 0.5 -0.5 0 0.40000001 -0.40000001 0 0.40000001 -0.30000001 0 0.40000001
		 -0.19999999 0 0.40000001 -0.099999994 0 0.40000001 0 0 0.40000001 0.10000002 0 0.40000001
		 0.19999999 0 0.40000001 0.30000001 0 0.40000001 0.40000004 0 0.40000001 0.5 0 0.40000001
		 -0.5 0 0.30000001 -0.40000001 0 0.30000001 -0.30000001 0 0.30000001 -0.19999999 0 0.30000001
		 -0.099999994 0 0.30000001 0 0 0.30000001 0.10000002 0 0.30000001 0.19999999 0 0.30000001
		 0.30000001 0 0.30000001 0.40000004 0 0.30000001 0.5 0 0.30000001 -0.5 0 0.19999999
		 -0.40000001 0 0.19999999 -0.30000001 0 0.19999999 -0.19999999 0 0.19999999 -0.099999994 0 0.19999999
		 0 0 0.19999999 0.10000002 0 0.19999999 0.19999999 0 0.19999999 0.30000001 0 0.19999999
		 0.40000004 0 0.19999999 0.5 0 0.19999999 -0.5 0 0.099999994 -0.40000001 0 0.099999994
		 -0.30000001 0 0.099999994 -0.19999999 0 0.099999994 -0.099999994 0 0.099999994 0 0 0.099999994
		 0.10000002 0 0.099999994 0.19999999 0 0.099999994 0.30000001 0 0.099999994 0.40000004 0 0.099999994
		 0.5 0 0.099999994 -0.5 0 0 -0.40000001 0 0 -0.30000001 0 0 -0.19999999 0 0 -0.099999994 0 0
		 0 0 0 0.10000002 0 0 0.19999999 0 0 0.30000001 0 0 0.40000004 0 0 0.5 0 0 -0.5 0 -0.10000002
		 -0.40000001 0 -0.10000002 -0.30000001 0 -0.10000002 -0.19999999 0 -0.10000002 -0.099999994 0 -0.10000002
		 0 0 -0.10000002 0.10000002 0 -0.10000002 0.19999999 0 -0.10000002 0.30000001 0 -0.10000002
		 0.40000004 0 -0.10000002 0.5 0 -0.10000002 -0.5 0 -0.19999999 -0.40000001 0 -0.19999999
		 -0.30000001 0 -0.19999999 -0.19999999 0 -0.19999999 -0.099999994 0 -0.19999999 0 0 -0.19999999
		 0.10000002 0 -0.19999999 0.19999999 0 -0.19999999 0.30000001 0 -0.19999999 0.40000004 0 -0.19999999
		 0.5 0 -0.19999999 -0.5 0 -0.30000001 -0.40000001 0 -0.30000001 -0.30000001 0 -0.30000001
		 -0.19999999 0 -0.30000001 -0.099999994 0 -0.30000001 0 0 -0.30000001 0.10000002 0 -0.30000001
		 0.19999999 0 -0.30000001 0.30000001 0 -0.30000001 0.40000004 0 -0.30000001 0.5 0 -0.30000001
		 -0.5 0 -0.40000004 -0.40000001 0 -0.40000004 -0.30000001 0 -0.40000004 -0.19999999 0 -0.40000004
		 -0.099999994 0 -0.40000004 0 0 -0.40000004 0.10000002 0 -0.40000004 0.19999999 0 -0.40000004
		 0.30000001 0 -0.40000004 0.40000004 0 -0.40000004 0.5 0 -0.40000004 -0.5 0 -0.5 -0.40000001 0 -0.5
		 -0.30000001 0 -0.5 -0.19999999 0 -0.5 -0.099999994 0 -0.5 0 0 -0.5 0.10000002 0 -0.5
		 0.19999999 0 -0.5 0.30000001 0 -0.5 0.40000004 0 -0.5 0.5 0 -0.5;
	setAttr -s 220 ".ed";
	setAttr ".ed[0:165]"  0 1 0 0 11 0 1 2 0 1 12 1 2 3 0 2 13 1 3 4 0 3 14 1
		 4 5 0 4 15 1 5 6 0 5 16 1 6 7 0 6 17 1 7 8 0 7 18 1 8 9 0 8 19 1 9 10 0 9 20 1 10 21 0
		 11 12 1 11 22 0 12 13 1 12 23 1 13 14 1 13 24 1 14 15 1 14 25 1 15 16 1 15 26 1 16 17 1
		 16 27 1 17 18 1 17 28 1 18 19 1 18 29 1 19 20 1 19 30 1 20 21 1 20 31 1 21 32 0 22 23 1
		 22 33 0 23 24 1 23 34 1 24 25 1 24 35 1 25 26 1 25 36 1 26 27 1 26 37 1 27 28 1 27 38 1
		 28 29 1 28 39 1 29 30 1 29 40 1 30 31 1 30 41 1 31 32 1 31 42 1 32 43 0 33 34 1 33 44 0
		 34 35 1 34 45 1 35 36 1 35 46 1 36 37 1 36 47 1 37 38 1 37 48 1 38 39 1 38 49 1 39 40 1
		 39 50 1 40 41 1 40 51 1 41 42 1 41 52 1 42 43 1 42 53 1 43 54 0 44 45 1 44 55 0 45 46 1
		 45 56 1 46 47 1 46 57 1 47 48 1 47 58 1 48 49 1 48 59 1 49 50 1 49 60 1 50 51 1 50 61 1
		 51 52 1 51 62 1 52 53 1 52 63 1 53 54 1 53 64 1 54 65 0 55 56 1 55 66 0 56 57 1 56 67 1
		 57 58 1 57 68 1 58 59 1 58 69 1 59 60 1 59 70 1 60 61 1 60 71 1 61 62 1 61 72 1 62 63 1
		 62 73 1 63 64 1 63 74 1 64 65 1 64 75 1 65 76 0 66 67 1 66 77 0 67 68 1 67 78 1 68 69 1
		 68 79 1 69 70 1 69 80 1 70 71 1 70 81 1 71 72 1 71 82 1 72 73 1 72 83 1 73 74 1 73 84 1
		 74 75 1 74 85 1 75 76 1 75 86 1 76 87 0 77 78 1 77 88 0 78 79 1 78 89 1 79 80 1 79 90 1
		 80 81 1 80 91 1 81 82 1 81 92 1 82 83 1 82 93 1 83 84 1 83 94 1 84 85 1 84 95 1 85 86 1
		 85 96 1 86 87 1;
	setAttr ".ed[166:219]" 86 97 1 87 98 0 88 89 1 88 99 0 89 90 1 89 100 1 90 91 1
		 90 101 1 91 92 1 91 102 1 92 93 1 92 103 1 93 94 1 93 104 1 94 95 1 94 105 1 95 96 1
		 95 106 1 96 97 1 96 107 1 97 98 1 97 108 1 98 109 0 99 100 1 99 110 0 100 101 1 100 111 1
		 101 102 1 101 112 1 102 103 1 102 113 1 103 104 1 103 114 1 104 105 1 104 115 1 105 106 1
		 105 116 1 106 107 1 106 117 1 107 108 1 107 118 1 108 109 1 108 119 1 109 120 0 110 111 0
		 111 112 0 112 113 0 113 114 0 114 115 0 115 116 0 116 117 0 117 118 0 118 119 0 119 120 0;
	setAttr -s 100 -ch 400 ".fc[0:99]" -type "polyFaces" 
		f 4 0 3 -22 -2
		mu 0 4 0 1 12 11
		f 4 2 5 -24 -4
		mu 0 4 1 2 13 12
		f 4 4 7 -26 -6
		mu 0 4 2 3 14 13
		f 4 6 9 -28 -8
		mu 0 4 3 4 15 14
		f 4 8 11 -30 -10
		mu 0 4 4 5 16 15
		f 4 10 13 -32 -12
		mu 0 4 5 6 17 16
		f 4 12 15 -34 -14
		mu 0 4 6 7 18 17
		f 4 14 17 -36 -16
		mu 0 4 7 8 19 18
		f 4 16 19 -38 -18
		mu 0 4 8 9 20 19
		f 4 18 20 -40 -20
		mu 0 4 9 10 21 20
		f 4 21 24 -43 -23
		mu 0 4 11 12 23 22
		f 4 23 26 -45 -25
		mu 0 4 12 13 24 23
		f 4 25 28 -47 -27
		mu 0 4 13 14 25 24
		f 4 27 30 -49 -29
		mu 0 4 14 15 26 25
		f 4 29 32 -51 -31
		mu 0 4 15 16 27 26
		f 4 31 34 -53 -33
		mu 0 4 16 17 28 27
		f 4 33 36 -55 -35
		mu 0 4 17 18 29 28
		f 4 35 38 -57 -37
		mu 0 4 18 19 30 29
		f 4 37 40 -59 -39
		mu 0 4 19 20 31 30
		f 4 39 41 -61 -41
		mu 0 4 20 21 32 31
		f 4 42 45 -64 -44
		mu 0 4 22 23 34 33
		f 4 44 47 -66 -46
		mu 0 4 23 24 35 34
		f 4 46 49 -68 -48
		mu 0 4 24 25 36 35
		f 4 48 51 -70 -50
		mu 0 4 25 26 37 36
		f 4 50 53 -72 -52
		mu 0 4 26 27 38 37
		f 4 52 55 -74 -54
		mu 0 4 27 28 39 38
		f 4 54 57 -76 -56
		mu 0 4 28 29 40 39
		f 4 56 59 -78 -58
		mu 0 4 29 30 41 40
		f 4 58 61 -80 -60
		mu 0 4 30 31 42 41
		f 4 60 62 -82 -62
		mu 0 4 31 32 43 42
		f 4 63 66 -85 -65
		mu 0 4 33 34 45 44
		f 4 65 68 -87 -67
		mu 0 4 34 35 46 45
		f 4 67 70 -89 -69
		mu 0 4 35 36 47 46
		f 4 69 72 -91 -71
		mu 0 4 36 37 48 47
		f 4 71 74 -93 -73
		mu 0 4 37 38 49 48
		f 4 73 76 -95 -75
		mu 0 4 38 39 50 49
		f 4 75 78 -97 -77
		mu 0 4 39 40 51 50
		f 4 77 80 -99 -79
		mu 0 4 40 41 52 51
		f 4 79 82 -101 -81
		mu 0 4 41 42 53 52
		f 4 81 83 -103 -83
		mu 0 4 42 43 54 53
		f 4 84 87 -106 -86
		mu 0 4 44 45 56 55
		f 4 86 89 -108 -88
		mu 0 4 45 46 57 56
		f 4 88 91 -110 -90
		mu 0 4 46 47 58 57
		f 4 90 93 -112 -92
		mu 0 4 47 48 59 58
		f 4 92 95 -114 -94
		mu 0 4 48 49 60 59
		f 4 94 97 -116 -96
		mu 0 4 49 50 61 60
		f 4 96 99 -118 -98
		mu 0 4 50 51 62 61
		f 4 98 101 -120 -100
		mu 0 4 51 52 63 62
		f 4 100 103 -122 -102
		mu 0 4 52 53 64 63
		f 4 102 104 -124 -104
		mu 0 4 53 54 65 64
		f 4 105 108 -127 -107
		mu 0 4 55 56 67 66
		f 4 107 110 -129 -109
		mu 0 4 56 57 68 67
		f 4 109 112 -131 -111
		mu 0 4 57 58 69 68
		f 4 111 114 -133 -113
		mu 0 4 58 59 70 69
		f 4 113 116 -135 -115
		mu 0 4 59 60 71 70
		f 4 115 118 -137 -117
		mu 0 4 60 61 72 71
		f 4 117 120 -139 -119
		mu 0 4 61 62 73 72
		f 4 119 122 -141 -121
		mu 0 4 62 63 74 73
		f 4 121 124 -143 -123
		mu 0 4 63 64 75 74
		f 4 123 125 -145 -125
		mu 0 4 64 65 76 75
		f 4 126 129 -148 -128
		mu 0 4 66 67 78 77
		f 4 128 131 -150 -130
		mu 0 4 67 68 79 78
		f 4 130 133 -152 -132
		mu 0 4 68 69 80 79
		f 4 132 135 -154 -134
		mu 0 4 69 70 81 80
		f 4 134 137 -156 -136
		mu 0 4 70 71 82 81
		f 4 136 139 -158 -138
		mu 0 4 71 72 83 82
		f 4 138 141 -160 -140
		mu 0 4 72 73 84 83
		f 4 140 143 -162 -142
		mu 0 4 73 74 85 84
		f 4 142 145 -164 -144
		mu 0 4 74 75 86 85
		f 4 144 146 -166 -146
		mu 0 4 75 76 87 86
		f 4 147 150 -169 -149
		mu 0 4 77 78 89 88
		f 4 149 152 -171 -151
		mu 0 4 78 79 90 89
		f 4 151 154 -173 -153
		mu 0 4 79 80 91 90
		f 4 153 156 -175 -155
		mu 0 4 80 81 92 91
		f 4 155 158 -177 -157
		mu 0 4 81 82 93 92
		f 4 157 160 -179 -159
		mu 0 4 82 83 94 93
		f 4 159 162 -181 -161
		mu 0 4 83 84 95 94
		f 4 161 164 -183 -163
		mu 0 4 84 85 96 95
		f 4 163 166 -185 -165
		mu 0 4 85 86 97 96
		f 4 165 167 -187 -167
		mu 0 4 86 87 98 97
		f 4 168 171 -190 -170
		mu 0 4 88 89 100 99
		f 4 170 173 -192 -172
		mu 0 4 89 90 101 100
		f 4 172 175 -194 -174
		mu 0 4 90 91 102 101
		f 4 174 177 -196 -176
		mu 0 4 91 92 103 102
		f 4 176 179 -198 -178
		mu 0 4 92 93 104 103
		f 4 178 181 -200 -180
		mu 0 4 93 94 105 104
		f 4 180 183 -202 -182
		mu 0 4 94 95 106 105
		f 4 182 185 -204 -184
		mu 0 4 95 96 107 106
		f 4 184 187 -206 -186
		mu 0 4 96 97 108 107
		f 4 186 188 -208 -188
		mu 0 4 97 98 109 108
		f 4 189 192 -211 -191
		mu 0 4 99 100 111 110
		f 4 191 194 -212 -193
		mu 0 4 100 101 112 111
		f 4 193 196 -213 -195
		mu 0 4 101 102 113 112
		f 4 195 198 -214 -197
		mu 0 4 102 103 114 113
		f 4 197 200 -215 -199
		mu 0 4 103 104 115 114
		f 4 199 202 -216 -201
		mu 0 4 104 105 116 115
		f 4 201 204 -217 -203
		mu 0 4 105 106 117 116
		f 4 203 206 -218 -205
		mu 0 4 106 107 118 117
		f 4 205 208 -219 -207
		mu 0 4 107 108 119 118
		f 4 207 209 -220 -209
		mu 0 4 108 109 120 119;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".ai_translator" -type "string" "polymesh";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "800465E2-4B9E-C75D-06EF-FA886CEB5060";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "D2BA2BE7-466B-7AF2-099A-10A455F1AF7A";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "4E7545D2-43ED-C46A-E1FB-318A4335AE28";
createNode displayLayerManager -n "layerManager";
	rename -uid "FDA367CB-4354-F96A-3048-53AFD56B5645";
createNode displayLayer -n "defaultLayer";
	rename -uid "12AC9BB9-49EF-3792-F61A-6E99F7BC0984";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "6D382F4D-4D97-86CE-E772-46B19C999C66";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "CED67490-45B7-9092-3E6B-B8840137CEEE";
	setAttr ".g" yes;
createNode polyPlane -n "polyPlane1";
	rename -uid "AD89EC75-400A-3B59-87E1-ABBE54BDFC27";
	setAttr ".cuv" 2;
createNode polySubdFace -n "polySubdFace1";
	rename -uid "BB85ACAD-4B58-0140-B0A5-A59BBD722B46";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polyTweak -n "polyTweak1";
	rename -uid "C4549425-4910-D403-825E-4CBEFC0E328C";
	setAttr ".uopa" yes;
	setAttr -s 214 ".tk";
	setAttr ".tk[0]" -type "float3" -0.022557646 3.5452833 -0.0061483993 ;
	setAttr ".tk[1]" -type "float3" -0.001033092 2.7269323 -0.00028158387 ;
	setAttr ".tk[2]" -type "float3" 0 2.5557902 0 ;
	setAttr ".tk[3]" -type "float3" 0 1.7045087 0 ;
	setAttr ".tk[4]" -type "float3" 0 0.01360875 0 ;
	setAttr ".tk[11]" -type "float3" -0.022557646 3.5452833 -0.0061483993 ;
	setAttr ".tk[12]" -type "float3" -0.00072678394 1.1392118 -0.00019809348 ;
	setAttr ".tk[13]" -type "float3" 0 1.2442696 0 ;
	setAttr ".tk[14]" -type "float3" 0 0.547526 0 ;
	setAttr ".tk[22]" -type "float3" -0.0049259965 2.3082914 -0.0013426413 ;
	setAttr ".tk[23]" -type "float3" 0 0.014123886 0 ;
	setAttr ".tk[33]" -type "float3" 0 1.6018833 0 ;
	setAttr ".tk[34]" -type "float3" 0 0.051154789 0 ;
	setAttr ".tk[44]" -type "float3" 0 0.2366291 0 ;
	setAttr ".tk[73]" -type "float3" 0 0.0090074213 0 ;
	setAttr ".tk[74]" -type "float3" 0 0.51551342 0 ;
	setAttr ".tk[75]" -type "float3" 0 0.52206725 0 ;
	setAttr ".tk[76]" -type "float3" 0 0.0020375976 0 ;
	setAttr ".tk[78]" -type "float3" 0 0.35423157 0 ;
	setAttr ".tk[79]" -type "float3" 0 0.015034825 0 ;
	setAttr ".tk[84]" -type "float3" 0 0.096827641 0 ;
	setAttr ".tk[85]" -type "float3" 0 1.0192156 0 ;
	setAttr ".tk[86]" -type "float3" 0 1.0192156 0 ;
	setAttr ".tk[87]" -type "float3" 0 0.067959122 0 ;
	setAttr ".tk[88]" -type "float3" 0 0.10147768 0 ;
	setAttr ".tk[89]" -type "float3" 0 1.8360919 0 ;
	setAttr ".tk[90]" -type "float3" 0 0.57491791 0 ;
	setAttr ".tk[91]" -type "float3" 0 0.065920748 0 ;
	setAttr ".tk[95]" -type "float3" 0 0.013668333 0 ;
	setAttr ".tk[96]" -type "float3" 0 0.48748863 0 ;
	setAttr ".tk[97]" -type "float3" 0 0.52370858 0 ;
	setAttr ".tk[98]" -type "float3" 0 0.026177276 0 ;
	setAttr ".tk[99]" -type "float3" 0 1.948686 0 ;
	setAttr ".tk[100]" -type "float3" 0 1.8360919 0 ;
	setAttr ".tk[101]" -type "float3" 0 0.6303938 0 ;
	setAttr ".tk[102]" -type "float3" 0 0.14266548 0 ;
	setAttr ".tk[106]" -type "float3" 0 0.042518687 0 ;
	setAttr ".tk[107]" -type "float3" 0 1.1182648 0 ;
	setAttr ".tk[108]" -type "float3" 0 1.729812 0 ;
	setAttr ".tk[109]" -type "float3" 0 2.1779623 0 ;
	setAttr ".tk[110]" -type "float3" 0 3.4704826 0 ;
	setAttr ".tk[111]" -type "float3" 0 0.61395347 0 ;
	setAttr ".tk[112]" -type "float3" 0 0.0286886 0 ;
	setAttr ".tk[117]" -type "float3" 0 0.31505975 0 ;
	setAttr ".tk[118]" -type "float3" 0 2.2156172 0 ;
	setAttr ".tk[119]" -type "float3" 0 3.4218719 0 ;
	setAttr ".tk[120]" -type "float3" 0 4.0434957 0 ;
	setAttr ".tk[121]" -type "float3" -0.0089528477 2.1552038 -0.0024402188 ;
	setAttr ".tk[122]" -type "float3" -0.013733281 2.3313127 -0.0037431936 ;
	setAttr ".tk[123]" -type "float3" -0.0015322434 2.3257194 -0.0004176315 ;
	setAttr ".tk[124]" -type "float3" -0.013346146 2.2199683 -0.0036376691 ;
	setAttr ".tk[125]" -type "float3" -0.026019325 4.0893397 -0.0070919674 ;
	setAttr ".tk[126]" -type "float3" 0 2.7470646 0 ;
	setAttr ".tk[127]" -type "float3" 0 3.2434149 0 ;
	setAttr ".tk[128]" -type "float3" 0 2.2244148 0 ;
	setAttr ".tk[129]" -type "float3" 0 1.5210371 0 ;
	setAttr ".tk[130]" -type "float3" 0 1.7922177 0 ;
	setAttr ".tk[131]" -type "float3" 0 2.1836905 0 ;
	setAttr ".tk[132]" -type "float3" 0 1.3115486 0 ;
	setAttr ".tk[133]" -type "float3" 0 0.90065616 0 ;
	setAttr ".tk[134]" -type "float3" 0 0.3781763 0 ;
	setAttr ".tk[135]" -type "float3" 0 0.58322996 0 ;
	setAttr ".tk[137]" -type "float3" 0 0.059793521 0 ;
	setAttr ".tk[162]" -type "float3" -0.0039024802 1.1325667 -0.0010636789 ;
	setAttr ".tk[163]" -type "float3" 0 0.16241285 0 ;
	setAttr ".tk[164]" -type "float3" -0.0014232342 1.1548513 -0.00038792193 ;
	setAttr ".tk[165]" -type "float3" -0.014009297 2.7481849 -0.0038184123 ;
	setAttr ".tk[166]" -type "float3" 0 0.50744283 0 ;
	setAttr ".tk[167]" -type "float3" 0 0.25789118 0 ;
	setAttr ".tk[169]" -type "float3" 0 0.1229951 0 ;
	setAttr ".tk[170]" -type "float3" 0 0.018326791 0 ;
	setAttr ".tk[193]" -type "float3" 0 0.83865362 0 ;
	setAttr ".tk[194]" -type "float3" 0 0.060669012 0 ;
	setAttr ".tk[195]" -type "float3" 0 0.94856828 0 ;
	setAttr ".tk[196]" -type "float3" -0.00015501287 1.8718847 -4.225074e-05 ;
	setAttr ".tk[224]" -type "float3" 0 0.55981731 0 ;
	setAttr ".tk[225]" -type "float3" 0 0.0042355801 0 ;
	setAttr ".tk[226]" -type "float3" 0 0.11426342 0 ;
	setAttr ".tk[227]" -type "float3" 0 0.93278718 0 ;
	setAttr ".tk[308]" -type "float3" 0 0.035073213 0 ;
	setAttr ".tk[309]" -type "float3" 0 0.13826609 0 ;
	setAttr ".tk[310]" -type "float3" 0 0.23233233 0 ;
	setAttr ".tk[311]" -type "float3" 0 0.22803965 0 ;
	setAttr ".tk[312]" -type "float3" 0 0.14287888 0 ;
	setAttr ".tk[313]" -type "float3" 0 0.67545915 0 ;
	setAttr ".tk[314]" -type "float3" 0 0.015794979 0 ;
	setAttr ".tk[316]" -type "float3" 0 0.19780619 0 ;
	setAttr ".tk[318]" -type "float3" 0 0.009553913 0 ;
	setAttr ".tk[319]" -type "float3" 0 0.15025888 0 ;
	setAttr ".tk[323]" -type "float3" 0 0.21650514 0 ;
	setAttr ".tk[337]" -type "float3" 0 0.065633349 0 ;
	setAttr ".tk[339]" -type "float3" 0 0.45836225 0 ;
	setAttr ".tk[340]" -type "float3" 0 0.87098539 0 ;
	setAttr ".tk[341]" -type "float3" 0 0.54878956 0 ;
	setAttr ".tk[342]" -type "float3" 0 1.0689651 0 ;
	setAttr ".tk[343]" -type "float3" 0 0.87522554 0 ;
	setAttr ".tk[344]" -type "float3" 0 1.2553331 0 ;
	setAttr ".tk[345]" -type "float3" 0 0.4030025 0 ;
	setAttr ".tk[346]" -type "float3" 0 0.041857708 0 ;
	setAttr ".tk[347]" -type "float3" 0 0.49487197 0 ;
	setAttr ".tk[348]" -type "float3" 0 0.65405661 0 ;
	setAttr ".tk[349]" -type "float3" 0 1.1058007 0 ;
	setAttr ".tk[350]" -type "float3" 0 1.1271445 0 ;
	setAttr ".tk[351]" -type "float3" 0 0.0057714023 0 ;
	setAttr ".tk[352]" -type "float3" 0 1.0369967 0 ;
	setAttr ".tk[353]" -type "float3" 0 0.25130588 0 ;
	setAttr ".tk[354]" -type "float3" 0 1.4213018 0 ;
	setAttr ".tk[355]" -type "float3" 0 0.10808962 0 ;
	setAttr ".tk[357]" -type "float3" 0 0.27464384 0 ;
	setAttr ".tk[368]" -type "float3" 0 0.072288744 0 ;
	setAttr ".tk[370]" -type "float3" 0 0.4790431 0 ;
	setAttr ".tk[371]" -type "float3" 0 0.8570596 0 ;
	setAttr ".tk[372]" -type "float3" 0 0.24166584 0 ;
	setAttr ".tk[373]" -type "float3" 0 1.0377417 0 ;
	setAttr ".tk[374]" -type "float3" 0 0.87806296 0 ;
	setAttr ".tk[375]" -type "float3" 0 0.66366744 0 ;
	setAttr ".tk[376]" -type "float3" 0 0.44515333 0 ;
	setAttr ".tk[377]" -type "float3" 0 0.041857708 0 ;
	setAttr ".tk[378]" -type "float3" 0 0.19968432 0 ;
	setAttr ".tk[379]" -type "float3" 0 1.6948956 0 ;
	setAttr ".tk[380]" -type "float3" 0 2.1356936 0 ;
	setAttr ".tk[381]" -type "float3" 0 1.9687502 0 ;
	setAttr ".tk[382]" -type "float3" 0 0.7847302 0 ;
	setAttr ".tk[383]" -type "float3" 0 1.6767344 0 ;
	setAttr ".tk[384]" -type "float3" 0 0.75479448 0 ;
	setAttr ".tk[385]" -type "float3" 0 1.4668957 0 ;
	setAttr ".tk[386]" -type "float3" 0 0.40345839 0 ;
	setAttr ".tk[387]" -type "float3" 0 0.16023719 0 ;
	setAttr ".tk[388]" -type "float3" 0 0.36175692 0 ;
	setAttr ".tk[401]" -type "float3" 0 0.13342461 0 ;
	setAttr ".tk[402]" -type "float3" 0 0.45904106 0 ;
	setAttr ".tk[403]" -type "float3" 0 0.5248782 0 ;
	setAttr ".tk[404]" -type "float3" 0 0.6612252 0 ;
	setAttr ".tk[405]" -type "float3" 0 0.57585043 0 ;
	setAttr ".tk[406]" -type "float3" 0 1.4791276 0 ;
	setAttr ".tk[407]" -type "float3" 0 0.37018004 0 ;
	setAttr ".tk[408]" -type "float3" 0 0.76724869 0 ;
	setAttr ".tk[409]" -type "float3" 0 1.9465977 0 ;
	setAttr ".tk[410]" -type "float3" 0 2.364275 0 ;
	setAttr ".tk[411]" -type "float3" 0 1.232926 0 ;
	setAttr ".tk[412]" -type "float3" 0 2.3176346 0 ;
	setAttr ".tk[413]" -type "float3" 0 3.0145245 0 ;
	setAttr ".tk[414]" -type "float3" 0 0.84799016 0 ;
	setAttr ".tk[415]" -type "float3" 0 0.29897323 0 ;
	setAttr ".tk[416]" -type "float3" 0 0.25992164 0 ;
	setAttr ".tk[417]" -type "float3" 0 0.15025888 0 ;
	setAttr ".tk[418]" -type "float3" 0 0.034532815 0 ;
	setAttr ".tk[430]" -type "float3" 0 0.21580921 0 ;
	setAttr ".tk[431]" -type "float3" 0 0.0043841815 0 ;
	setAttr ".tk[432]" -type "float3" 0 0.98284 0 ;
	setAttr ".tk[433]" -type "float3" 0 1.909922 0 ;
	setAttr ".tk[434]" -type "float3" 0 1.2255569 0 ;
	setAttr ".tk[435]" -type "float3" 0 2.155354 0 ;
	setAttr ".tk[436]" -type "float3" 0 2.9506874 0 ;
	setAttr ".tk[437]" -type "float3" 0 2.9597914 0 ;
	setAttr ".tk[438]" -type "float3" 0 2.8903883 0 ;
	setAttr ".tk[439]" -type "float3" 0 3.5055418 0 ;
	setAttr ".tk[440]" -type "float3" 0 3.4817929 0 ;
createNode deleteComponent -n "deleteComponent1";
	rename -uid "FB66F8A9-4B75-EB9A-1EBE-23A71CAE0D9F";
	setAttr ".dc" -type "componentList" 1 "f[74]";
createNode script -n "uiConfigurationScriptNode";
	rename -uid "51B6996B-4CF9-5C76-9B6B-73B2AC4ED9D9";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $nodeEditorPanelVisible = stringArrayContains(\"nodeEditorPanel1\", `getPanel -vis`);\n\tint    $nodeEditorWorkspaceControlOpen = (`workspaceControl -exists nodeEditorPanel1Window` && `workspaceControl -q -visible nodeEditorPanel1Window`);\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\n\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n"
		+ "            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n"
		+ "            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 660\n            -height 393\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n"
		+ "            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n"
		+ "            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 659\n            -height 393\n"
		+ "            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n"
		+ "            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n"
		+ "            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n"
		+ "            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 660\n            -height 393\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n"
		+ "            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 32768\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n"
		+ "            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -controllers 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n"
		+ "            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 659\n            -height 393\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"ToggledOutliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"ToggledOutliner\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n"
		+ "            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -isSet 0\n            -isSetMember 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            -renderFilterIndex 0\n            -selectionOrder \"chronological\" \n            -expandAttribute 0\n            $editorName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showAssignedMaterials 0\n            -showTimeEditor 1\n            -showReferenceNodes 0\n            -showReferenceMembers 0\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -organizeByClip 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showParentContainers 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n"
		+ "            -expandConnections 0\n            -showUpstreamCurves 1\n            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"0\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n"
		+ "            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n            -ignoreOutlinerColor 0\n            -renderFilterVisible 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n"
		+ "                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n"
		+ "                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 1\n                -autoFitTime 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n"
		+ "                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -showCurveNames 0\n                -showActiveCurveNames 0\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                -valueLinesToggle 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n"
		+ "            outlinerEditor -e \n                -showShapes 1\n                -showAssignedMaterials 0\n                -showTimeEditor 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -organizeByClip 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showParentContainers 1\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n"
		+ "                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                -renderFilterVisible 0\n"
		+ "                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"timeEditorPanel\" (localizedPanelLabel(\"Time Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Time Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n"
		+ "\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -displayValues 0\n                -autoFit 0\n                -autoFitTime 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -initialized 0\n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n"
		+ "                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif ($nodeEditorPanelVisible || $nodeEditorWorkspaceControlOpen) {\n"
		+ "\t\tif (\"\" == $panelName) {\n\t\t\tif ($useSceneConfig) {\n\t\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n"
		+ "                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\t}\n\t\t} else {\n\t\t\t$label = `panel -q -label $panelName`;\n\t\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -connectNodeOnCreation 0\n                -connectOnDrop 0\n                -copyConnectionsOnPaste 0\n                -connectionStyle \"bezier\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n"
		+ "                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -crosshairOnEdgeDragging 0\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -editorMode \"default\" \n                -hasWatchpoint 0\n                $editorName;\n\t\t\tif (!$useSceneConfig) {\n\t\t\t\tpanel -e -l $label $panelName;\n\t\t\t}\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"shapePanel\" (localizedPanelLabel(\"Shape Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tshapePanel -edit -l (localizedPanelLabel(\"Shape Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"posePanel\" (localizedPanelLabel(\"Pose Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tposePanel -edit -l (localizedPanelLabel(\"Pose Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"contentBrowserPanel\" (localizedPanelLabel(\"Content Browser\")) `;\n\tif (\"\" != $panelName) {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Content Browser\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-userCreated false\n\t\t\t\t-defaultImage \"\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"quad\\\" -ps 1 50 50 -ps 2 50 50 -ps 3 50 50 -ps 4 50 50 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Top View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Top View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera top` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 660\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Top View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera top` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 660\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 659\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 659\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Side View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Side View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera side` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 659\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Side View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera side` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 659\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Front View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Front View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera front` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 660\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Front View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera front` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 32768\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -controllers 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 660\\n    -height 393\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "5A451BFB-479C-C6E5-DEBC-40996927524E";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultRenderGlobals;
	setAttr ".ren" -type "string" "arnold";
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polyPlane1.out" "pPlaneShape1.i";
connectAttr "deleteComponent1.og" "pPlaneShape3.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "polySurfaceShape1.o" "polySubdFace1.ip";
connectAttr "polySubdFace1.out" "polyTweak1.ip";
connectAttr "polyTweak1.out" "deleteComponent1.ig";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pPlaneShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pPlaneShape3.iog" ":initialShadingGroup.dsm" -na;
// End of TutorialLevel.ma
