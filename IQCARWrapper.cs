﻿using System;
using System.Runtime.InteropServices;
using System.Text;

public interface IQCARWrapper
{
    int CameraDeviceDeinitCamera();
    int CameraDeviceGetNumVideoModes();
    void CameraDeviceGetVideoMode(int idx, [In, Out] IntPtr videoMode);
    int CameraDeviceInitCamera(int camera);
    int CameraDeviceSelectVideoMode(int idx);
    int CameraDeviceSetCameraConfiguration(int width, int height);
    int CameraDeviceSetFlashTorchMode(int on);
    int CameraDeviceSetFocusMode(int focusMode);
    int CameraDeviceStartCamera();
    int CameraDeviceStopCamera();
    int CylinderTargetGetSize(IntPtr dataSetPtr, string trackableName, [In, Out] IntPtr dimensions);
    int CylinderTargetSetBottomDiameter(IntPtr dataSetPtr, string trackableName, float bottomDiameter);
    int CylinderTargetSetSideLength(IntPtr dataSetPtr, string trackableName, float sideLength);
    int CylinderTargetSetTopDiameter(IntPtr dataSetPtr, string trackableName, float topDiameter);
    int DataSetCreateTrackable(IntPtr dataSetPtr, IntPtr trackableSourcePtr, StringBuilder trackableName, int nameMaxLength, [In, Out] IntPtr trackableData);
    int DataSetDestroyTrackable(IntPtr dataSetPtr, int trackableId);
    int DataSetExists(string relativePath, int storageType);
    int DataSetGetNumTrackableType(int trackableType, IntPtr dataSetPtr);
    int DataSetGetTrackableName(IntPtr dataSetPtr, int trackableId, StringBuilder trackableName, int nameMaxLength);
    int DataSetGetTrackablesOfType(int trackableType, [In, Out] IntPtr trackableDataArray, int trackableDataArrayLength, IntPtr dataSetPtr);
    int DataSetHasReachedTrackableLimit(IntPtr dataSetPtr);
    int DataSetLoad(string relativePath, int storageType, IntPtr dataSetPtr);
    void DeinitFrameState([In, Out] IntPtr frameIndex);
    int GetInitErrorCode();
    int GetProjectionGL(float nearClip, float farClip, [In, Out] IntPtr projMatrix, int screenOrientation);
    int GetSurfaceOrientation();
    bool HasSurfaceBeenRecreated();
    int ImageTargetBuilderBuild(string targetName, float sceenSizeWidth);
    int ImageTargetBuilderGetFrameQuality();
    IntPtr ImageTargetBuilderGetTrackableSource();
    void ImageTargetBuilderStartScan();
    void ImageTargetBuilderStopScan();
    int ImageTargetCreateVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In, Out] IntPtr rectData);
    int ImageTargetDestroyVirtualButton(IntPtr dataSetPtr, string trackableName, string virtualButtonName);
    int ImageTargetGetNumVirtualButtons(IntPtr dataSetPtr, string trackableName);
    int ImageTargetGetSize(IntPtr dataSetPtr, string trackableName, [In, Out] IntPtr size);
    int ImageTargetGetVirtualButtonName(IntPtr dataSetPtr, string trackableName, int idx, StringBuilder vbName, int nameMaxLength);
    int ImageTargetGetVirtualButtons([In, Out] IntPtr virtualButtonDataArray, [In, Out] IntPtr rectangleDataArray, int virtualButtonDataArrayLength, IntPtr dataSetPtr, string trackableName);
    int ImageTargetSetSize(IntPtr dataSetPtr, string trackableName, [In, Out] IntPtr size);
    int ImageTrackerActivateDataSet(IntPtr dataSetPtr);
    IntPtr ImageTrackerCreateDataSet();
    int ImageTrackerDeactivateDataSet(IntPtr dataSetPtr);
    int ImageTrackerDestroyDataSet(IntPtr dataSetPtr);
    int ImageTrackerPersistExtendedTracking(int on);
    int ImageTrackerResetExtendedTracking();
    int ImageTrackerStart();
    void ImageTrackerStop();
    void InitFrameState([In, Out] IntPtr frameIndex);
    int IsRendererDirty();
    int MarkerSetSize(int trackableIndex, float size);
    int MarkerTrackerCreateMarker(int id, string trackableName, float size);
    int MarkerTrackerDestroyMarker(int trackableId);
    int MarkerTrackerStart();
    void MarkerTrackerStop();
    void OnSurfaceChanged(int width, int height);
    void OnSurfaceCreated();
    int PausedUpdateQCAR();
    void QcarAddCameraFrame(IntPtr pixels, int width, int height, int format, int stride, int frameIdx, int flipHorizontally);
    int QcarDeinit();
    int QcarGetBufferSize(int width, int height, int format);
    int QcarRequiresAlpha();
    int QcarSetFrameFormat(int format, int enabled);
    int QcarSetHint(int hint, int value);
    void RendererEnd();
    void RendererGetVideoBackgroundCfg([In, Out] IntPtr bgCfg);
    void RendererGetVideoBackgroundTextureInfo([In, Out] IntPtr texInfo);
    int RendererIsVideoBackgroundTextureInfoAvailable();
    void RendererRenderVideoBackground(int bindVideoBackground);
    void RendererSetVideoBackgroundCfg([In, Out] IntPtr bgCfg);
    int RendererSetVideoBackgroundTextureID(int textureID);
    void SetSurfaceOrientation(int orientation);
    void SetUnityVersion(int major, int minor, int change);
    int StartExtendedTracking(IntPtr dataSetPtr, int trackableId);
    int StopExtendedTracking(IntPtr dataSetPtr, int trackableId);
    void TargetFinderClearTrackables();
    int TargetFinderDeinit();
    int TargetFinderEnableTracking(IntPtr searchResult, [In, Out] IntPtr trackableData);
    void TargetFinderGetImageTargets([In, Out] IntPtr trackableIdArray, int trackableIdArrayLength);
    int TargetFinderGetInitState();
    int TargetFinderGetResults([In, Out] IntPtr searchResultArray, int searchResultArrayLength);
    void TargetFinderSetUIPointColor(float r, float g, float b);
    void TargetFinderSetUIScanlineColor(float r, float g, float b);
    int TargetFinderStartInit(string userKey, string secretKey);
    int TargetFinderStartRecognition();
    int TargetFinderStop();
    void TargetFinderUpdate([In, Out] IntPtr targetFinderState);
    void TextTrackerGetRegionOfInterest([In, Out] IntPtr detectionROI, [In, Out] IntPtr trackingROI);
    int TextTrackerSetRegionOfInterest(int detectionLeftTopX, int detectionLeftTopY, int detectionRightBottomX, int detectionRightBottomY, int trackingLeftTopX, int trackingLeftTopY, int trackingRightBottomX, int trackingRightBottomY, int upDirection);
    int TextTrackerStart();
    void TextTrackerStop();
    int TrackerManagerDeinitTracker(int trackerType);
    int TrackerManagerInitTracker(int trackerType);
    int UpdateQCAR([In, Out] IntPtr imageHeaderDataArray, int imageHeaderArrayLength, [In, Out] IntPtr frameIndex, int screenOrientation, int videoModeIdx);
    int VirtualButtonGetId(IntPtr dataSetPtr, string trackableName, string virtualButtonName);
    int VirtualButtonSetAreaRectangle(IntPtr dataSetPtr, string trackableName, string virtualButtonName, [In, Out] IntPtr rectData);
    int VirtualButtonSetEnabled(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int enabled);
    int VirtualButtonSetSensitivity(IntPtr dataSetPtr, string trackableName, string virtualButtonName, int sensitivity);
    int WordGetLetterBoundingBoxes(int wordID, [In, Out] IntPtr letterBoundingBoxes);
    int WordGetLetterMask(int wordID, [In, Out] IntPtr letterMaskImage);
    int WordListAddWordsFromFile(string path, int storagetType);
    int WordListAddWordToFilterListU(IntPtr word);
    int WordListAddWordU(IntPtr word);
    int WordListClearFilterList();
    int WordListContainsWordU(IntPtr word);
    int WordListGetFilterListWordCount();
    IntPtr WordListGetFilterListWordU(int index);
    int WordListGetFilterMode();
    int WordListLoadFilterList(string path, int storageType);
    int WordListLoadWordList(string path, int storageType);
    int WordListRemoveWordFromFilterListU(IntPtr word);
    int WordListRemoveWordU(IntPtr word);
    int WordListSetFilterMode(int mode);
    int WordListUnloadAllLists();
}

