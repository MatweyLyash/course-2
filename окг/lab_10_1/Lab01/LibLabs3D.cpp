#include "stdafx.h"
#include "CMatrix.h"
#include "LibGraph.h"
#include "math.h"
#include "LibLabs3D.h"

void DrawLightSphere(CDC& dc, double Radius, CMatrix& PView, CMatrix& PSourceLight, CRect RW, COLORREF Color, int Index)
// ������ ����� � ������ ������������
// Radius - ������ �����
// PView - ���������� ����� ���������� � ������� ����������� ������� ���������
// PSourceLight - ���������� ��������� ����� � ������� ����������� ������� ���������
// RW - ������� � ���� ��� ����������� ����
// Color - ���� ��������� �����
// Index=0 -  ������������ ������ ��������� ����� :cos(e)
// Index=1 -  ���������� ������ ��������� ����� :[cos(a)]^n
{
    // ���������� ���������
	BYTE red = GetRValue(Color);
	BYTE green = GetGValue(Color);
	BYTE blue = GetBValue(Color);

	CMatrix VSphere(3), VSphereNorm(3), PV(4);  // V0(3)
	COLORREF Col;   // ���� �������

	double df = 0.5;                            // ��� �� ���� ��
	double dq = 0.5;                            // ��� �� ���� ����
	double kLight;
	VSphere(0) = Radius;	                    // ������ �����

	CMatrix VR = SphereToCart(PView);       	// ��������� ���������� ����� ����������
	CMatrix VS = SphereToCart(PSourceLight);    // ��������� ���������� ��������� �����

	CRectD  RV(-Radius, Radius, Radius, -Radius);   // ������� � ������� ����������� � ��������� XY
                                                    // ��� ����������� �������� ����

	CMatrix MW = SpaceToWindow(RV, RW);		                        // ������� (3 �� 3)��������� � ������� ������� ���������
	CMatrix MV = CreateViewCoord(PView(0), PView(1), PView(2));	    // �������(4 �� 4) ��������� � ������� ������� ���������

    // �������� �� ������ �����
    for (double fi = 0; fi <= 360.0; fi += df) {
        for (double q = 0; q <= 180.0; q += dq)
        {
            VSphere(1) = fi;
            VSphere(2) = q;

            CMatrix VCart = SphereToCart(VSphere);	    // ��������� ���������� ����� �����  

            VSphereNorm = VCart;				        // ������ ������� � ����������� �����!
            CMatrix VK = VR - VSphereNorm;              // ����������� �� ����� ���������� ������������
                                                        // ������� � ����� �������

            double cos_RN = CosV1V2(VK, VSphereNorm);   // ������� ���� ����� �������� ����� ����������
                                                        // � �������� ������� � ����� �����

            if (cos_RN > 0)             // ���� ����� ������ �����������...
            {
                PV(0) = VCart(0);
                PV(1) = VCart(1);
                PV(2) = VCart(2);
                PV(3) = 1;
                PV = MV * PV;           // ���������� ����� � ������� ������� ���������

                VCart(0) = PV(0);  
                VCart(1) = PV(1);  
                VCart(2) = 1;
                VCart = MW * VCart;      // ������� ���������� ������� ����� �����		

                CMatrix VP = VS - VSphereNorm;          // ������, ������������ ����������� ����� 
                                                        // �� ����� �� ����� �� ��������� �����.

                double cos_PN = CosV1V2(VP, VSphereNorm);       // ������� ���� ������� ���� ( ����� VP � 
                                                                // �������� VSphereNor
                if (cos_PN > 0)	            // ���� ����� ����� ����������...
                {
                    if (Index == 0)         // ������������ ������ ���������
                    {
                        kLight = cos_PN * cos_RN;
                    }
                    if (Index == 1)         // ���������� ������ ���������
                    {
                        // VP - ������, ������������ ����������� �� �������� �����
                        // VSphereNorm - ������ ������� � �������� �����������
                        // RX - ������, ����������� ����������� ����

                        double x = 2 * ScalarMult(VSphereNorm, VP) / ModVec(VSphereNorm) * ModVec(VSphereNorm);
                        CMatrix RX = VSphereNorm * x - VP;

                        double cos_A = CosV1V2(RX, VR);                 // ������� ���� ����� ���������� ����� � 
                                                                        // �������� ����������
                        if (cos_A > 0)
                            kLight = cos_A * cos_A * cos_A * cos_A * cos_A * cos_A * cos_A * cos_A * cos_A * cos_A;     // (cos^4)
                        else 
                            kLight = 0;
                    }

                    Col = RGB(kLight * red, kLight * green, kLight * blue);
                    dc.SetPixel((int)VCart(0), (int)VCart(1), Col);
                }
                else
                {
                    Col = RGB(0, 0, 0);
                    dc.SetPixel((int)VCart(0), (int)VCart(1), Col);
                }
            }
        }
    }
}