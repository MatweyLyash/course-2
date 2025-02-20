
// ChildView.h: интерфейс класса CChildView
//


#pragma once


// Окно CChildView

class CChildView : public CWnd
{
// Создание
public:
	CChildView();

// Атрибуты
public:
	double Radius;
	CRect WinRect;
	CMatrix PView;
	CMatrix PSourceLight;
	int Index;
	COLORREF Color;

// Операции
public:

// Переопределение
	protected:
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);

// Реализация
public:
	virtual ~CChildView();

	// Созданные функции схемы сообщений
protected:
	afx_msg void OnPaint();
	DECLARE_MESSAGE_MAP()
public:
	// действия при выборе пункта меню
	afx_msg void OnSphere_Mirror();
	afx_msg void OnSphere_Diffuse(); 
	afx_msg void OnSize(UINT nType, int cx, int cy);
	afx_msg void SetCameraPosition();
	afx_msg void SetLightSourcePosition();
	afx_msg void SetLightColor();
};
