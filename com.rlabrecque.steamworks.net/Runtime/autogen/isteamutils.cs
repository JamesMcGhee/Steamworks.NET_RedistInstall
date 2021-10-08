// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2019 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#if !(UNITY_STANDALONE_WIN || UNITY_STANDALONE_LINUX || UNITY_STANDALONE_OSX || STEAMWORKS_WIN || STEAMWORKS_LIN_OSX)
	#define DISABLESTEAMWORKS
#endif

#if !DISABLESTEAMWORKS

using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Steamworks {
	public static class SteamUtils {
		/// <summary>
		/// <para> return the number of seconds since the user</para>
		/// </summary>
		public static uint GetSecondsSinceAppActive() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceAppActive(CSteamAPIContext.GetSteamUtils());
		}

		public static uint GetSecondsSinceComputerActive() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetSecondsSinceComputerActive(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> the universe this client is connecting to</para>
		/// </summary>
		public static EUniverse GetConnectedUniverse() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetConnectedUniverse(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Steam server time.  Number of seconds since January 1, 1970, GMT (i.e unix time)</para>
		/// </summary>
		public static uint GetServerRealTime() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetServerRealTime(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> returns the 2 digit ISO 3166-1-alpha-2 format country code this client is running in (as looked up via an IP-to-location database)</para>
		/// <para> e.g "US" or "UK".</para>
		/// </summary>
		public static string GetIPCountry() {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetIPCountry(CSteamAPIContext.GetSteamUtils()));
		}

		/// <summary>
		/// <para> returns true if the image exists, and valid sizes were filled out</para>
		/// </summary>
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageSize(CSteamAPIContext.GetSteamUtils(), iImage, out pnWidth, out pnHeight);
		}

		/// <summary>
		/// <para> returns true if the image exists, and the buffer was successfully filled out</para>
		/// <para> results are returned in RGBA format</para>
		/// <para> the destination buffer size should be 4 * height * width * sizeof(char)</para>
		/// </summary>
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetImageRGBA(CSteamAPIContext.GetSteamUtils(), iImage, pubDest, nDestBufferSize);
		}

		/// <summary>
		/// <para> return the amount of battery power left in the current system in % [0..100], 255 for being on AC power</para>
		/// </summary>
		public static byte GetCurrentBatteryPower() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetCurrentBatteryPower(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> returns the appID of the current process</para>
		/// </summary>
		public static AppId_t GetAppID() {
			InteropHelp.TestIfAvailableClient();
			return (AppId_t)NativeMethods.ISteamUtils_GetAppID(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Sets the position where the overlay instance for the currently calling game should show notifications.</para>
		/// <para> This position is per-game and if this function is called from outside of a game context it will do nothing.</para>
		/// </summary>
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationPosition(CSteamAPIContext.GetSteamUtils(), eNotificationPosition);
		}

		/// <summary>
		/// <para> API asynchronous call results</para>
		/// <para> can be used directly, but more commonly used via the callback dispatch API (see steam_api.h)</para>
		/// </summary>
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsAPICallCompleted(CSteamAPIContext.GetSteamUtils(), hSteamAPICall, out pbFailed);
		}

		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallFailureReason(CSteamAPIContext.GetSteamUtils(), hSteamAPICall);
		}

		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetAPICallResult(CSteamAPIContext.GetSteamUtils(), hSteamAPICall, pCallback, cubCallback, iCallbackExpected, out pbFailed);
		}

		/// <summary>
		/// <para> returns the number of IPC calls made since the last time this function was called</para>
		/// <para> Used for perf debugging so you can understand how many IPC calls your game makes per frame</para>
		/// <para> Every IPC call is at minimum a thread context switch if not a process one so you want to rate</para>
		/// <para> control how often you do them.</para>
		/// </summary>
		public static uint GetIPCCallCount() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetIPCCallCount(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> API warning handling</para>
		/// <para> 'int' is the severity; 0 for msg, 1 for warning</para>
		/// <para> 'const char *' is the text of the message</para>
		/// <para> callbacks will occur directly after the API function is called that generated the warning or message</para>
		/// </summary>
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetWarningMessageHook(CSteamAPIContext.GetSteamUtils(), pFunction);
		}

		/// <summary>
		/// <para> Returns true if the overlay is running &amp; the user can access it. The overlay process could take a few seconds to</para>
		/// <para> start &amp; hook the game process, so this function will initially return false while the overlay is loading.</para>
		/// </summary>
		public static bool IsOverlayEnabled() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsOverlayEnabled(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Normally this call is unneeded if your game has a constantly running frame loop that calls the</para>
		/// <para> D3D Present API, or OGL SwapBuffers API every frame.</para>
		/// <para> However, if you have a game that only refreshes the screen on an event driven basis then that can break</para>
		/// <para> the overlay, as it uses your Present/SwapBuffers calls to drive it's internal frame loop and it may also</para>
		/// <para> need to Present() to the screen any time an even needing a notification happens or when the overlay is</para>
		/// <para> brought up over the game by a user.  You can use this API to ask the overlay if it currently need a present</para>
		/// <para> in that case, and then you can check for this periodically (roughly 33hz is desirable) and make sure you</para>
		/// <para> refresh the screen with Present or SwapBuffers to allow the overlay to do it's work.</para>
		/// </summary>
		public static bool BOverlayNeedsPresent() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_BOverlayNeedsPresent(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Asynchronous call to check if an executable file has been signed using the public key set on the signing tab</para>
		/// <para> of the partner site, for example to refuse to load modified executable files.</para>
		/// <para> The result is returned in CheckFileSignature_t.</para>
		/// <para>   k_ECheckFileSignatureNoSignaturesFoundForThisApp - This app has not been configured on the signing tab of the partner site to enable this function.</para>
		/// <para>   k_ECheckFileSignatureNoSignaturesFoundForThisFile - This file is not listed on the signing tab for the partner site.</para>
		/// <para>   k_ECheckFileSignatureFileNotFound - The file does not exist on disk.</para>
		/// <para>   k_ECheckFileSignatureInvalidSignature - The file exists, and the signing tab has been set for this file, but the file is either not signed or the signature does not match.</para>
		/// <para>   k_ECheckFileSignatureValidSignature - The file is signed and the signature is valid.</para>
		/// </summary>
		public static SteamAPICall_t CheckFileSignature(string szFileName) {
			InteropHelp.TestIfAvailableClient();
			using (var szFileName2 = new InteropHelp.UTF8StringHandle(szFileName)) {
				return (SteamAPICall_t)NativeMethods.ISteamUtils_CheckFileSignature(CSteamAPIContext.GetSteamUtils(), szFileName2);
			}
		}

		/// <summary>
		/// <para> Activates the full-screen text input dialog which takes a initial text string and returns the text the user has typed</para>
		/// </summary>
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText) {
			InteropHelp.TestIfAvailableClient();
			using (var pchDescription2 = new InteropHelp.UTF8StringHandle(pchDescription))
			using (var pchExistingText2 = new InteropHelp.UTF8StringHandle(pchExistingText)) {
				return NativeMethods.ISteamUtils_ShowGamepadTextInput(CSteamAPIContext.GetSteamUtils(), eInputMode, eLineInputMode, pchDescription2, unCharMax, pchExistingText2);
			}
		}

		/// <summary>
		/// <para> Returns previously entered text &amp; length</para>
		/// </summary>
		public static uint GetEnteredGamepadTextLength() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetEnteredGamepadTextLength(CSteamAPIContext.GetSteamUtils());
		}

		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchText2 = Marshal.AllocHGlobal((int)cchText);
			bool ret = NativeMethods.ISteamUtils_GetEnteredGamepadTextInput(CSteamAPIContext.GetSteamUtils(), pchText2, cchText);
			pchText = ret ? InteropHelp.PtrToStringUTF8(pchText2) : null;
			Marshal.FreeHGlobal(pchText2);
			return ret;
		}

		/// <summary>
		/// <para> returns the language the steam client is running in, you probably want ISteamApps::GetCurrentGameLanguage instead, this is for very special usage cases</para>
		/// </summary>
		public static string GetSteamUILanguage() {
			InteropHelp.TestIfAvailableClient();
			return InteropHelp.PtrToStringUTF8(NativeMethods.ISteamUtils_GetSteamUILanguage(CSteamAPIContext.GetSteamUtils()));
		}

		/// <summary>
		/// <para> returns true if Steam itself is running in VR mode</para>
		/// </summary>
		public static bool IsSteamRunningInVR() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamRunningInVR(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Sets the inset of the overlay notification from the corner specified by SetOverlayNotificationPosition.</para>
		/// </summary>
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetOverlayNotificationInset(CSteamAPIContext.GetSteamUtils(), nHorizontalInset, nVerticalInset);
		}

		/// <summary>
		/// <para> returns true if Steam &amp; the Steam Overlay are running in Big Picture mode</para>
		/// <para> Games much be launched through the Steam client to enable the Big Picture overlay. During development,</para>
		/// <para> a game can be added as a non-steam game to the developers library to test this feature</para>
		/// </summary>
		public static bool IsSteamInBigPictureMode() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamInBigPictureMode(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> ask SteamUI to create and render its OpenVR dashboard</para>
		/// </summary>
		public static void StartVRDashboard() {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_StartVRDashboard(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Returns true if the HMD content will be streamed via Steam Remote Play</para>
		/// </summary>
		public static bool IsVRHeadsetStreamingEnabled() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsVRHeadsetStreamingEnabled(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Set whether the HMD content will be streamed via Steam Remote Play</para>
		/// <para> If this is set to true, then the scene in the HMD headset will be streamed, and remote input will not be allowed.</para>
		/// <para> If this is set to false, then the application window will be streamed instead, and remote input will be allowed.</para>
		/// <para> The default is true unless "VRHeadsetStreaming" "0" is in the extended appinfo for a game.</para>
		/// <para> (this is useful for games that have asymmetric multiplayer gameplay)</para>
		/// </summary>
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetVRHeadsetStreamingEnabled(CSteamAPIContext.GetSteamUtils(), bEnabled);
		}

		/// <summary>
		/// <para> Returns whether this steam client is a Steam China specific client, vs the global client.</para>
		/// </summary>
		public static bool IsSteamChinaLauncher() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamChinaLauncher(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Initializes text filtering, loading dictionaries for the language the game is running in.</para>
		/// <para>   unFilterOptions are reserved for future use and should be set to 0</para>
		/// <para> Returns false if filtering is unavailable for the game's language, in which case FilterText() will act as a passthrough.</para>
		/// <para> Users can customize the text filter behavior in their Steam Account preferences:</para>
		/// <para> https://store.steampowered.com/account/preferences#CommunityContentPreferences</para>
		/// </summary>
		public static bool InitFilterText(uint unFilterOptions = 0) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_InitFilterText(CSteamAPIContext.GetSteamUtils(), unFilterOptions);
		}

		/// <summary>
		/// <para> Filters the provided input message and places the filtered result into pchOutFilteredText, using legally required filtering and additional filtering based on the context and user settings</para>
		/// <para>   eContext is the type of content in the input string</para>
		/// <para>   sourceSteamID is the Steam ID that is the source of the input string (e.g. the player with the name, or who said the chat text)</para>
		/// <para>   pchInputText is the input string that should be filtered, which can be ASCII or UTF-8</para>
		/// <para>   pchOutFilteredText is where the output will be placed, even if no filtering is performed</para>
		/// <para>   nByteSizeOutFilteredText is the size (in bytes) of pchOutFilteredText, should be at least strlen(pchInputText)+1</para>
		/// <para> Returns the number of characters (not bytes) filtered</para>
		/// </summary>
		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText) {
			InteropHelp.TestIfAvailableClient();
			IntPtr pchOutFilteredText2 = Marshal.AllocHGlobal((int)nByteSizeOutFilteredText);
			using (var pchInputMessage2 = new InteropHelp.UTF8StringHandle(pchInputMessage)) {
				int ret = NativeMethods.ISteamUtils_FilterText(CSteamAPIContext.GetSteamUtils(), eContext, sourceSteamID, pchInputMessage2, pchOutFilteredText2, nByteSizeOutFilteredText);
				pchOutFilteredText = ret != -1 ? InteropHelp.PtrToStringUTF8(pchOutFilteredText2) : null;
				Marshal.FreeHGlobal(pchOutFilteredText2);
				return ret;
			}
		}

		/// <summary>
		/// <para> Return what we believe your current ipv6 connectivity to "the internet" is on the specified protocol.</para>
		/// <para> This does NOT tell you if the Steam client is currently connected to Steam via ipv6.</para>
		/// </summary>
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_GetIPv6ConnectivityState(CSteamAPIContext.GetSteamUtils(), eProtocol);
		}

		/// <summary>
		/// <para> returns true if currently running on the Steam Deck device</para>
		/// </summary>
		public static bool IsSteamRunningOnSteamDeck() {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_IsSteamRunningOnSteamDeck(CSteamAPIContext.GetSteamUtils());
		}

		/// <summary>
		/// <para> Opens a floating keyboard over the game content and sends OS keyboard keys directly to the game.</para>
		/// <para> The text field position is specified in pixels relative the origin of the game window and is used to position the floating keyboard in a way that doesn't cover the text field</para>
		/// </summary>
		public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUtils_ShowFloatingGamepadTextInput(CSteamAPIContext.GetSteamUtils(), eKeyboardMode, nTextFieldXPosition, nTextFieldYPosition, nTextFieldWidth, nTextFieldHeight);
		}

		/// <summary>
		/// <para> In game launchers that don't have controller support you can call this to have Steam Input translate the controller input into mouse/kb to navigate the launcher</para>
		/// </summary>
		public static void SetGameLauncherMode(bool bLauncherMode) {
			InteropHelp.TestIfAvailableClient();
			NativeMethods.ISteamUtils_SetGameLauncherMode(CSteamAPIContext.GetSteamUtils(), bLauncherMode);
		}
	}
}

#endif // !DISABLESTEAMWORKS
