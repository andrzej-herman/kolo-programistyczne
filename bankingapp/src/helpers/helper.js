export const getPolishDate = (date) => {
  var year = date.substr(0, 4);
  var day = date.substr(8, 2);
  var m = date.substr(5, 2);
  var month = "";
  switch (m) {
    case "01":
      month = "stycznia";
      break;
    case "02":
      month = "lutego";
      break;
    case "03":
      month = "marca";
      break;
    case "04":
      month = "kwietnia";
      break;
    case "05":
      month = "maja";
      break;
    case "06":
      month = "czerwca";
      break;
    case "07":
      month = "lipca";
      break;
    case "08":
      month = "sierpnia";
      break;
    case "09":
      month = "września";
      break;
    case "10":
      month = "października";
      break;
    case "11":
      month = "listopada";
      break;
    case "12":
      month = "grudnia";
      break;
    default:
      month = "";
      break;
  }
  return `${day} ${month} ${year} r.`;
};
