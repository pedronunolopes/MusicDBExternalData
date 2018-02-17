package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_VNVenueRecord implements Serializable, Cloneable, ITypedRecord<RCt_VNVenueRecord> {

	private static final GlobalObjectKey Idt_VNVenue = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*BcRPpUuvu2TvGCyuiPAN+w");

	public static void ensureInitialized() {}
	public ENt_VNVenueEntityRecord ssENt_VNVenue;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_VNVenueEntityRecord toStructure() {
		return ssENt_VNVenue;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_VNVenueRecord(ENt_VNVenueEntityRecord r) throws Exception {
		ssENt_VNVenue = (ENt_VNVenueEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_VNVenue.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_VNVenue.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_VNVenueRecord() {
		OptimizedAttributes = null;
		ssENt_VNVenue = new ENt_VNVenueEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(11, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_VNVenue.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_VNVenue.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_VNVenue.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_VNVenue.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_VNVenueRecord r) throws Exception {
		this.ssENt_VNVenue = (ENt_VNVenueEntityRecord) r.ssENt_VNVenue.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_VNVenueRecord)) {
			return false;
		}
		RCt_VNVenueRecord b = (RCt_VNVenueRecord) obj;
		if (!this.ssENt_VNVenue.equals(b.ssENt_VNVenue)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_VNVenue.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_VNVenue.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_VNVenue.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_VNVenueRecord duplicate() throws Exception {
		RCt_VNVenueRecord t = new RCt_VNVenueRecord();
		t.ssENt_VNVenue = (ENt_VNVenueEntityRecord) this.ssENt_VNVenue.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_VNVenue.toXml(this, recordElem, "t_VNVenue", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_vnvenue")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_VNVenue")) variable.setValue(ssENt_VNVenue); else variable.setOptimized(true);
			variable.setFieldName("t_vnvenue");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_VNVenueRecord t = (RCt_VNVenueRecord) super.clone();
		t.ssENt_VNVenue = (ENt_VNVenueEntityRecord) this.ssENt_VNVenue.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_VNVenue.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_VNVenue.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_VNVenue)) {
			return ssENt_VNVenue;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_VNVenue.fillFromOther((IRecord) other.attributeGet(Idt_VNVenue));
	}
}
