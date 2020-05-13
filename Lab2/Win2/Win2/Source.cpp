#include <windows.h>

#include <fstream>

#include <mmsystem.h>

#pragma comment(lib, "winmm")

const wchar_t ClassName[] = L"Win2";

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)

{

	HDC hdc;

	PAINTSTRUCT ps;

	HWND find = FindWindow(L"Win1", L"FW1");

	switch (msg)

	{

	case WM_USER + 1: {

		SetWindowPos(hwnd, HWND_BOTTOM, 0, 0, 500, 100, SWP_NOMOVE);

	}

					  return 0;

	case WM_USER + 2: {

		ShowWindow(hwnd, SW_MAXIMIZE);

	}return 0;

	case WM_LBUTTONUP: {

		exit(EXIT_FAILURE); }

	case WM_RBUTTONUP:

		exit(EXIT_FAILURE);

		return 0;

	case WM_CLOSE:

		DestroyWindow(hwnd);

		break;

	case WM_DESTROY:

		PostQuitMessage(0);

		break;

	default:

		return DefWindowProc(hwnd, msg, wParam, lParam);

	}

	return 0;

}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)

{

	WNDCLASSEX wc;

	HWND hwnd;

	MSG Msg;

	wc.cbSize = sizeof(WNDCLASSEX);

	wc.style = 0;

	wc.lpfnWndProc = WndProc;

	wc.cbClsExtra = 0;

	wc.cbWndExtra = 0;

	wc.hInstance = hInstance;

	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);

	wc.hCursor = LoadCursor(NULL, IDC_ARROW);

	wc.hbrBackground = CreateSolidBrush(RGB(255, 215, 0));

	wc.lpszMenuName = NULL;

	wc.lpszClassName = ClassName;

	wc.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

	if (!RegisterClassEx(&wc))

	{

		MessageBox(NULL, L"Window Registration Failed!", L"Error!", MB_ICONEXCLAMATION | MB_OK);

		return 0;

	}

	hwnd = CreateWindowEx(WS_EX_CLIENTEDGE, ClassName, L"FW2", WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 700, 500, NULL, NULL, hInstance, NULL);

	if (hwnd == NULL)

	{

		MessageBox(NULL, L"Window Creation Failed!", L"Error!", MB_ICONEXCLAMATION | MB_OK);

		return 0;

	}

	ShowWindow(hwnd, nCmdShow);

	UpdateWindow(hwnd);

	while (GetMessage(&Msg, NULL, 0, 0) > 0)

	{

		TranslateMessage(&Msg);

		DispatchMessage(&Msg);

	}

	return Msg.wParam;

}